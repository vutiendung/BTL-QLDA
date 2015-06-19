namespace WindowsFormsApplication2
{
    partial class frmImortThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImortThuoc));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPatch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkUpcase = new System.Windows.Forms.CheckBox();
            this.checkDeleteall = new System.Windows.Forms.CheckBox();
            this.rtxtErrorInfor = new System.Windows.Forms.RichTextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProgess = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTenSheet = new System.Windows.Forms.ComboBox();
            this.lblNanemProgess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.import_thuoc_wizard;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtPatch
            // 
            this.txtPatch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPatch.Location = new System.Drawing.Point(180, 44);
            this.txtPatch.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatch.Name = "txtPatch";
            this.txtPatch.Size = new System.Drawing.Size(475, 22);
            this.txtPatch.TabIndex = 6;
            this.txtPatch.Text = "Click để chọn File";
            this.txtPatch.Click += new System.EventHandler(this.txtPatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đương dẫn chứa file";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkUpcase);
            this.groupBox1.Controls.Add(this.checkDeleteall);
            this.groupBox1.Location = new System.Drawing.Point(178, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(475, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // checkUpcase
            // 
            this.checkUpcase.AutoSize = true;
            this.checkUpcase.Location = new System.Drawing.Point(49, 78);
            this.checkUpcase.Margin = new System.Windows.Forms.Padding(4);
            this.checkUpcase.Name = "checkUpcase";
            this.checkUpcase.Size = new System.Drawing.Size(114, 20);
            this.checkUpcase.TabIndex = 1;
            this.checkUpcase.Text = "Viết hoa tất cả ";
            this.checkUpcase.UseVisualStyleBackColor = true;
            // 
            // checkDeleteall
            // 
            this.checkDeleteall.AutoSize = true;
            this.checkDeleteall.Location = new System.Drawing.Point(49, 36);
            this.checkDeleteall.Margin = new System.Windows.Forms.Padding(4);
            this.checkDeleteall.Name = "checkDeleteall";
            this.checkDeleteall.Size = new System.Drawing.Size(175, 20);
            this.checkDeleteall.TabIndex = 0;
            this.checkDeleteall.Text = "Xóa thuốc có trong CSDL";
            this.checkDeleteall.UseVisualStyleBackColor = true;
            // 
            // rtxtErrorInfor
            // 
            this.rtxtErrorInfor.Location = new System.Drawing.Point(181, 277);
            this.rtxtErrorInfor.Name = "rtxtErrorInfor";
            this.rtxtErrorInfor.Size = new System.Drawing.Size(474, 112);
            this.rtxtErrorInfor.TabIndex = 4;
            this.rtxtErrorInfor.Text = "";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(552, 489);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(103, 33);
            this.btnNhap.TabIndex = 5;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhapOnClick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(182, 443);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(473, 28);
            this.progressBar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiến trình : ";
            // 
            // lblProgess
            // 
            this.lblProgess.AutoSize = true;
            this.lblProgess.Location = new System.Drawing.Point(322, 413);
            this.lblProgess.Name = "lblProgess";
            this.lblProgess.Size = new System.Drawing.Size(26, 16);
            this.lblProgess.TabIndex = 8;
            this.lblProgess.Text = "0/0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lỗi :";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(609, 413);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(15, 16);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên bảng";
            // 
            // cbTenSheet
            // 
            this.cbTenSheet.FormattingEnabled = true;
            this.cbTenSheet.Location = new System.Drawing.Point(254, 90);
            this.cbTenSheet.Name = "cbTenSheet";
            this.cbTenSheet.Size = new System.Drawing.Size(151, 24);
            this.cbTenSheet.TabIndex = 12;
            // 
            // lblNanemProgess
            // 
            this.lblNanemProgess.AutoSize = true;
            this.lblNanemProgess.Location = new System.Drawing.Point(190, 254);
            this.lblNanemProgess.Name = "lblNanemProgess";
            this.lblNanemProgess.Size = new System.Drawing.Size(0, 16);
            this.lblNanemProgess.TabIndex = 13;
            // 
            // frmImortThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 534);
            this.Controls.Add(this.lblNanemProgess);
            this.Controls.Add(this.cbTenSheet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProgess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.rtxtErrorInfor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatch);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmImortThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thuốc từ File";
            this.Load += new System.EventHandler(this.frmImortThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkUpcase;
        private System.Windows.Forms.CheckBox checkDeleteall;
        private System.Windows.Forms.RichTextBox rtxtErrorInfor;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProgess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTenSheet;
        private System.Windows.Forms.Label lblNanemProgess;
    }
}