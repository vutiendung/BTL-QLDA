using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.APP.KhachHang
{
    public partial class FrmKhachHang : Form
    {
        private KetNoi _ketNoi = new KetNoi();
        private static int viTri;

        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ClearRow()
        {
            while(dtgKhachHang.Rows.Count>0)
            {
                dtgKhachHang.Rows.RemoveAt(0);
            }
        }

        private void LoadData()
        {
            ClearRow();
            string qrLoadData = "select * from KHACHHANG";
            DataTable khachHang = _ketNoi.TaoBang(qrLoadData);
            dtgKhachHang.DataSource = khachHang;
        }

        private void txtTimKiemChange(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text;
            if (key.Length == 0)
            {
                LoadData();
            }
            else
            {
                string qrTimKiem = "select * from KhachHang where TENKHACHHANG LIKE N'%"+key+"%'";
                qrTimKiem += " or DIACHI LIKE N'%"+key+"%'";
                qrTimKiem += " or DIENTHOAI LIKE '"+key+"'";
                DataTable kq = _ketNoi.TaoBang(qrTimKiem);
                ClearRow();
                dtgKhachHang.DataSource = kq;
            }
        }

        private void dtgKhachHangCellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            if (viTri >= 0 && viTri < dtgKhachHang.Rows.Count)
            {
                //load data len textbox
                txtMaKhachHang.Text = dtgKhachHang.Rows[viTri].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dtgKhachHang.Rows[viTri].Cells[1].Value.ToString();
                txtDiaChi.Text = dtgKhachHang.Rows[viTri].Cells[2].Value.ToString();
                txtDienThoai.Text = dtgKhachHang.Rows[viTri].Cells[3].Value.ToString();
            }
        }

        private void btnXoaOnClick(object sender, EventArgs e)
        {
            if (viTri >= 0 && viTri < dtgKhachHang.Rows.Count)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Question)
                                    == DialogResult.OK)
                {
                    //Xóa 
                    string maKhachHang = txtMaKhachHang.Text;
                    string qrXoa = "delete from KHACHHANG WHERE MAKHACHHANG='"+maKhachHang+"'";
                    _ketNoi.ThucHien(qrXoa);
                    LoadData();
                    MessageBox.Show("Xóa thành công!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn đã chọn sai vị trí cần xóa!!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
            }
        }

        private void btnThemOnClick(object sender, EventArgs e)
        {
            string maKhachHang = "KH"+dtgKhachHang.Rows.Count+1;
            string tenKhachHang = txtTenKhachHang.Text;
            string diaChi = txtDiaChi.Text;
            string dienThoai = txtDienThoai.Text;

            string qrThem = "insert into KHACHHANG VALUES('"+maKhachHang+"',N'"+tenKhachHang+"',N'"+diaChi+"','"+dienThoai+"')";
            _ketNoi.ThucHien(qrThem);
            LoadData();
            MessageBox.Show("Thêm thành công!"
                            , "Thông báo"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
        }

        private void btnSuaOnClick(object sender, EventArgs e)
        {
            string maKhachHang = txtMaKhachHang.Text;
            string tenKhachHang = txtTenKhachHang.Text;
            string diaChi = txtDiaChi.Text;
            string dienThoai = txtDienThoai.Text;

            string qrSua= "update KHACHHANG set TENKHACHHANG='"+tenKhachHang+"',DIACHI='"+diaChi+"',DIENTHOAI='"+dienThoai+"' WHERE MAKHACHHANG='"+maKhachHang+"'";
            _ketNoi.ThucHien(qrSua);
            LoadData();
            MessageBox.Show("Sửa thành công!"
                            , "Thông báo"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
        }

        private void btnThoatOnClick(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
