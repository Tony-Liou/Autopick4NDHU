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
            this.chkRmbAcct = new System.Windows.Forms.CheckBox();
            this.chkRmbPwd = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartup = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpLogin = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRmbAcct
            // 
            this.chkRmbAcct.AutoSize = true;
            this.chkRmbAcct.Checked = true;
            this.chkRmbAcct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRmbAcct.Location = new System.Drawing.Point(6, 6);
            this.chkRmbAcct.Name = "chkRmbAcct";
            this.chkRmbAcct.Size = new System.Drawing.Size(126, 16);
            this.chkRmbAcct.TabIndex = 0;
            this.chkRmbAcct.Text = "Remember student ID";
            this.chkRmbAcct.UseVisualStyleBackColor = true;
            // 
            // chkRmbPwd
            // 
            this.chkRmbPwd.AutoSize = true;
            this.chkRmbPwd.Checked = true;
            this.chkRmbPwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRmbPwd.Location = new System.Drawing.Point(6, 28);
            this.chkRmbPwd.Name = "chkRmbPwd";
            this.chkRmbPwd.Size = new System.Drawing.Size(121, 16);
            this.chkRmbPwd.TabIndex = 1;
            this.chkRmbPwd.Text = "Remember password";
            this.chkRmbPwd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(194, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
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
            this.tabControl1.Size = new System.Drawing.Size(342, 235);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkRmbAcct);
            this.tabPage1.Controls.Add(this.chkRmbPwd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(334, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "儲存資料";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpLogin);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dtpStartup);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(334, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "執行設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "何時啟動此程式";
            // 
            // dtpStartup
            // 
            this.dtpStartup.Location = new System.Drawing.Point(128, 8);
            this.dtpStartup.Name = "dtpStartup";
            this.dtpStartup.Size = new System.Drawing.Size(125, 22);
            this.dtpStartup.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "何時登入該網站";
            // 
            // dtpLogin
            // 
            this.dtpLogin.Location = new System.Drawing.Point(128, 41);
            this.dtpLogin.Name = "dtpLogin";
            this.dtpLogin.Size = new System.Drawing.Size(125, 22);
            this.dtpLogin.TabIndex = 3;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 287);
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
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpLogin;
        private System.Windows.Forms.Label label2;
    }
}