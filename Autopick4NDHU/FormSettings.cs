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
            chkRmbAcct.Checked = Properties.Settings.Default.RmbStudentID;
            chkRmbPwd.Checked = Properties.Settings.Default.RmbPassword;

            dtpStartup.Format = DateTimePickerFormat.Time;
            dtpStartup.ShowUpDown = true;
            dtpStartup.MinDate = DateTime.Parse("23:50:00");
            dtpStartup.MaxDate = DateTime.Parse("23:59:59");
            dtpStartup.Value = DateTime.Parse(Properties.Settings.Default.StartupTime);

            dtpLogin.Format = DateTimePickerFormat.Time;
            dtpLogin.ShowUpDown = true;
            dtpLogin.MinDate = DateTime.Parse("23:57:00");
            dtpLogin.MaxDate = DateTime.Parse("23:59:59");
            dtpLogin.Value = DateTime.Parse(Properties.Settings.Default.LoginTime);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RmbStudentID = chkRmbAcct.Checked;
            Properties.Settings.Default.RmbPassword = chkRmbPwd.Checked;
            Properties.Settings.Default.StartupTime = dtpStartup.Value.TimeOfDay.ToString();
            Properties.Settings.Default.LoginTime = dtpLogin.Value.TimeOfDay.ToString();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
