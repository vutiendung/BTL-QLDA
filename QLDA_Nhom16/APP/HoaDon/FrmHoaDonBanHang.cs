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
    public partial class FrmHoaDonBanHang : Form
    {
        #region Khai bao  ket noi va table
        private KetNoi _ketNoi = new KetNoi();
        DataTable Thuoc;
        DataTable HoaDon;
        #endregion

        #region khai bao bien
        private string soPhieu;
        private int viTri;
        private int vitriHoaDon;
        #endregion

        public FrmHoaDonBanHang()
        {
            InitializeComponent();
        }
        public static string ChangeNumberToString(string SoTien)
        {
            string str1 = "";
            try
            {
                string[] strArray1 = new string[10]
        {
          "không",
          "một",
          "hai",
          "ba",
          "bốn",
          "năm",
          "sáu",
          "bẩy",
          "tám",
          "chín"
        };
                string[] strArray2 = new string[12];
                char ch;
                for (int index = 0; index < SoTien.Length; ++index)
                {
                    ch = SoTien[SoTien.Length - index - 1];
                    string str2 = ch.ToString();
                    strArray2[index] = strArray1[(int)Convert.ToInt16(str2)];
                }
                for (int length = SoTien.Length; length < 12; ++length)
                    strArray2[length] = (string)null;
                string str3 = XuLy3So(strArray2[11], strArray2[10], strArray2[9]);
                string str4 = XuLy3So(strArray2[8], strArray2[7], strArray2[6]);
                string str5 = XuLy3So(strArray2[5], strArray2[4], strArray2[3]);
                string str6 = XuLy3So(strArray2[2], strArray2[1], strArray2[0]);
                if (str3 != "")
                    str3 += " tỷ";
                if (str4 != "")
                    str4 += " triệu";
                if (str5 != "")
                    str5 += " nghìn";
                string str7 = str6 + " đồng";
                str1 = str3 + str4 + str5 + str7 + " chẵn";
                str1 = str1.Trim();
                ch = str1[0];
                str1 = ch.ToString().ToUpper() + str1.Remove(0, 1);
                if (str1.Length > 1)
                {
                    ch = str1[0];
                    str1 = ch.ToString().ToUpper() + str1.Remove(0, 1);
                }
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.ToString());
            }
            return str1;
        }

        private static string XuLy3So(string so1, string so2, string so3)
        {
            string str1 = "";
            if (so1 != null && so2 != null && so3 != null)
            {
                string str2 = " " + so1 + " trăm";
                string str3 = "";
                string str4 = " " + so3;
                if (so2 != "một" && so2 != "không")
                {
                    str3 = " " + so2 + " mươi";
                    if (so3 == "một")
                        str4 = " mốt";
                    if (so3 == "không")
                        str4 = "";
                }
                else if (so2 != "không")
                {
                    str3 = " mười";
                    if (so1 == "không" || so3 == "không")
                        str4 = "";
                }
                else if (so3 != "không")
                {
                    str3 = " linh";
                }
                else
                {
                    if (so1 == "không")
                    {
                        str2 = "";
                        str3 = "";
                    }
                    str4 = "";
                }
                str1 = str2 + str3 + str4;
            }
            else if (so2 != null && so3 != null)
            {
                string str2 = " " + so2 + " mươi ";
                string str3 = " " + so3;
                if (so2 == "một")
                    str2 = " mười";
                else if (so3 == "một")
                    str3 = " mốt";
                if (so3 == "không")
                    str3 = "";
                str1 = str2 + str3;
            }
            else if (so3 != null)
                str1 = so3;
            return str1;
        }

        private string LayMaDonViQuyDoi(string tenThuoc)
        {
            foreach (DataRow dr in Thuoc.Rows)
            {

                if (dr[1].ToString() == tenThuoc)
                    return dr[4].ToString();
            }
            return "";
        }

        private string LayTenThuoc(string maThuoc)
        {
            foreach (DataRow dr in Thuoc.Rows)
            {
                if (dr[0].ToString() == maThuoc)
                    return dr[1].ToString();
            }
            return "";
        }

        private string LayMoTaDVQD(string maDV)
        {
            if (maDV != "")
            {
                string qr = "select MOTA from DONVITINH where MADONVI='" + maDV + "'";
                DataTable donViTInh = _ketNoi.TaoBang(qr);
                if (donViTInh.Rows.Count > 0)
                {
                    return donViTInh.Rows[0][0].ToString();
                }
                else
                    return "";
            }
            else
                return "";
        }
        //ham clean
        private void clean()
        {
            txtTenThuoc.Text = "";

        }

        private void LoadHoaDon()
        {
            ClearDTGPhieuNhap();
            string qrHoaDon = "select * from HoaDon";
            HoaDon = _ketNoi.TaoBang(qrHoaDon);
            dtgPhieuNhap.DataSource = HoaDon;
        }

        private void LoadThuoc()
        {
            string qr = "select * from THUOC";
            Thuoc = _ketNoi.TaoBang(qr);
        }

        private void FormLoad(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            LoadHoaDon();
            LoadThuoc();
            soPhieu = "P" + (LaySoLuongHoaDon() + 1);
            txtSoPhieu.Text = soPhieu;
            
            txtTenThuoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenThuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (DataRow dr in Thuoc.Rows)
            {

                txtTenThuoc.AutoCompleteCustomSource.Add(dr[1].ToString());
            }

            string qrNhanVien = "SELECT MANHANVIEN,HOTEN FROM NHANVIEN";
            DataTable nhanVien = _ketNoi.TaoBang(qrNhanVien);
            cbNhanVien.DataSource = nhanVien;
            cbNhanVien.DisplayMember = "HOTEN";
            cbNhanVien.ValueMember = "MANHANVIEN";

            string qrKho = "SELECT TENKHO FROM KHOTHUOC";
            DataTable kho = _ketNoi.TaoBang(qrKho);
            cbKho.DataSource = kho;
            cbKho.DisplayMember = "TENKHO";
            //cbNhanVien.ValueMember = "TENKHO";
        }

        private void txtTenThuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtTenThuoc.Text != "")
            {
                string qrDVT = "SELECT * FROM DONVITINH";
                DataTable DVT = _ketNoi.TaoBang(qrDVT);
                cbDVT.DataSource = DVT;
                cbDVT.DisplayMember = "MOTA";
                cbDVT.ValueMember = "MADONVI";
            }
            
        }

        private void btnThemonClick(object sender, EventArgs e)
        {
            string maCTHD = "CTHD" + (laySOLuongCTHD() + 1 + dtgChiTietHD.Rows.Count);
            string maThuoc = layMaThuoc(txtTenThuoc.Text);
            string maLoThuoc = txtLoSX.Text;
            int soLuog = int.Parse(txtSoLuong.Text);
            double donGia = double.Parse(txtDonGia.Text);
            double thanhTien = double.Parse(txtThanhTien.Text);
            if (txtSoLuong.Text != "" && txtDonGia.Text != "" && txtTenThuoc.Text != "")
            {
                dtgChiTietHD.ColumnCount = 7;
                int vt = dtgChiTietHD.Rows.Count;
                dtgChiTietHD.Rows.Add(1);
                dtgChiTietHD.Rows[vt].Cells[0].Value = maCTHD;
                dtgChiTietHD.Rows[vt].Cells[1].Value = soPhieu;
                dtgChiTietHD.Rows[vt].Cells[2].Value = maThuoc;
                dtgChiTietHD.Rows[vt].Cells[3].Value = maLoThuoc;
                dtgChiTietHD.Rows[vt].Cells[4].Value = soLuog;
                dtgChiTietHD.Rows[vt].Cells[5].Value = donGia;
                dtgChiTietHD.Rows[vt].Cells[6].Value = thanhTien;
                tinhTongTien();

            }
            else
            {
                MessageBox.Show("Bạn không để trường dữ liệu nào trống!"
                                , "Cảnh báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Warning);
            }
            tinhTongTien();
            string TT = txtTongCong.Text;
            lbTongChu.Text = ChangeNumberToString(TT).ToString();

        }

        private string layMaThuoc(string tenThuoc)
        {
            foreach (DataRow dr in Thuoc.Rows)
            {
                if (dr[1].ToString() == tenThuoc)
                    return dr[0].ToString();
            }
            return "";
        }

        private int LaySoLuongHoaDon()
        {
            string qr = "select count(SOHOADON) from HOADON";
            DataTable dt = _ketNoi.TaoBang(qr);
            return int.Parse(dt.Rows[0][0].ToString());
        }

        private int laySOLuongCTHD()
        {
            string qr = "select count(MACTHOADON) from CTHOADON";
          //  string qr = "select count(SOHOADON) from HOADON";
            DataTable dt = _ketNoi.TaoBang(qr);
            return int.Parse(dt.Rows[0][0].ToString());
        }

        private void ThemChiTietHDVaoCSDL()
        {
            if (dtgChiTietHD.Rows.Count > 0)
            {
                for (int i = 0; i < dtgChiTietHD.Rows.Count; i++)
                {
                    string qr = "insert into CTHOADON VALUES(";
                    qr += "'" + dtgChiTietHD.Rows[i].Cells[0].Value.ToString() + "',";
                    qr += "'" + dtgChiTietHD.Rows[i].Cells[1].Value.ToString() + "',";
                    qr += "'" + dtgChiTietHD.Rows[i].Cells[2].Value.ToString() + "',";
                    qr += "'" + dtgChiTietHD.Rows[i].Cells[3].Value.ToString() + "',";
                    qr += "'" + dtgChiTietHD.Rows[i].Cells[4].Value.ToString() + "',";
                    qr += "'" + dtgChiTietHD.Rows[i].Cells[5].Value.ToString() + "',";
                    qr += "'" + dtgChiTietHD.Rows[i].Cells[6].Value.ToString() + "')";
                    _ketNoi.ThucHien(qr);
                    qr = null;
                }
            }
            else
            {

                MessageBox.Show("Không có gì để thêm!"
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text != "" || txtSoLuong.Text != "")
            {
                try
                {
                    double sl = double.Parse(txtSoLuong.Text);
                    double dg = double.Parse(txtDonGia.Text);
                    double tt = sl * dg;
                    txtThanhTien.Text = tt.ToString();
                }
                catch { }
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text != "" || txtSoLuong.Text != "")
            {
                try
                {
                    double sl = double.Parse(txtSoLuong.Text);
                    double dg = double.Parse(txtDonGia.Text);
                    double tt = sl * dg;
                    txtThanhTien.Text = tt.ToString();
                }
                catch { }
            }
        }

        private void ThemHoaDonVaoCSDL()
        {
            string maNhanVien = cbNhanVien.SelectedValue.ToString();
            string ngayNhap = dateNgayXuat.Text;
            string kho = "Kho1";
            double tongTien = double.Parse(txtTongCong.Text);
            string qr = "insert into HOADON values('" + soPhieu + "','" + maNhanVien + "','" + ngayNhap + "','" + kho + "','" + tongTien + "')";
            _ketNoi.ThucHien(qr);
            ClearDTGPhieuNhap();
            LoadHoaDon();

            MessageBox.Show("Thêm hóa đơn thành công!"
                            , "Thông báo"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
        }

        private void btnThemMoiHoaDonOnClick(object sender, EventArgs e)
        {
            ThemChiTietHDVaoCSDL();
            ThemHoaDonVaoCSDL();
            soPhieu = "P" + (LaySoLuongHoaDon() + 1);
            txtSoPhieu.Text = soPhieu;
            ClearDTGCTHoaDon();
        }

        private void ClearDTGCTHoaDon()
        {
            while (dtgChiTietHD.Rows.Count > 0)
            {
                dtgChiTietHD.Rows.RemoveAt(0);
            }
        }

        private void ClearDTGPhieuNhap()
        {
            while (dtgPhieuNhap.Rows.Count>0)
            {
                dtgPhieuNhap.Rows.RemoveAt(0);
            }
        }

        private void dtgChiTietHDOnCellCick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            if (viTri >= 0 && viTri < dtgChiTietHD.Rows.Count)
            {
                txtTenThuoc.Text = LayTenThuoc(dtgChiTietHD.Rows[viTri].Cells[2].Value.ToString());
                txtSoLuong.Text=dtgChiTietHD.Rows[viTri].Cells[4].Value.ToString();
                txtDonGia.Text=dtgChiTietHD.Rows[viTri].Cells[5].Value.ToString();
                txtLoSX.Text=dtgChiTietHD.Rows[viTri].Cells[3].Value.ToString();
            }
            
        }

        private void tinhTongTien()
        {
            double tongTien = 0;
            if (dtgChiTietHD.Rows.Count > 0)
            {
                for (int i = 0; i < dtgChiTietHD.Rows.Count; i++)
                { 
                    tongTien+=double.Parse(dtgChiTietHD.Rows[i].Cells[6].Value.ToString());
                }
            }
            txtTongCong.Text = tongTien.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (viTri >= 0 && viTri < dtgChiTietHD.Rows.Count)
            {
                double tongTien = double.Parse(txtTongCong.Text);
                tongTien += double.Parse(txtThanhTien.Text);
                txtTongCong.Text = tongTien.ToString();

                string maCTHD = "CTHD" + (laySOLuongCTHD() + 1 + dtgChiTietHD.Rows.Count);
                string maThuoc = layMaThuoc(txtTenThuoc.Text);
                string maLoThuoc = txtLoSX.Text;
                int soLuog = int.Parse(txtSoLuong.Text);
                double donGia = double.Parse(txtDonGia.Text);
                double thanhTien = double.Parse(txtThanhTien.Text);
                if (txtSoLuong.Text != "" && txtDonGia.Text != "" && txtTenThuoc.Text != "")
                {
                    dtgChiTietHD.Rows[viTri].Cells[0].Value = maCTHD;
                    dtgChiTietHD.Rows[viTri].Cells[1].Value = soPhieu;
                    dtgChiTietHD.Rows[viTri].Cells[2].Value = maThuoc;
                    dtgChiTietHD.Rows[viTri].Cells[3].Value = maLoThuoc;
                    dtgChiTietHD.Rows[viTri].Cells[4].Value = soLuog;
                    dtgChiTietHD.Rows[viTri].Cells[5].Value = donGia;
                    dtgChiTietHD.Rows[viTri].Cells[6].Value = thanhTien;
                    tinhTongTien();
                }
                else
                {
                    MessageBox.Show("Bạn không để trường dữ liệu nào trống!"
                                    , "Cảnh báo"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Warning);
                }
            }
            
        }

        private void btnXoaOnClick(object sender, EventArgs e)
        {
            if (viTri >= 0 && viTri < dtgChiTietHD.Rows.Count)
            {
                if (MessageBox.Show("Bạn có muốn xóa khỏi hóa đơn?"
                                    ,"Thông báo"
                                    ,MessageBoxButtons.OKCancel
                                    ,MessageBoxIcon.Question)
                                    == DialogResult.OK)
                {
                    dtgChiTietHD.Rows.RemoveAt(viTri);
                    tinhTongTien();
                }
            }
            
        }

        private void txtTimKiemTextChange(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text;
            if (key.Length == 0)
            {
                LoadHoaDon();
            }
            else
            {
                string qr = "select * from HOADON WHERE SOHOADON LIKE '%"+key+"%'";
                DataTable bin_TKHoaDon = _ketNoi.TaoBang(qr);
                ClearDTGPhieuNhap();
                dtgPhieuNhap.DataSource = bin_TKHoaDon;
            }
        }

        private void dtgPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitriHoaDon = e.RowIndex;
            if (vitriHoaDon >= 0 && vitriHoaDon < dtgPhieuNhap.Rows.Count)
            {
                string qrLayHoaDon = "select * from HOADON where SOHOADON='"+dtgPhieuNhap.Rows[vitriHoaDon].Cells[0].Value.ToString()+"'";
                DataTable bin_hoaDon = _ketNoi.TaoBang(qrLayHoaDon);
                txtSoPhieu.Text = bin_hoaDon.Rows[0][0].ToString();
                cbNhanVien.SelectedValue = bin_hoaDon.Rows[0][1].ToString();
                //dateNgayXuat.Value = DateTime.Parse(bin_hoaDon.Rows[0][2].ToString());
                cbKho.Text = bin_hoaDon.Rows[0][3].ToString();
                txtTongCong.Text = bin_hoaDon.Rows[0][4].ToString();

                string qrlayCTHoaDon = "select * from CTHOADON where SOHOADON='" + dtgPhieuNhap.Rows[vitriHoaDon].Cells[0].Value.ToString() + "'";
                DataTable bin_CTHOADON = _ketNoi.TaoBang(qrlayCTHoaDon);

                ClearDTGCTHoaDon();
                dtgChiTietHD.ColumnCount = 7;
                for (int i = 0; i < bin_CTHOADON.Rows.Count;i++)
                {
                    dtgChiTietHD.Rows.Add();
                    dtgChiTietHD.Rows[i].Cells[0].Value = bin_CTHOADON.Rows[i][0].ToString();
                    dtgChiTietHD.Rows[i].Cells[1].Value = bin_CTHOADON.Rows[i][1].ToString();
                    dtgChiTietHD.Rows[i].Cells[2].Value = bin_CTHOADON.Rows[i][2].ToString();
                    dtgChiTietHD.Rows[i].Cells[3].Value = bin_CTHOADON.Rows[i][3].ToString();
                    dtgChiTietHD.Rows[i].Cells[4].Value = bin_CTHOADON.Rows[i][4].ToString();
                    dtgChiTietHD.Rows[i].Cells[5].Value = bin_CTHOADON.Rows[i][5].ToString();
                    dtgChiTietHD.Rows[i].Cells[6].Value = bin_CTHOADON.Rows[i][6].ToString();

                }
                string TT = txtTongCong.Text;
                lbTongChu.Text = ChangeNumberToString(TT).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Taomoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            ClearDTGCTHoaDon();
            txtDonGia.Text = "";
            txtLoSX.Text = "";
            txtSoPhieu.Text = "";
            txtThanhTien.Text = "";
            txtDonGia.Text = "";
            cbKho.Text = "";
            cbNhanVien.Text = "";
            txtSoLuong.Text = "";
            lbTongChu.Text = "";
            txtTongCong.Text = "";
        }

        private void dateTimKiem_ValueChanged(object sender, EventArgs e)
        {
            string key = dateTimKiem.Text;
            if (key.Length == 0)
            {
                LoadHoaDon();
            }
            else
            {
                string qr = "SELECT * FROM HOADON WHERE HOADON.NGAYLAP = '%" + key + "%'";
                DataTable bin_TKHoaDon = _ketNoi.TaoBang(qr);
                ClearDTGPhieuNhap();
                dtgPhieuNhap.DataSource = bin_TKHoaDon;
            }
        }
    }
}
