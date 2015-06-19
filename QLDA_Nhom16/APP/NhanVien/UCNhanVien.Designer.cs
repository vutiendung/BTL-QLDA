namespace WindowsFormsApplication2.APP.Nhân_viên
{
    partial class UCNhanVien
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
            this._btnXoa = new System.Windows.Forms.Button();
            this._btnSua = new System.Windows.Forms.Button();
            this._btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._btnXoa);
            this.panel1.Controls.Add(this._btnSua);
            this.panel1.Controls.Add(this._btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 49);
            this.panel1.TabIndex = 0;
            // 
            // _btnXoa
            // 
            this._btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnXoa.Image = global::WindowsFormsApplication2.Properties.Resources.Delete;
            this._btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnXoa.Location = new System.Drawing.Point(782, 3);
            this._btnXoa.Name = "_btnXoa";
            this._btnXoa.Size = new System.Drawing.Size(103, 31);
            this._btnXoa.TabIndex = 2;
            this._btnXoa.Text = "Xóa";
            this._btnXoa.UseVisualStyleBackColor = true;
            this._btnXoa.Click += new System.EventHandler(this._btnXoa_Click);
            // 
            // _btnSua
            // 
            this._btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSua.Image = global::WindowsFormsApplication2.Properties.Resources.Load;
            this._btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSua.Location = new System.Drawing.Point(660, 3);
            this._btnSua.Name = "_btnSua";
            this._btnSua.Size = new System.Drawing.Size(103, 31);
            this._btnSua.TabIndex = 1;
            this._btnSua.Text = "Sửa";
            this._btnSua.UseVisualStyleBackColor = true;
            this._btnSua.Click += new System.EventHandler(this.btnSuaOnClick);
            // 
            // _btnThem
            // 
            this._btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnThem.Image = global::WindowsFormsApplication2.Properties.Resources.Add;
            this._btnThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._btnThem.Location = new System.Drawing.Point(536, 3);
            this._btnThem.Name = "_btnThem";
            this._btnThem.Size = new System.Drawing.Size(103, 31);
            this._btnThem.TabIndex = 0;
            this._btnThem.Text = "Thêm";
            this._btnThem.UseVisualStyleBackColor = true;
            this._btnThem.Click += new System.EventHandler(this.btnThemClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 467);
            this.panel2.TabIndex = 1;
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.AllowUserToAddRows = false;
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column10,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dtgNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.ReadOnly = true;
            this.dtgNhanVien.RowHeadersVisible = false;
            this.dtgNhanVien.Size = new System.Drawing.Size(903, 467);
            this.dtgNhanVien.TabIndex = 0;
            this.dtgNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNhanVien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANHANVIEN";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HOTEN";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIACHI";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "NGAYSINH";
            this.Column10.HeaderText = "Ngày sinh";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GIOITINH";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "SDT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "EMAIL";
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MUCLUONG";
            this.Column7.HeaderText = "Mức lương";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MOTA";
            this.Column8.HeaderText = "Chức vụ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // UCNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCNhanVien";
            this.Size = new System.Drawing.Size(903, 516);
            this.Load += new System.EventHandler(this.NhanVienLoad);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnXoa;
        private System.Windows.Forms.Button _btnSua;
        private System.Windows.Forms.Button _btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
