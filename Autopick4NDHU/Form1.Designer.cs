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
            this.btnNav = new System.Windows.Forms.Button();
            this.lblAcct = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lblHour = new System.Windows.Forms.Label();
            this.btnToggleWeb = new System.Windows.Forms.Button();
            this.lblFields = new System.Windows.Forms.Label();
            this.txtAcct = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.cmbEndHour = new System.Windows.Forms.ComboBox();
            this.cmbSportFields = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtShowInfo = new System.Windows.Forms.TextBox();
            this.errAct = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errAct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNav
            // 
            this.btnNav.Location = new System.Drawing.Point(112, 380);
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
            this.lblAcct.Location = new System.Drawing.Point(12, 20);
            this.lblAcct.Name = "lblAcct";
            this.lblAcct.Size = new System.Drawing.Size(87, 12);
            this.lblAcct.TabIndex = 1;
            this.lblAcct.Text = "學號(Student ID)";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(12, 60);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(80, 12);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "密碼(Password)";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 100);
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
            this.lblHour.Location = new System.Drawing.Point(12, 144);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(61, 12);
            this.lblHour.TabIndex = 5;
            this.lblHour.Text = "時間(Hour)";
            // 
            // btnToggleWeb
            // 
            this.btnToggleWeb.Location = new System.Drawing.Point(234, 380);
            this.btnToggleWeb.Name = "btnToggleWeb";
            this.btnToggleWeb.Size = new System.Drawing.Size(75, 23);
            this.btnToggleWeb.TabIndex = 6;
            this.btnToggleWeb.Text = "Toggle";
            this.btnToggleWeb.UseVisualStyleBackColor = true;
            this.btnToggleWeb.Click += new System.EventHandler(this.btnToggleWeb_Click);
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Location = new System.Drawing.Point(12, 208);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(64, 12);
            this.lblFields.TabIndex = 7;
            this.lblFields.Text = "場地(Fields)";
            // 
            // txtAcct
            // 
            this.txtAcct.Location = new System.Drawing.Point(105, 17);
            this.txtAcct.Name = "txtAcct";
            this.txtAcct.Size = new System.Drawing.Size(100, 22);
            this.txtAcct.TabIndex = 0;
            this.txtAcct.Text = "410421209";
            this.txtAcct.Validating += new System.ComponentModel.CancelEventHandler(this.txtAcct_Validating);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(105, 57);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 22);
            this.txtPwd.TabIndex = 8;
            this.txtPwd.Text = "A125574306";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(105, 93);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(123, 22);
            this.dtpDate.TabIndex = 9;
            // 
            // cmbStartHour
            // 
            this.cmbStartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartHour.FormattingEnabled = true;
            this.cmbStartHour.Location = new System.Drawing.Point(14, 172);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(62, 20);
            this.cmbStartHour.TabIndex = 10;
            this.cmbStartHour.SelectedIndexChanged += new System.EventHandler(this.cmbStartHour_SelectedIndexChanged);
            // 
            // cmbEndHour
            // 
            this.cmbEndHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndHour.FormattingEnabled = true;
            this.cmbEndHour.Location = new System.Drawing.Point(82, 172);
            this.cmbEndHour.Name = "cmbEndHour";
            this.cmbEndHour.Size = new System.Drawing.Size(62, 20);
            this.cmbEndHour.TabIndex = 11;
            // 
            // cmbSportFields
            // 
            this.cmbSportFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSportFields.FormattingEnabled = true;
            this.cmbSportFields.Location = new System.Drawing.Point(14, 238);
            this.cmbSportFields.Name = "cmbSportFields";
            this.cmbSportFields.Size = new System.Drawing.Size(121, 20);
            this.cmbSportFields.TabIndex = 12;
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
            this.txtShowInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShowInfo.Size = new System.Drawing.Size(214, 64);
            this.txtShowInfo.TabIndex = 14;
            // 
            // errAct
            // 
            this.errAct.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtShowInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbSportFields);
            this.Controls.Add(this.cmbEndHour);
            this.Controls.Add(this.cmbStartHour);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtAcct);
            this.Controls.Add(this.lblFields);
            this.Controls.Add(this.btnToggleWeb);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblAcct);
            this.Controls.Add(this.btnNav);
            this.Name = "Form1";
            this.Text = "Auto Pick";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errAct)).EndInit();
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
        private System.Windows.Forms.Button btnToggleWeb;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.TextBox txtAcct;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbStartHour;
        private System.Windows.Forms.ComboBox cmbEndHour;
        private System.Windows.Forms.ComboBox cmbSportFields;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtShowInfo;
        private System.Windows.Forms.ErrorProvider errAct;
    }
}

