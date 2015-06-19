using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using WindowsFormsApplication2.APP;
using WindowsFormsApplication2.APP.HeThong;
using WindowsFormsApplication2.APP.Nhân_viên;
using WindowsFormsApplication2.APP.HoaDon;
using WindowsFormsApplication2.APP.KhachHang;
using WindowsFormsApplication2.APP.NhaCungCap;
using WindowsFormsApplication2.APP.DVT;
using System.Data;

namespace WindowsFormsApplication2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public static string quyen;
        public static string maNV;
        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._panelMain.Controls.Clear();
            UCThuoc thuoc = new UCThuoc();
            thuoc.Dock = DockStyle.Fill;
            this._panelMain.Controls.Add(thuoc);
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SLPHDuLieu sldl = new SLPHDuLieu();
            sldl.ShowDialog();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn thoát?","Thông báo", 
              MessageBoxButtons.OKCancel, 
              MessageBoxIcon.Question);
            this.Hide();
            FrmDangNhap dangnhap = new FrmDangNhap();
            dangnhap.Show();
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._panelMain.Controls.Clear();
            UCNhanVien nhanvien = new UCNhanVien();
            nhanvien.Dock = DockStyle.Fill;
            this._panelMain.Controls.Add(nhanvien);
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDonBanHang hoadon = new FrmHoaDonBanHang();
            hoadon.ShowDialog();
        }

        private void báoCáoDanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._panelMain.Controls.Clear();
            UCDoanhThu doanhthu = new UCDoanhThu();
            doanhthu.Dock = DockStyle.Fill;
            this._panelMain.Controls.Add(doanhthu);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau doimk = new FrmDoiMatKhau();
            doimk.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachHang kh = new FrmKhachHang();
            kh.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap ncc = new FrmNhaCungCap();
            ncc.Show();
        }

        private void nhậpThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhapHang nhaphang = new FrmNhapHang();
            nhaphang.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UCThuoc thuoc = new UCThuoc();
            this._panelMain.Controls.Clear();
            thuoc.Dock = DockStyle.Fill;
            this._panelMain.Controls.Add(thuoc);

            if (quyen == "Nhân viên")
            {
                vToolStripMenuItem.Enabled = false;
                cToolStripMenuItem.Enabled = false;
            }
            string sql = "SELECT NHANVIEN.HOTEN, ChUCVU.MOTA FROM NHANVIEN,CHUCVU WHERE CHUCVU.MACHUCVU = NHANVIEN.MACHUCVU AND MANHANVIEN = '"+maNV+"' ";
            KetNoi kn = new KetNoi();
            DataTable TenNhanVien = kn.TaoBang(sql);
            if (TenNhanVien.Rows.Count > 0)
            {
                _toolStripStatusLabel.Text = TenNhanVien.Rows[0][0].ToString();
                toolStripStatusLabel3.Text = TenNhanVien.Rows[0][1].ToString();
            }
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDVT dvt = new FrmDVT();
            dvt.Show();
        }
        private void khoThuoc_Click(object sender, EventArgs e)
        {
            FrmKho kho = new FrmKho();
            kho.Show();
        }
        private void quyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoaiThuoc loaithuoc = new FrmLoaiThuoc();
            loaithuoc.ShowDialog();
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UCThuoc ucThuoc = new UCThuoc();
            this._panelMain.Controls.Clear();
            ucThuoc.Dock = DockStyle.Fill;
            this._panelMain.Controls.Add(ucThuoc);
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap dangnhap = new FrmDangNhap();
            dangnhap.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap dangnhap = new FrmDangNhap();
            dangnhap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnbanhang.BackColor = Color.FromArgb(66, 131, 222);
            btnbaocao.BackColor = Color.FromArgb(103, 103, 103);
            btndangxuat.BackColor = Color.FromArgb(103, 103, 103);
            btnnhaphang.BackColor = Color.FromArgb(103, 103, 103);
            FrmHoaDonBanHang hoadon = new FrmHoaDonBanHang();
            hoadon.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnbaocao.BackColor = Color.FromArgb(66, 131, 222);
            btndangxuat.BackColor = Color.FromArgb(103, 103, 103);
            btnnhaphang.BackColor = Color.FromArgb(103, 103, 103);
            btnbanhang.BackColor = Color.FromArgb(103, 103, 103);

            UCDoanhThu doanhthu = new UCDoanhThu();
            this._panelMain.Controls.Clear();
            doanhthu.Dock = DockStyle.Fill;
            this._panelMain.Controls.Add(doanhthu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnnhaphang.BackColor = Color.FromArgb(66, 131, 222);
            btndangxuat.BackColor = Color.FromArgb(103, 103, 103);
            btnbanhang.BackColor = Color.FromArgb(103, 103, 103);
            btnbaocao.BackColor = Color.FromArgb(103, 103, 103);

            FrmNhapHang nhaphang = new FrmNhapHang();
            nhaphang.ShowDialog();
        }

        private void _panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmKho kho = new FrmKho();
            kho.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
