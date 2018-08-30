using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autopick4NDHU
{
    public partial class Form1 : Form
    {
        private static readonly string[] sfVal = { "XGYMA壽館場A-籃球", "XGMB1壽館場B-羽1", "XGMB2壽館場B-羽2", "XGMB3壽館場B-羽3",
            "XGMB4壽館場B-羽4", "XGMC1壽館場C-排1", "XGMC2壽館場C-排2", "XGMC3壽館場C-排3", "XGMC4壽館場C-排4" };
        WbsControl wbsControl;
        ToolTip tip;
        private bool stop;
        private bool isSaved; // Clicked save button
        private bool isBooked; // Booked the sport field
        private bool isFinished; // Submitted the request website
        private bool isAutostartup;
        private bool isAutobook;
        System.Timers.Timer startupTimer, autorunTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Turn off validation when a control loses focus. This will be inherited by child
            // controls on the form, enabling us to validate the entire form when the 
            // button is clicked instead of one control at a time.
            this.AutoValidate = AutoValidate.Disable;

            txtAcct.Select();
            if (Properties.Settings.Default.RmbStudentID)
                txtAcct.Text = Properties.Settings.Default.StudentIDSetting;
            if (Properties.Settings.Default.RmbPassword)
                txtPwd.Text = Properties.Settings.Default.PasswordSetting;

            // DateTimePicker
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy/MM/dd";
            dtpDate.MinDate = DateTime.Today.AddDays(6);
            dtpDate.MaxDate = dtpDate.MinDate.AddDays(6);

            // Start hour combobox
            for (int i = 6; i < 23; ++i)
            {
                cmbStartHour.Items.Add(new ComboItem { Text = i.ToString(), Value = i.ToString() });
            }
            cmbStartHour.DisplayMember = "Text";
            cmbStartHour.ValueMember = "Value";
            cmbStartHour.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStartHour.SelectedIndex = -1;

            // End hour combobox
            cmbEndHour.DisplayMember = "Text";
            cmbEndHour.ValueMember = "Value";
            cmbEndHour.DropDownStyle = ComboBoxStyle.DropDownList;

            // Sport fields combobox
            for (int i = 0; i < sfVal.Length; ++i)
            {
                cmbSportFields.Items.Add(SFSplit(sfVal[i]));
            }
            cmbSportFields.DisplayMember = "Text";
            cmbSportFields.ValueMember = "Value";
            cmbSportFields.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSportFields.SelectedIndex = -1;

            wbsControl = new WbsControl(webBrowser1);

            // Create a tooltip
            tip = new ToolTip();

            // Set up the delays for the ToolTip.
            tip.AutoPopDelay = 5000;
            tip.InitialDelay = 500;
            tip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            tip.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            tip.SetToolTip(cmbStartHour, "Starting hour");
            tip.SetToolTip(cmbEndHour, "Ending hour");
            tip.SetToolTip(txtShowInfo, "Show the info");
            tip.SetToolTip(btnSave, "Save the input");
            tip.SetToolTip(btnNav, "Go to the target website and start processing");
            tip.SetToolTip(btnStop, "Stop all processes of the web browser");

            startupTimer = new System.Timers.Timer();
            autorunTimer = new System.Timers.Timer();

            stop = isSaved = isBooked = isFinished = false;
            isAutostartup = Properties.Settings.Default.AutoStartup;
            isAutobook = Properties.Settings.Default.AutoBook;
        }

        private ComboItem SFSplit(string str)
        {
            return new ComboItem { Value = str.Substring(0, 5), Text = str.Substring(5, str.Length - 5) };
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!isSaved || stop)
            {
                txtShowInfo.Text = "Negative";
                return;
            }

            if (e.Url.ToString() == Global.MAIN_URL)
            {
                if (wbsControl.isLogin())
                {
                    if (isFinished) // Entire process is done
                    {
                        txtShowInfo.Text = "Booking is done perfectly!!!";
                        return;
                    }

                    if (wbsControl.isOnReqPage())
                    {
                        if (isBooked)
                        {
                            txtShowInfo.Text = "Filling the rent reason textbox";
                            wbsControl.FillReason();
                            isFinished = true;
                        }
                        else
                        {
                            txtShowInfo.Text = "Searching the target (sport field)";
                            wbsControl.BookField();
                            isBooked = true;
                        }
                    }
                    else // Click and go to the request page
                    {
                        txtShowInfo.Text = "Going to application page";
                        wbsControl.getById("MainContent_Button2").InvokeMember("click");
                    }
                }
                else
                {
                    txtShowInfo.Text = "Navigating to the login page";
                    webBrowser1.Navigate(Global.LOGIN_URL);
                }
            }
            else if (e.Url.ToString() == Global.LOGIN_URL)
            {
                txtShowInfo.Text = "Filling in the id and pwd";
                wbsControl.Login();
            }
        }

        private void cmbStartHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox sh = sender as ComboBox;
            cmbEndHour.Items.Clear();

            int n = Int32.Parse(sh.Text);
            if (n < 23)
            {
                cmbEndHour.Items.Add(new ComboItem { Text = (n + 1).ToString(), Value = (n + 1).ToString() });
            }
            if (n < 22)
            {
                cmbEndHour.Items.Add(new ComboItem { Text = (n + 2).ToString(), Value = (n + 2).ToString() });
            }
            cmbEndHour.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Input incorrectly");
                return;
            }

            wbsControl.Acct = txtAcct.Text;
            wbsControl.Pwd = txtPwd.Text;
            wbsControl.SFValue = ((ComboItem)cmbSportFields.SelectedItem).Value;
            wbsControl.Date = dtpDate.Text;
            wbsControl.Hour = cmbStartHour.Text + "~" + cmbEndHour.Text;

            txtShowInfo.Text = "ID: " + txtAcct.Text +
                "\r\nPassword: " + txtPwd.Text +
                "\r\nSport fields: " + cmbSportFields.Text +
                "\r\nDate: " + dtpDate.Text +
                "\r\nHour: " + cmbStartHour.Text + "~" + cmbEndHour.Text;

            isSaved = true;

            InitAutorunTimer();
        }

        private void InitAutorunTimer()
        {
            autorunTimer.AutoReset = false;
            autorunTimer.Elapsed += new System.Timers.ElapsedEventHandler(btnNav_Click);
            autorunTimer.SynchronizingObject = this; // Back to the main thread when time is up

            DateTime dtAuto = DateTime.Parse(Properties.Settings.Default.LoginTime);
            TimeSpan ts;
            if(dtAuto.CompareTo(DateTime.Now) > 0)
            {
                ts = dtAuto.Subtract(DateTime.Now);
            }
            else
            {
                ts = dtAuto.AddDays(1).Subtract(DateTime.Now);
            }

            autorunTimer.Interval = ts.TotalMilliseconds; // Max value of Interval is 2 to the power of 31(Int32)
            autorunTimer.Start();
        }

        private void txtAcct_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;
            string errMsg = "";

            if (txt.Text.Length != 9)
            {
                errMsg = "The length of the string is not 10.";
                e.Cancel = true;
            }
            else if (!Int64.TryParse(txt.Text, out var rlt))
            {
                errMsg = "Please enter digits";
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }

            errAcct.SetError(txtAcct, errMsg);
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Global.MAIN_URL);
            stop = false;
            if(autorunTimer.Enabled)
            {
                autorunTimer.Stop();
            }
        }

        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (cmb.SelectedIndex == -1)
            {
                e.Cancel = true;
                errCmb.SetError(cmb, "Please select an option.");
            }
            else
            {
                e.Cancel = false;
                errCmb.SetError(cmb, "");
            }
        }

        /// <summary>
        /// Minimized the window instead of closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Tag = string.Empty;
                notifyIcon1.ShowBalloonTip(3000, this.Text,
                     "程式並未結束，欲結束請在圖示上按右鍵，選取結束選項",
                     ToolTipIcon.Info);
                this.Hide();
            }
            // Save StudentID and password to ApplicationSettings
            if (Properties.Settings.Default.RmbStudentID)
                Properties.Settings.Default.StudentIDSetting = txtAcct.Text;
            if (Properties.Settings.Default.RmbPassword)
                Properties.Settings.Default.PasswordSetting = txtPwd.Text;
            Properties.Settings.Default.Save();

            if(Properties.Settings.Default.AutoStartup)
                InitStartupCountdown();
        }

        private void InitStartupCountdown()
        {
            startupTimer.AutoReset = false;
            startupTimer.Elapsed += new System.Timers.ElapsedEventHandler(ShowForm);
            startupTimer.SynchronizingObject = this; // Back to the main thread when time is up

            DateTime dtStart = DateTime.Parse(Properties.Settings.Default.StartupTime);
            TimeSpan ts;
            if (dtStart.CompareTo(DateTime.Now) > 0)
            {
                ts = dtStart.Subtract(DateTime.Now);
            }
            else
            {
                ts = dtStart.AddDays(1).Subtract(DateTime.Now);
            }

            startupTimer.Interval = ts.TotalMilliseconds; // less than 24 days
            startupTimer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void ShowForm()
        {
            if (this.WindowState == FormWindowState.Minimized) // if this window is minimized
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            // Activate the form.
            this.Activate();
            //this.Focus();
        }

        /// <summary>
        /// Used for  thread to show this form when time is up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowForm(object sender, System.Timers.ElapsedEventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000, "時間到", "即將開啟程式", ToolTipIcon.Info);
            if (WindowState == FormWindowState.Minimized) // if this window is minimized
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
            this.Activate();
            //this.Focus();
            startupTimer.Stop();
        }

        /// <summary>
        /// Context menu strip's End the window
        /// Stop timers
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            startupTimer.Stop();
            autorunTimer.Stop();
            Application.Exit();
        }

        /// <summary>
        /// Open setting form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings();
            if(form.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Reload();
                if(Properties.Settings.Default.AutoStartup != isAutostartup)
                {
                    isAutostartup = !isAutostartup;
                    if(!isAutostartup)
                    {
                        startupTimer.Stop();
                    }
                }
                if(Properties.Settings.Default.AutoBook != isAutobook)
                {
                    isAutobook = !isAutobook;
                    if(!isAutobook)
                    {
                        autorunTimer.Stop();
                    }
                }
                //MessageBox.Show("Saved");
            }
        }

        private void notifyIcon1_Clicked(object sender, EventArgs e)
        {
            ShowForm();
        }
    }

    public class ComboItem
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }

    public class WbsControl
    {
        public string reason = "Reason";
        private int count = 0;

        public WebBrowser Wbs { get; set; }

        public string Acct { get; set; }
        public string Pwd { get; set; }
        public string SFValue { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; } // Duration

        public WbsControl(WebBrowser wbs)
        {
            Wbs = wbs;
        }

        public HtmlElement getById(string id)
        {
            return Wbs.Document.GetElementById(id);
        }

        public bool isLogin()
        {
            if (getById("MainContent_Panel5") == null)
                return false;
            return true;
        }

        public bool isOnReqPage()
        {
            if (getById("MainContent_AppPlaceTB") == null)
                return false;
            return true;
        }

        public void Login()
        {
            getById("MainContent_TextBox1").InnerText = Acct;
            getById("MainContent_TextBox2").InnerText = Pwd;
            getById("MainContent_Button1").InvokeMember("click");
        }

        public void BookField()
        {
            getById("MainContent_DropDownList1").SetAttribute("value", SFValue);
            Wbs.Document.InvokeScript("AppBtnC", new object[] { Date + "::" + Hour });
        }

        public void FillReason()
        {
            getById("MainContent_ReasonTextBox" + ++count).InnerText = reason;
            getById("MainContent_Button4").InvokeMember("click");
        }
    }
}
