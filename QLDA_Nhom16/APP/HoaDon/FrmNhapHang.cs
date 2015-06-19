using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.APP.HoaDon
{
    public partial class FrmNhapHang : Form
    {
        private DataTable PhieuNhapHang;
        private KetNoi _ketNoi = new KetNoi();
        private static DataTable Thuoc;
        private int viTriCTPH;
        private int viTriPN;

        public FrmNhapHang()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoadPhieuNhapHang()
        {
            string qr = "select * from PHIEUNHAP";
            PhieuNhapHang = _ketNoi.TaoBang(qr);
            dtgPhieuNhap.DataSource = PhieuNhapHang;
        }

        private int LaySLPhieuNhap()
        {
            string qr="select count(SOPHIEU) from PHIEUNHAP";
            DataTable dt=_ketNoi.TaoBang(qr);
            return int.Parse(dt.Rows[0][0].ToString());
        }

        private string TaoMaPhieuNhap()
        {
            return "PN"+(LaySLPhieuNhap()+1);
        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            LoadThuoc();
            LoadPhieuNhap();
            LoadCBNCC();
            LoadCBNhanVien();
            string qrKho = "SELECT TENKHO FROM KHOTHUOC";
            DataTable kho = _ketNoi.TaoBang(qrKho);
            cbKho.DataSource = kho;
            cbKho.DisplayMember = "TENKHO";
        }

        private void LoadThuoc()
        {
            string qr = "select * from THUOC";
            Thuoc = _ketNoi.TaoBang(qr);
            foreach(DataRow dr in Thuoc.Rows)
            {
                txtTenThuoc.AutoCompleteCustomSource.Add(dr[1].ToString());
            }
        }

        private string TimMaThuoc(string tenThuoc)
        {
            foreach (DataRow dr in Thuoc.Rows)
            {
                if (dr[1].ToString() == tenThuoc)
                    return dr[0].ToString();
            }
            return "";
        }

        private void XoaDTGChiTiet()
        {
            while (dtgCTPhieuNhap.Rows.Count > 0)
            {
                dtgCTPhieuNhap.Rows.RemoveAt(0);
            }
        }

        private void XoaDTGPhieuNhap()
        {
            while (dtgPhieuNhap.Rows.Count > 0)
            {
                dtgPhieuNhap.Rows.RemoveAt(0);
            }
        }

        private void LoadPhieuNhap()
        {
            XoaDTGPhieuNhap();
            string qr="select * from PHIEUNHAP";
            DataTable PN=_ketNoi.TaoBang(qr);
            dtgPhieuNhap.DataSource = PN;
        }

        private string TimMaDonVi(string tenThuoc)
        {
            foreach (DataRow dr in Thuoc.Rows)
            {
                if (dr[1].ToString() == tenThuoc)
                    return dr[3].ToString();
            }
            return "";
        }

        private string TimTenDVT(string maDonVi)
        {
            string qr = "select MOTA from DONVITINH where MADONVI='" + maDonVi + "'";
            DataTable dt = _ketNoi.TaoBang(qr);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
                return "";
            
        }

        private int LaySoLuongCHiTietNhap()
        {
            string qr = "select count(MACHITIETNHAP) from CTPHIEUNHAP";
            DataTable dt = _ketNoi.TaoBang(qr);
            return int.Parse(dt.Rows[0][0].ToString());
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            txtMaThuoc.Text = TimMaThuoc(txtTenThuoc.Text);
            txtDonVi.Text = TimTenDVT(TimMaDonVi(txtTenThuoc.Text));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maCTPhieuNhap="CTP"+(LaySoLuongCHiTietNhap()+dtgCTPhieuNhap.Rows.Count+1);
            string soPhieu=TaoMaPhieuNhap();
            string maThuoc=txtMaThuoc.Text;
            string loSX=txtLoSX.Text;
            string soLong=txtSoLuong.Value.ToString();
            string sonGia=txtDonGia.Value.ToString();
            string thanhTien=txtThanhTien.Text;

            if (txtThanhTien.Text != "0")
            {
                dtgCTPhieuNhap.ColumnCount = 7;
                int vt = dtgCTPhieuNhap.Rows.Count;
                dtgCTPhieuNhap.Rows.Add();
                dtgCTPhieuNhap.Rows[vt].Cells[0].Value = maCTPhieuNhap;
                dtgCTPhieuNhap.Rows[vt].Cells[1].Value = soPhieu;
                dtgCTPhieuNhap.Rows[vt].Cells[2].Value = maThuoc;
                dtgCTPhieuNhap.Rows[vt].Cells[3].Value = loSX;
                dtgCTPhieuNhap.Rows[vt].Cells[4].Value = soLong;
                dtgCTPhieuNhap.Rows[vt].Cells[5].Value = sonGia;
                dtgCTPhieuNhap.Rows[vt].Cells[6].Value = thanhTien;

            }
            else
            {
                MessageBox.Show("Bạn không để trường dữ liệu nào trống!"
                                , "Cảnh báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
            }
            TinhTongTien();
        }

        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            decimal tg=txtSoLuong.Value*txtDonGia.Value;
            txtThanhTien.Text = tg.ToString();
        }

        private void txtDonGia_ValueChanged(object sender, EventArgs e)
        {
            decimal tg = txtSoLuong.Value * txtDonGia.Value;
            txtThanhTien.Text = tg.ToString(); 
        }

        private void TinhTongTien()
        {
            int tg = 0;
            if (dtgCTPhieuNhap.Rows.Count > 0)
            {
                for (int i = 0; i < dtgCTPhieuNhap.Rows.Count; i++)
                { 
                    tg+=int.Parse(dtgCTPhieuNhap.Rows[i].Cells[6].Value.ToString());
                }
            }
            txtTongCong.Text = tg.ToString();
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private string LayTenThuoc(string maThuoc)
        {
            foreach(DataRow dr in Thuoc.Rows)
            {
                if(dr[0].ToString()==maThuoc)
                    return dr[1].ToString();
            }
            return "";
        }

        private void dtgCTPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTriCTPH=e.RowIndex;
            if(viTriCTPH>=0 && viTriCTPH<dtgCTPhieuNhap.Rows.Count)
            {
                txtTenThuoc.Text=LayTenThuoc(dtgCTPhieuNhap.Rows[viTriCTPH].Cells[2].Value.ToString());
                txtLoSX.Text = dtgCTPhieuNhap.Rows[viTriCTPH].Cells[3].Value.ToString();
                txtSoLuong.Value=int.Parse(dtgCTPhieuNhap.Rows[viTriCTPH].Cells[4].Value.ToString());
                txtDonGia.Value=int.Parse(dtgCTPhieuNhap.Rows[viTriCTPH].Cells[5].Value.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maCTPhieuNhap=txtMaThuoc.Text;
            string soPhieu=dtgCTPhieuNhap.Rows[viTriCTPH].Cells[1].Value.ToString();
            string maThuoc=txtMaThuoc.Text;
            string loSX=txtLoSX.Text;
            string soLong=txtSoLuong.Value.ToString();
            string sonGia=txtDonGia.Value.ToString();
            string thanhTien=txtThanhTien.Text;

            dtgCTPhieuNhap.Rows[viTriCTPH].Cells[0].Value = maCTPhieuNhap;
            dtgCTPhieuNhap.Rows[viTriCTPH].Cells[1].Value = soPhieu;
            dtgCTPhieuNhap.Rows[viTriCTPH].Cells[2].Value = maThuoc;
            dtgCTPhieuNhap.Rows[viTriCTPH].Cells[3].Value = loSX;
            dtgCTPhieuNhap.Rows[viTriCTPH].Cells[4].Value = soLong;
            dtgCTPhieuNhap.Rows[viTriCTPH].Cells[5].Value = sonGia;
            dtgCTPhieuNhap.Rows[viTriCTPH].Cells[6].Value = thanhTien;

            TinhTongTien();
        }

        private void ThemCTPhieuNhapVaoCSDL()
        {
            if (dtgCTPhieuNhap.Rows.Count > 0)
            {
                for (int i = 0; i < dtgCTPhieuNhap.Rows.Count; i++)
                {
                    string qr = "insert into CTPHIEUNHAP values(";
                    qr += "'" + dtgCTPhieuNhap.Rows[i].Cells[0].Value.ToString() + "'";
                    qr += ",'" + dtgCTPhieuNhap.Rows[i].Cells[1].Value.ToString() + "'";
                    qr += ",'" + dtgCTPhieuNhap.Rows[i].Cells[2].Value.ToString() + "'";
                    qr += ",'" + dtgCTPhieuNhap.Rows[i].Cells[3].Value.ToString() + "'";
                    qr += ",'" + dtgCTPhieuNhap.Rows[i].Cells[4].Value.ToString() + "'";
                    qr += ",'" + dtgCTPhieuNhap.Rows[i].Cells[5].Value.ToString() + "'";
                    qr += ", ''";
                    qr += ",'" + dtgCTPhieuNhap.Rows[i].Cells[6].Value.ToString() + "')";
                    _ketNoi.ThucHien(qr);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dtgCTPhieuNhap.Rows.RemoveAt(viTriCTPH);
        }

        private void ThemPNVaoCSDL()
        {
            string soPhieu = TaoMaPhieuNhap();
            string soHoaDon = "";
            string ngayNhap = dateNgayNhap.Text;
            string kho = cbKho.Text;
            string maNhanVien = cbNhaNVien.SelectedValue.ToString();
            string maNCC = cbNhaCungCap.SelectedValue.ToString();
            string tongTien = txtTongCong.Text;
            string ghiChu = txtGhiChu.Text;

            string qr = "insert into PHIEUNHAP VALUES('"+soPhieu+"','"+soHoaDon+"','"+ngayNhap+"','"+kho+"','"+maNhanVien+"','"+maNCC+"','"+tongTien+"','"+ghiChu+"')";
            _ketNoi.ThucHien(qr);
            MessageBox.Show("Thêm thành công!"
                            ,"Thông báo"
                            ,MessageBoxButtons.OK
                            ,MessageBoxIcon.Information);
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            txtSoPhieu.Text = TaoMaPhieuNhap();
            ThemCTPhieuNhapVaoCSDL();
            ThemPNVaoCSDL();
            LoadPhieuNhap();
            XoaDTGChiTiet();
        }

        private void LoadCBNhanVien()
        {
            string qr = "select MANHANVIEN,HOTEN from NHANVIEN";
            DataTable dtNhanVien = _ketNoi.TaoBang(qr);
            cbNhaNVien.DataSource = dtNhanVien;
            cbNhaNVien.DisplayMember = "HOTEN";
            cbNhaNVien.ValueMember = "MANHANVIEN";
        }

        private void LoadCBNCC()
        {
            string qr = "select MANCC,TENNCC from NHACUNGCAP";
            DataTable dtNCC = _ketNoi.TaoBang(qr);
            cbNhaCungCap.DataSource = dtNCC;
            cbNhaCungCap.DisplayMember = "TENNCC";
            cbNhaCungCap.ValueMember = "MANCC";
        }

        private void dtgPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTriPN = e.RowIndex;
            if (viTriPN >= 0 && viTriPN < dtgPhieuNhap.Rows.Count)
            {
                string qr = "select * from PHIEUNHAP where SOPHIEU='"+dtgPhieuNhap.Rows[viTriPN].Cells[0].Value.ToString()+"'";
                DataTable dtPN = _ketNoi.TaoBang(qr);
                txtSoPhieu.Text = dtPN.Rows[0][0].ToString();
                txtSOHOAON.Text = dtPN.Rows[0][1].ToString();
                dateNgayNhap.Value = DateTime.Parse(dtPN.Rows[0][2].ToString());
                cbKho.Text = dtPN.Rows[0][3].ToString();
                cbNhaNVien.SelectedValue = dtPN.Rows[0][4].ToString();
                cbNhaCungCap.SelectedValue = dtPN.Rows[0][5].ToString();
                txtTongCong.Text = dtPN.Rows[0][6].ToString();
                txtGhiChu.Text = dtPN.Rows[0][7].ToString();

                string qr2 = "select * from CTPHIEUNHAP where MAPHIEUNHAP='" + txtSoPhieu .Text+ "'";
                DataTable dtCTPN = _ketNoi.TaoBang(qr2);
                XoaDTGChiTiet();
                dtgCTPhieuNhap.DataSource = dtCTPN;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadPhieuNhap();
            }
            else
            {
                string qrTimKiem = "select * from PHIEUNHAP where SOPHIEU like '%" + txtTimKiem.Text + "%'";
                DataTable dtTimKiem = _ketNoi.TaoBang(qrTimKiem);
                XoaDTGPhieuNhap();
                dtgPhieuNhap.DataSource = dtTimKiem;
            }
            
        }
    }
}
