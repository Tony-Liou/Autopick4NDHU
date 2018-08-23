namespace Autopick4NDHU
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNav = new System.Windows.Forms.Button();
            this.lblAcct = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lblHour = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblFields = new System.Windows.Forms.Label();
            this.txtAcct = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.cmbEndHour = new System.Windows.Forms.ComboBox();
            this.cmbSportFields = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtShowInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errAcct = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCmb = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errAcct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCmb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNav
            // 
            this.btnNav.Location = new System.Drawing.Point(93, 380);
            this.btnNav.Name = "btnNav";
            this.btnNav.Size = new System.Drawing.Size(75, 23);
            this.btnNav.TabIndex = 0;
            this.btnNav.Text = "Go";
            this.btnNav.UseVisualStyleBackColor = true;
            this.btnNav.Click += new System.EventHandler(this.btnNav_Click);
            // 
            // lblAcct
            // 
            this.lblAcct.AutoSize = true;
            this.lblAcct.Location = new System.Drawing.Point(6, 18);
            this.lblAcct.Name = "lblAcct";
            this.lblAcct.Size = new System.Drawing.Size(87, 12);
            this.lblAcct.TabIndex = 1;
            this.lblAcct.Text = "學號(Student ID)";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(6, 55);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(80, 12);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "密碼(Password)";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 12);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "日期(Date)";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(382, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(406, 426);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(6, 58);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(61, 12);
            this.lblHour.TabIndex = 5;
            this.lblHour.Text = "時間(Hour)";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(174, 380);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Location = new System.Drawing.Point(6, 92);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(64, 12);
            this.lblFields.TabIndex = 7;
            this.lblFields.Text = "場地(Fields)";
            // 
            // txtAcct
            // 
            this.txtAcct.Location = new System.Drawing.Point(99, 15);
            this.txtAcct.Name = "txtAcct";
            this.txtAcct.Size = new System.Drawing.Size(100, 22);
            this.txtAcct.TabIndex = 0;
            this.txtAcct.Validating += new System.ComponentModel.CancelEventHandler(this.txtAcct_Validating);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(99, 52);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 22);
            this.txtPwd.TabIndex = 8;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(76, 16);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(123, 22);
            this.dtpDate.TabIndex = 9;
            // 
            // cmbStartHour
            // 
            this.cmbStartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartHour.FormattingEnabled = true;
            this.cmbStartHour.Location = new System.Drawing.Point(76, 55);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(62, 20);
            this.cmbStartHour.TabIndex = 10;
            this.cmbStartHour.SelectedIndexChanged += new System.EventHandler(this.cmbStartHour_SelectedIndexChanged);
            this.cmbStartHour.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // cmbEndHour
            // 
            this.cmbEndHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndHour.FormattingEnabled = true;
            this.cmbEndHour.Location = new System.Drawing.Point(161, 55);
            this.cmbEndHour.Name = "cmbEndHour";
            this.cmbEndHour.Size = new System.Drawing.Size(62, 20);
            this.cmbEndHour.TabIndex = 11;
            // 
            // cmbSportFields
            // 
            this.cmbSportFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSportFields.FormattingEnabled = true;
            this.cmbSportFields.Location = new System.Drawing.Point(76, 89);
            this.cmbSportFields.Name = "cmbSportFields";
            this.cmbSportFields.Size = new System.Drawing.Size(100, 20);
            this.cmbSportFields.TabIndex = 12;
            this.cmbSportFields.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtShowInfo
            // 
            this.txtShowInfo.Location = new System.Drawing.Point(14, 290);
            this.txtShowInfo.Multiline = true;
            this.txtShowInfo.Name = "txtShowInfo";
            this.txtShowInfo.ReadOnly = true;
            this.txtShowInfo.Size = new System.Drawing.Size(214, 66);
            this.txtShowInfo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "~";
            // 
            // errAcct
            // 
            this.errAcct.ContainerControl = this;
            // 
            // errCmb
            // 
            this.errCmb.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAcct);
            this.groupBox1.Controls.Add(this.txtAcct);
            this.groupBox1.Controls.Add(this.lblPwd);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 85);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登入資訊";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblHour);
            this.groupBox2.Controls.Add(this.cmbSportFields);
            this.groupBox2.Controls.Add(this.cmbStartHour);
            this.groupBox2.Controls.Add(this.lblFields);
            this.groupBox2.Controls.Add(this.cmbEndHour);
            this.groupBox2.Location = new System.Drawing.Point(14, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 122);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "借用資訊";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtShowInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Auto Pick";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errAcct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCmb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNav;
        private System.Windows.Forms.Label lblAcct;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.TextBox txtAcct;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbStartHour;
        private System.Windows.Forms.ComboBox cmbEndHour;
        private System.Windows.Forms.ComboBox cmbSportFields;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtShowInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errAcct;
        private System.Windows.Forms.ErrorProvider errCmb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

