namespace Autopick4NDHU
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkRmbAcct = new System.Windows.Forms.CheckBox();
            this.chkRmbPwd = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpBookSettings = new System.Windows.Forms.GroupBox();
            this.rdoAutoRun = new System.Windows.Forms.RadioButton();
            this.rdoManual = new System.Windows.Forms.RadioButton();
            this.dtpLogin = new System.Windows.Forms.DateTimePicker();
            this.grpStartupSettings = new System.Windows.Forms.GroupBox();
            this.rdoSetStartup = new System.Windows.Forms.RadioButton();
            this.rdoNoStartup = new System.Windows.Forms.RadioButton();
            this.dtpStartup = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpBookSettings.SuspendLayout();
            this.grpStartupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkRmbAcct
            // 
            this.chkRmbAcct.AutoSize = true;
            this.chkRmbAcct.Checked = true;
            this.chkRmbAcct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRmbAcct.Location = new System.Drawing.Point(6, 6);
            this.chkRmbAcct.Name = "chkRmbAcct";
            this.chkRmbAcct.Size = new System.Drawing.Size(72, 16);
            this.chkRmbAcct.TabIndex = 0;
            this.chkRmbAcct.Text = "記住學號";
            this.chkRmbAcct.UseVisualStyleBackColor = true;
            // 
            // chkRmbPwd
            // 
            this.chkRmbPwd.AutoSize = true;
            this.chkRmbPwd.Checked = true;
            this.chkRmbPwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRmbPwd.Location = new System.Drawing.Point(6, 28);
            this.chkRmbPwd.Name = "chkRmbPwd";
            this.chkRmbPwd.Size = new System.Drawing.Size(72, 16);
            this.chkRmbPwd.TabIndex = 1;
            this.chkRmbPwd.Text = "記住密碼";
            this.chkRmbPwd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(247, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(166, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "確定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(314, 250);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkRmbAcct);
            this.tabPage1.Controls.Add(this.chkRmbPwd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(306, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "儲存資料";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpBookSettings);
            this.tabPage2.Controls.Add(this.grpStartupSettings);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(306, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "執行設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpBookSettings
            // 
            this.grpBookSettings.Controls.Add(this.rdoAutoRun);
            this.grpBookSettings.Controls.Add(this.rdoManual);
            this.grpBookSettings.Controls.Add(this.dtpLogin);
            this.grpBookSettings.Location = new System.Drawing.Point(6, 99);
            this.grpBookSettings.Name = "grpBookSettings";
            this.grpBookSettings.Size = new System.Drawing.Size(271, 81);
            this.grpBookSettings.TabIndex = 5;
            this.grpBookSettings.TabStop = false;
            this.grpBookSettings.Text = "自動借場";
            // 
            // rdoAutoRun
            // 
            this.rdoAutoRun.AutoSize = true;
            this.rdoAutoRun.Checked = true;
            this.rdoAutoRun.Location = new System.Drawing.Point(6, 43);
            this.rdoAutoRun.Name = "rdoAutoRun";
            this.rdoAutoRun.Size = new System.Drawing.Size(95, 16);
            this.rdoAutoRun.TabIndex = 4;
            this.rdoAutoRun.TabStop = true;
            this.rdoAutoRun.Text = "自動執行時間";
            this.rdoAutoRun.UseVisualStyleBackColor = true;
            this.rdoAutoRun.CheckedChanged += new System.EventHandler(this.rdoAutoRun_CheckedChanged);
            // 
            // rdoManual
            // 
            this.rdoManual.AutoSize = true;
            this.rdoManual.Location = new System.Drawing.Point(6, 21);
            this.rdoManual.Name = "rdoManual";
            this.rdoManual.Size = new System.Drawing.Size(71, 16);
            this.rdoManual.TabIndex = 3;
            this.rdoManual.TabStop = true;
            this.rdoManual.Text = "手動操作";
            this.rdoManual.UseVisualStyleBackColor = true;
            // 
            // dtpLogin
            // 
            this.dtpLogin.Location = new System.Drawing.Point(107, 38);
            this.dtpLogin.Name = "dtpLogin";
            this.dtpLogin.Size = new System.Drawing.Size(125, 22);
            this.dtpLogin.TabIndex = 4;
            // 
            // grpStartupSettings
            // 
            this.grpStartupSettings.Controls.Add(this.rdoSetStartup);
            this.grpStartupSettings.Controls.Add(this.rdoNoStartup);
            this.grpStartupSettings.Controls.Add(this.dtpStartup);
            this.grpStartupSettings.Location = new System.Drawing.Point(6, 6);
            this.grpStartupSettings.Name = "grpStartupSettings";
            this.grpStartupSettings.Size = new System.Drawing.Size(271, 87);
            this.grpStartupSettings.TabIndex = 4;
            this.grpStartupSettings.TabStop = false;
            this.grpStartupSettings.Text = "自動開啟程式";
            // 
            // rdoSetStartup
            // 
            this.rdoSetStartup.AutoSize = true;
            this.rdoSetStartup.Checked = true;
            this.rdoSetStartup.Location = new System.Drawing.Point(6, 43);
            this.rdoSetStartup.Name = "rdoSetStartup";
            this.rdoSetStartup.Size = new System.Drawing.Size(95, 16);
            this.rdoSetStartup.TabIndex = 2;
            this.rdoSetStartup.TabStop = true;
            this.rdoSetStartup.Text = "自動開啟時間";
            this.rdoSetStartup.UseVisualStyleBackColor = true;
            this.rdoSetStartup.CheckedChanged += new System.EventHandler(this.rdoSetStartup_CheckedChanged);
            // 
            // rdoNoStartup
            // 
            this.rdoNoStartup.AutoSize = true;
            this.rdoNoStartup.Location = new System.Drawing.Point(6, 21);
            this.rdoNoStartup.Name = "rdoNoStartup";
            this.rdoNoStartup.Size = new System.Drawing.Size(95, 16);
            this.rdoNoStartup.TabIndex = 1;
            this.rdoNoStartup.TabStop = true;
            this.rdoNoStartup.Text = "不要自動開啟";
            this.rdoNoStartup.UseVisualStyleBackColor = true;
            // 
            // dtpStartup
            // 
            this.dtpStartup.Location = new System.Drawing.Point(107, 38);
            this.dtpStartup.Name = "dtpStartup";
            this.dtpStartup.Size = new System.Drawing.Size(125, 22);
            this.dtpStartup.TabIndex = 2;
            this.dtpStartup.Validating += new System.ComponentModel.CancelEventHandler(this.dtpStartup_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 316);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpBookSettings.ResumeLayout(false);
            this.grpBookSettings.PerformLayout();
            this.grpStartupSettings.ResumeLayout(false);
            this.grpStartupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRmbAcct;
        private System.Windows.Forms.CheckBox chkRmbPwd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpStartup;
        private System.Windows.Forms.DateTimePicker dtpLogin;
        private System.Windows.Forms.GroupBox grpStartupSettings;
        private System.Windows.Forms.RadioButton rdoNoStartup;
        private System.Windows.Forms.GroupBox grpBookSettings;
        private System.Windows.Forms.RadioButton rdoSetStartup;
        private System.Windows.Forms.RadioButton rdoAutoRun;
        private System.Windows.Forms.RadioButton rdoManual;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}