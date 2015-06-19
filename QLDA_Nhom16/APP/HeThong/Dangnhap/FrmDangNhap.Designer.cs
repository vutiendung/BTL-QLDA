namespace WindowsFormsApplication2
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this._txtusername = new System.Windows.Forms.TextBox();
            this._txtpass = new System.Windows.Forms.TextBox();
            this._btnLogin = new System.Windows.Forms.Button();
            this._btnExit = new System.Windows.Forms.Button();
            this._checkRemember = new System.Windows.Forms.CheckBox();
            this._linkQuenMK = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtusername
            // 
            this._txtusername.Location = new System.Drawing.Point(264, 66);
            this._txtusername.Margin = new System.Windows.Forms.Padding(4);
            this._txtusername.Name = "_txtusername";
            this._txtusername.Size = new System.Drawing.Size(249, 23);
            this._txtusername.TabIndex = 0;
            // 
            // _txtpass
            // 
            this._txtpass.Location = new System.Drawing.Point(264, 115);
            this._txtpass.Margin = new System.Windows.Forms.Padding(4);
            this._txtpass.Name = "_txtpass";
            this._txtpass.PasswordChar = '*';
            this._txtpass.Size = new System.Drawing.Size(249, 23);
            this._txtpass.TabIndex = 1;
            // 
            // _btnLogin
            // 
            this._btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnLogin.Location = new System.Drawing.Point(212, 186);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(120, 30);
            this._btnLogin.TabIndex = 3;
            this._btnLogin.Text = "Đăng nhập";
            this._btnLogin.UseVisualStyleBackColor = true;
            this._btnLogin.Click += new System.EventHandler(this._btnLogin_Click);
            // 
            // _btnExit
            // 
            this._btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExit.Location = new System.Drawing.Point(368, 186);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(120, 30);
            this._btnExit.TabIndex = 6;
            this._btnExit.Text = "Thoát";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this._btnExit_Click);
            // 
            // _checkRemember
            // 
            this._checkRemember.AutoSize = true;
            this._checkRemember.Checked = true;
            this._checkRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkRemember.Location = new System.Drawing.Point(198, 145);
            this._checkRemember.Name = "_checkRemember";
            this._checkRemember.Size = new System.Drawing.Size(149, 21);
            this._checkRemember.TabIndex = 7;
            this._checkRemember.Text = "Ghi nhớ đăng nhập";
            this._checkRemember.UseVisualStyleBackColor = true;
            // 
            // _linkQuenMK
            // 
            this._linkQuenMK.AutoSize = true;
            this._linkQuenMK.Location = new System.Drawing.Point(365, 149);
            this._linkQuenMK.Name = "_linkQuenMK";
            this._linkQuenMK.Size = new System.Drawing.Size(105, 17);
            this._linkQuenMK.TabIndex = 8;
            this._linkQuenMK.TabStop = true;
            this._linkQuenMK.Text = "Quên mật khẩu";
            this._linkQuenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._linkQuenMK_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources._203391755;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // FrmDangNhap
            // 
            this.AcceptButton = this._btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(526, 228);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._linkQuenMK);
            this.Controls.Add(this._checkRemember);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._btnLogin);
            this.Controls.Add(this._txtpass);
            this.Controls.Add(this._txtusername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập tài khoản";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtusername;
        private System.Windows.Forms.TextBox _txtpass;
        private System.Windows.Forms.Button _btnLogin;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.CheckBox _checkRemember;
        private System.Windows.Forms.LinkLabel _linkQuenMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}