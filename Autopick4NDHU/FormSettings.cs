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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;

            chkRmbAcct.Checked = Properties.Settings.Default.RmbStudentID;
            chkRmbPwd.Checked = Properties.Settings.Default.RmbPassword;

            dtpStartup.Format = DateTimePickerFormat.Time;
            dtpStartup.ShowUpDown = true;
            dtpStartup.MinDate = DateTime.Parse("23:00:00");
            dtpStartup.MaxDate = DateTime.Parse("23:59:59");
            dtpStartup.Value = DateTime.Parse(Properties.Settings.Default.StartupTime);

            dtpLogin.Format = DateTimePickerFormat.Time;
            dtpLogin.ShowUpDown = true;
            dtpLogin.MinDate = DateTime.Parse("23:57:00");
            dtpLogin.MaxDate = DateTime.Parse("23:59:59");
            dtpLogin.Value = DateTime.Parse(Properties.Settings.Default.LoginTime);

            if(Properties.Settings.Default.AutoStartup)
            {
                rdoSetStartup.Checked = true;
            }
            else
            {
                rdoNoStartup.Checked = true;
                dtpStartup.Enabled = false;
            }

            if (Properties.Settings.Default.AutoBook)
            {
                rdoAutoRun.Checked = true;
            }
            else
            {
                rdoManual.Checked = true;
                dtpLogin.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Input incorrectly");
                return;
            }

            Properties.Settings.Default.RmbStudentID = chkRmbAcct.Checked;
            Properties.Settings.Default.RmbPassword = chkRmbPwd.Checked;
            Properties.Settings.Default.StartupTime = dtpStartup.Value.TimeOfDay.ToString();
            Properties.Settings.Default.LoginTime = dtpLogin.Value.TimeOfDay.ToString();
            Properties.Settings.Default.AutoStartup = rdoSetStartup.Checked;
            Properties.Settings.Default.AutoBook = rdoAutoRun.Checked;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rdoSetStartup_CheckedChanged(object sender, EventArgs e)
        {
            dtpStartup.Enabled = (sender as RadioButton).Checked ? true : false;
        }

        private void rdoAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            dtpLogin.Enabled = (sender as RadioButton).Checked ? true : false;
        }

        private void dtpStartup_Validating(object sender, CancelEventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;

            if(dtp.Value > dtpLogin.Value)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtp, "Startup time must be earlier than auto run time");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtp, "");
            }
        }
    }
}
