using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.APP.Nhân_viên
{
    public partial class PopupNhanvien : Form
    {
        #region Khai báo
        private KetNoi _ketNoi = new KetNoi();
        private bool isUpdate;
        private string maNhanVien;
        public delegate void send(bool change = false);
        public send _send;
        #endregion
        public PopupNhanvien(string maNV,bool isUpdate)
        {
            InitializeComponent();
            this.isUpdate = isUpdate;
            this.maNhanVien = maNV;
            if (isUpdate)
            {
                lblMatKhau.Visible = false;
                txtMatKhau.Visible = false;
                lblDacBiet2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PopupNhanvien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = maNhanVien;
            string qr = "select * from CHUCVU";
            DataTable chucVu = _ketNoi.TaoBang(qr);
            cbChucVu.DataSource = chucVu;
            cbChucVu.DisplayMember = "MOTA";
            cbChucVu.ValueMember = "MACHUCVU";
            chucVu = null;
            if (isUpdate)
            {
                string qr2 = "select * from NHANVIEN where MANHANVIEN='"+maNhanVien+"'";
                DataTable nhanVien = _ketNoi.TaoBang(qr2);
                txtTenNV.Text=nhanVien.Rows[0][1].ToString();
                cbChucVu.SelectedItem= nhanVien.Rows[0][7].ToString();
                dateNgaysinh.Value = DateTime.Parse(nhanVien.Rows[0][10].ToString());
                bool gioiTinh = bool.Parse(nhanVien.Rows[0][3].ToString());
                if (gioiTinh)
                {
                    _radNam.Checked = true;
                }
                else
                {
                    _radNu.Checked = true;
                }
                _txtDiachi.Text = nhanVien.Rows[0][2].ToString();
                _txtDienthoai.Text = nhanVien.Rows[0][4].ToString();
                txtMucLuong.Text = nhanVien.Rows[0][6].ToString();
                txtEmail.Text = nhanVien.Rows[0][5].ToString();
                nhanVien.Dispose();
            }
        }

        private void btnLuuonClick(object sender, EventArgs e)
        {
            string tenNhanVien = txtTenNV.Text;
            string maChucVu = cbChucVu.SelectedValue.ToString();
            string ngaySinh = dateNgaysinh.Text;
            bool gioiTinh=true;
            string diaChi = _txtDiachi.Text;
            string email=txtEmail.Text;
            string sDt = _txtDienthoai.Text;
            float mucLuong = Single.Parse(txtMucLuong.Text);

            if (_radNam.Checked)
            {
                gioiTinh = true;
            }
            else
                if (_radNu.Checked)
                {
                    gioiTinh = false;
                }

            if (tenNhanVien != "" || txtMatKhau.Text!="")
            {
                if (isUpdate)
                {
                    //Update nhân viên
                    string qr = "update NHANVIEN SET HOTEN=N'" + tenNhanVien + "',DIACHI=N'" + diaChi + "',GIOITINH='" +gioiTinh+ "' ";
                    qr += ",SDT='"+sDt+"',EMAIL='"+email+"',MUCLUONG='"+mucLuong+"',MACHUCVU='"+maChucVu+"',NGAYSINH='"+ngaySinh+"' WHERE MANHANVIEN='"+maNhanVien+"'";

                    _ketNoi.ThucHien(qr);
                    this._send(true);

                    MessageBox.Show("Sửa thành công!"
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                    qr = null;
                }
                else
                {
                    //Thêm mới nhân viên
                    string matKhau = txtMatKhau.Text;
                    
                    string qr = "insert into NHANVIEN VALUES('"+maNhanVien+"',N'"+tenNhanVien+"',N'"+diaChi+"','"+gioiTinh+"','"+sDt+"'";
                    qr += ",'"+email+"','"+mucLuong+"','"+maChucVu+"','"+matKhau+"','"+ngaySinh+"')";
                    _ketNoi.ThucHien(qr);
                    this._send(true);

                    MessageBox.Show("Thêm mới thành công!"
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn không được để trống các trường có dấu * !"
                                ,"Thông báo"
                                ,MessageBoxButtons.OK
                                ,MessageBoxIcon.Information);
            }
        }
    }
}
