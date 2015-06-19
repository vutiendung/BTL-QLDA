namespace WindowsFormsApplication2.APP.Nhân_viên
{
    partial class PopupNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupNhanvien));
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this._radNam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this._radNu = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this._txtDiachi = new System.Windows.Forms.TextBox();
            this._txtDienthoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDacBiet2 = new System.Windows.Forms.Label();
            this.txtMucLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtMucLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(145, 38);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(137, 23);
            this.txtMaNhanVien.TabIndex = 0;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(145, 79);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(373, 23);
            this.txtTenNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::WindowsFormsApplication2.Properties.Resources.Load;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(301, 315);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuuonClick);
            // 
            // button2
            // 
            this.button2.Image = global::WindowsFormsApplication2.Properties.Resources.Exit;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(418, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sinh";
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.CustomFormat = "MM/dd/yyyy";
            this.dateNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaysinh.Location = new System.Drawing.Point(145, 120);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(120, 23);
            this.dateNgaysinh.TabIndex = 7;
            // 
            // _radNam
            // 
            this._radNam.AutoSize = true;
            this._radNam.Location = new System.Drawing.Point(377, 120);
            this._radNam.Name = "_radNam";
            this._radNam.Size = new System.Drawing.Size(55, 21);
            this._radNam.TabIndex = 8;
            this._radNam.TabStop = true;
            this._radNam.Text = "Nam";
            this._radNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính";
            // 
            // _radNu
            // 
            this._radNu.AutoSize = true;
            this._radNu.Location = new System.Drawing.Point(456, 120);
            this._radNu.Name = "_radNu";
            this._radNu.Size = new System.Drawing.Size(44, 21);
            this._radNu.TabIndex = 10;
            this._radNu.TabStop = true;
            this._radNu.Text = "Nữ";
            this._radNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Địa chỉ";
            // 
            // _txtDiachi
            // 
            this._txtDiachi.Location = new System.Drawing.Point(145, 156);
            this._txtDiachi.Name = "_txtDiachi";
            this._txtDiachi.Size = new System.Drawing.Size(373, 23);
            this._txtDiachi.TabIndex = 13;
            // 
            // _txtDienthoai
            // 
            this._txtDienthoai.Location = new System.Drawing.Point(145, 198);
            this._txtDienthoai.Name = "_txtDienthoai";
            this._txtDienthoai.Size = new System.Drawing.Size(137, 23);
            this._txtDienthoai.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Chức vụ";
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(379, 36);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(139, 25);
            this.cbChucVu.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mức lương";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(24, 245);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(42, 17);
            this.lb.TabIndex = 22;
            this.lb.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(145, 242);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(373, 23);
            this.txtEmail.TabIndex = 21;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(24, 286);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(66, 17);
            this.lblMatKhau.TabIndex = 26;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(145, 280);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(372, 23);
            this.txtMatKhau.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(524, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "*";
            // 
            // lblDacBiet2
            // 
            this.lblDacBiet2.AutoSize = true;
            this.lblDacBiet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDacBiet2.ForeColor = System.Drawing.Color.Red;
            this.lblDacBiet2.Location = new System.Drawing.Point(524, 283);
            this.lblDacBiet2.Name = "lblDacBiet2";
            this.lblDacBiet2.Size = new System.Drawing.Size(16, 20);
            this.lblDacBiet2.TabIndex = 29;
            this.lblDacBiet2.Text = "*";
            // 
            // txtMucLuong
            // 
            this.txtMucLuong.Location = new System.Drawing.Point(378, 202);
            this.txtMucLuong.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txtMucLuong.Name = "txtMucLuong";
            this.txtMucLuong.Size = new System.Drawing.Size(139, 23);
            this.txtMucLuong.TabIndex = 30;
            // 
            // PopupNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 357);
            this.Controls.Add(this.txtMucLuong);
            this.Controls.Add(this.lblDacBiet2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._txtDienthoai);
            this.Controls.Add(this._txtDiachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._radNu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._radNam);
            this.Controls.Add(this.dateNgaysinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PopupNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.PopupNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMucLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.RadioButton _radNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton _radNu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtDiachi;
        private System.Windows.Forms.TextBox _txtDienthoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDacBiet2;
        private System.Windows.Forms.NumericUpDown txtMucLuong;
    }
}