using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private bool isBooked;
        private bool isFinished;

        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            // DateTimePicker
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy/MM/dd";
            dtpDate.MinDate = DateTime.Today.AddDays(7);
            dtpDate.MaxDate = dtpDate.MinDate.AddDays(7);

            // Start hour combobox
            for(int i = 6; i < 23; ++i)
            {
                cmbStartHour.Items.Add(new ComboItem { Text = i.ToString(), Value = i.ToString() });
            }
            cmbStartHour.DisplayMember = "Text";
            cmbStartHour.ValueMember = "Value";
            cmbStartHour.DropDownStyle = ComboBoxStyle.DropDownList;

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

            wbsControl = new WbsControl(webBrowser1);
            webBrowser1.Visible = false;

            isBooked = isFinished = false;
        }

        private ComboItem SFSplit(string str)
        {
            return new ComboItem { Value = str.Substring(0,5), Text = str.Substring(5, str.Length - 5)};
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if(e.Url.ToString() == Global.MAIN_URL)
            {
                if(wbsControl.isLogin())
                {
                    if (isFinished)
                        return;
                    if(wbsControl.isOnReqPage())
                    {
                        if(isBooked)
                        {
                            wbsControl.FillReason();
                            isFinished = true;
                        }
                        else
                        {
                            wbsControl.BookField();
                            isBooked = true;
                        }
                    }
                    else
                    {
                        wbsControl.getById("MainContent_Button2").InvokeMember("click");
                    }
                }
                else
                {
                    webBrowser1.Navigate(Global.LOGIN_URL);
                }
            }
            else if(e.Url.ToString() == Global.LOGIN_URL)
            {
                wbsControl.Login();
            }
        }

        private void btnToggleWeb_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = (webBrowser1.Visible?false:true);
        }

        private void cmbStartHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox sh = sender as ComboBox;
            cmbEndHour.Items.Clear();

            int n = Int32.Parse(sh.Text);
            if (n < 23)
            {
                cmbEndHour.Items.Add(new ComboItem { Text = (n + 1).ToString(), Value = (n+1).ToString()});
                
            }
            if (n < 22)
            {
                cmbEndHour.Items.Add(new ComboItem { Text = (n + 2).ToString(), Value = (n + 2).ToString() });
            }
            cmbEndHour.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            wbsControl.Acct = txtAcct.Text;
            wbsControl.Pwd = txtPwd.Text;
            wbsControl.SFValue = ((ComboItem)cmbSportFields.SelectedItem).Value;
            wbsControl.Date = dtpDate.Text;
            wbsControl.Hour = cmbStartHour.Text + "~" + cmbEndHour.Text;

            txtShowInfo.Text = "ID: " + txtAcct.Text +
                "\r\nPassword: " + txtPwd.Text +
                "\r\nSport fields: " + cmbSportFields.Text + cmbSportFields.SelectedItem.ToString() +
                "\r\nDate: " + dtpDate.Text +
                "\r\nHour: " + cmbStartHour.Text + "~" + cmbEndHour.Text;
        }

        private void txtAcct_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if(txt.Text.Length != 9)
            {
                errAct.SetError(txtAcct, "The length of the string is not 10.");
            }
            if(!Int64.TryParse(txt.Text, out var rlt))
            {
                errAct.SetError(txtAcct, "Please enter digits");
            }
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Global.MAIN_URL);
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

        WebBrowser Wbs { get; set; }

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
            getById("MainContent_TextBox2").SetAttribute("value", Pwd);
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
