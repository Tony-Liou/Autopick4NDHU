﻿using System;
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
        private bool isSaved;
        private bool isBooked;
        private bool isFinished;

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

            txtAcct.Text = Properties.Settings.Default.StudentIDSetting;
            txtPwd.Text = Properties.Settings.Default.PasswordSetting;

            // DateTimePicker
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy/MM/dd";
            dtpDate.MinDate = DateTime.Today.AddDays(6);
            dtpDate.MaxDate = dtpDate.MinDate.AddDays(6);

            // Start hour combobox
            for(int i = 6; i < 23; ++i)
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
            for(int i = 0; i < sfVal.Length; ++i)
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
            tip.InitialDelay = 1000;
            tip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            tip.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            tip.SetToolTip(cmbStartHour, "Start hour");
            tip.SetToolTip(cmbEndHour, "End hour");
            tip.SetToolTip(txtShowInfo, "Show the state");
            tip.SetToolTip(btnSave, "Save the user input");
            tip.SetToolTip(btnNav, "Go to the target website and start processing");
            tip.SetToolTip(btnStop, "Stop the process of webbrowser");

            stop = isSaved = isBooked = isFinished = false;
        }

        private ComboItem SFSplit(string str)
        {
            return new ComboItem { Value = str.Substring(0,5), Text = str.Substring(5, str.Length - 5)};
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!isSaved || stop)
            {
                txtShowInfo.Text = "Negative";
                return;
            }
                
            if(e.Url.ToString() == Global.MAIN_URL)
            {
                if(wbsControl.isLogin())
                {
                    if (isFinished) // Entire process is done
                    {
                        txtShowInfo.Text = "Booking is done perfectly!!!";
                        return;
                    }
                        
                    if(wbsControl.isOnReqPage())
                    {
                        if(isBooked)
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
            else if(e.Url.ToString() == Global.LOGIN_URL)
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
            if(!this.ValidateChildren())
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
            else if(!Int64.TryParse(txt.Text, out var rlt))
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save StudentID and password to ApplicationSettings
            Properties.Settings.Default.StudentIDSetting = txtAcct.Text;
            Properties.Settings.Default.PasswordSetting = txtPwd.Text;
            Properties.Settings.Default.Save();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = true;
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
            if(getById("MainContent_Panel5") == null)
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
            getById("MainContent_TextBox1").InnerText = Acct;//SetAttribute("value", Acct);
            getById("MainContent_TextBox2").InnerText = Pwd;
            getById("MainContent_Button1").InvokeMember("click");
        }

        public void BookField()
        {
            getById("MainContent_DropDownList1").SetAttribute("value", SFValue);
            Wbs.Document.InvokeScript("AppBtnC", new object[] { Date + "::" + Hour});
        }

        public void FillReason()
        {
            getById("MainContent_ReasonTextBox" + ++count).InnerText = reason;
            getById("MainContent_Button4").InvokeMember("click");
        }
    }
}
