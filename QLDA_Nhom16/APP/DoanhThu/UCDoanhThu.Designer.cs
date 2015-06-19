namespace WindowsFormsApplication2
{
    partial class UCDoanhThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLocNgay = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radThang = new System.Windows.Forms.RadioButton();
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataDoanhThu = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbLai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTongxuat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbtongnhap = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThu)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 100);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLocNgay);
            this.groupBox2.Controls.Add(this.btnLoc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateFrom);
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.Controls.Add(this.radThang);
            this.groupBox2.Controls.Add(this.radNgay);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiêu chí thống kê";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnLocNgay
            // 
            this.btnLocNgay.Location = new System.Drawing.Point(230, 38);
            this.btnLocNgay.Name = "btnLocNgay";
            this.btnLocNgay.Size = new System.Drawing.Size(100, 30);
            this.btnLocNgay.TabIndex = 12;
            this.btnLocNgay.Text = "Lọc";
            this.btnLocNgay.UseVisualStyleBackColor = true;
            this.btnLocNgay.Click += new System.EventHandler(this.btnLocNgay_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoc.Location = new System.Drawing.Point(884, 33);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(100, 30);
            this.btnLoc.TabIndex = 11;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Danh sách thuốc đã bán";
            // 
            // dateTo
            // 
            this.dateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(691, 37);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(172, 23);
            this.dateTo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đến";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Từ";
            // 
            // dateFrom
            // 
            this.dateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(470, 38);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(152, 23);
            this.dateFrom.TabIndex = 6;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(155, 41);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(55, 21);
            this.radNam.TabIndex = 2;
            this.radNam.TabStop = true;
            this.radNam.Text = "Năm";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Location = new System.Drawing.Point(82, 40);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(67, 21);
            this.radThang.TabIndex = 1;
            this.radThang.TabStop = true;
            this.radThang.Text = "Tháng";
            this.radThang.UseVisualStyleBackColor = true;
            // 
            // radNgay
            // 
            this.radNgay.AutoSize = true;
            this.radNgay.Location = new System.Drawing.Point(17, 40);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(59, 21);
            this.radNgay.TabIndex = 0;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "Ngày";
            this.radNgay.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataDoanhThu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 483);
            this.panel2.TabIndex = 1;
            // 
            // dataDoanhThu
            // 
            this.dataDoanhThu.AllowUserToResizeColumns = false;
            this.dataDoanhThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4,
            this.DONGIABAN,
            this.SOLUONGBAN,
            this.DONGIANHAP});
            this.dataDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.dataDoanhThu.Name = "dataDoanhThu";
            this.dataDoanhThu.ReadOnly = true;
            this.dataDoanhThu.Size = new System.Drawing.Size(990, 483);
            this.dataDoanhThu.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbLai);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbSL);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbTongxuat);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cbtongnhap);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 537);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 46);
            this.panel3.TabIndex = 2;
            // 
            // cbLai
            // 
            this.cbLai.Enabled = false;
            this.cbLai.FormattingEnabled = true;
            this.cbLai.Location = new System.Drawing.Point(644, 14);
            this.cbLai.Name = "cbLai";
            this.cbLai.Size = new System.Drawing.Size(121, 25);
            this.cbLai.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Lãi";
            // 
            // cbSL
            // 
            this.cbSL.Enabled = false;
            this.cbSL.FormattingEnabled = true;
            this.cbSL.Location = new System.Drawing.Point(484, 12);
            this.cbSL.Name = "cbSL";
            this.cbSL.Size = new System.Drawing.Size(121, 25);
            this.cbSL.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "SL";
            // 
            // cbTongxuat
            // 
            this.cbTongxuat.Enabled = false;
            this.cbTongxuat.FormattingEnabled = true;
            this.cbTongxuat.Location = new System.Drawing.Point(314, 15);
            this.cbTongxuat.Name = "cbTongxuat";
            this.cbTongxuat.Size = new System.Drawing.Size(121, 25);
            this.cbTongxuat.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tổng xuất";
            // 
            // cbtongnhap
            // 
            this.cbtongnhap.Enabled = false;
            this.cbtongnhap.FormattingEnabled = true;
            this.cbtongnhap.Location = new System.Drawing.Point(91, 15);
            this.cbtongnhap.Name = "cbtongnhap";
            this.cbtongnhap.Size = new System.Drawing.Size(121, 25);
            this.cbtongnhap.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(797, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(894, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Kết thúc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng nhập";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANHANVIEN";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HOTEN";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NGAYLAP";
            this.Column5.HeaderText = "Ngày lập";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MATHUOC";
            this.Column3.HeaderText = "Mã thuốc";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TENTHUOC";
            this.Column4.HeaderText = "Tên thuốc";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // DONGIABAN
            // 
            this.DONGIABAN.DataPropertyName = "DONGIABAN";
            this.DONGIABAN.HeaderText = "Đơn giá bán";
            this.DONGIABAN.Name = "DONGIABAN";
            this.DONGIABAN.ReadOnly = true;
            this.DONGIABAN.Width = 250;
            // 
            // SOLUONGBAN
            // 
            this.SOLUONGBAN.DataPropertyName = "SOLUONGBAN";
            this.SOLUONGBAN.HeaderText = "Số lượng bán";
            this.SOLUONGBAN.Name = "SOLUONGBAN";
            this.SOLUONGBAN.ReadOnly = true;
            // 
            // DONGIANHAP
            // 
            this.DONGIANHAP.DataPropertyName = "DONGIANHAP";
            this.DONGIANHAP.HeaderText = "Đơn giá nhập";
            this.DONGIANHAP.Name = "DONGIANHAP";
            this.DONGIANHAP.ReadOnly = true;
            this.DONGIANHAP.Width = 250;
            // 
            // UCDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCDoanhThu";
            this.Size = new System.Drawing.Size(990, 583);
            this.Load += new System.EventHandler(this.UCDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radThang;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataDoanhThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbtongnhap;
        private System.Windows.Forms.ComboBox cbLai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTongxuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnLocNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIANHAP;
    }
}
