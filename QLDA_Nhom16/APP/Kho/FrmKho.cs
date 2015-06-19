using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FrmKho : Form
    {
        public FrmKho()
        {
            InitializeComponent();
        }
        private KetNoi _ketNoi = new KetNoi();
        private static int viTri;
        void ClearRows()
        {
            while (dataKho.Rows.Count > 0)
            {
                dataKho.Rows.RemoveAt(0);
            }
        }
        void LoadData()
        {
          //  ClearRows();
            string querry = "select * from KHOTHUOC";
            DataTable kho = _ketNoi.TaoBang(querry);
            dataKho.DataSource = kho;
        }

        private void FrmKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (viTri >= 0 || viTri < dataKho.Rows.Count)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Question)
                                    == DialogResult.OK)
                {
                    string maKho = dataKho.Rows[viTri].Cells[0].Value.ToString();
                    string qrXoa = "delete from KHOTHUOC where MAKHOTHUOC='" + maKho + "'";
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
                MessageBox.Show("Bạn đã chọn sai vị trí cần xóa!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Error);
            }
        }
        bool KiemTraTonTaiKho(string tenKho)
        {
            string qr = "select TENKHO from KHOTHUOC where TENKHO='" + tenKho + "'";
            DataTable Kho = _ketNoi.TaoBang(qr);
            if (Kho.Rows.Count == 0)
                return false;
            else
                return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKho = "K" + (dataKho.Rows.Count + 1);
            string tenKho = txtTenKho.Text;
            string diaChi = txtDiachi.Text;
            string ghiChu = txtGhiChu.Text;
            if (tenKho.Length != 0)
            {
                if (KiemTraTonTaiKho(tenKho) == false)
                {
                    string qr = "insert into KHOTHUOC VALUES('" + maKho + "',N'" + tenKho + "',N'"+diaChi+"',N'"+ghiChu+"')";
                    _ketNoi.TaoBang(qr);
                    LoadData();
                    MessageBox.Show("Thêm thành công!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên đơn vị tính đã tồn tại.\nVui lòng chọn tên khác.!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn không được để trống tên đơn vị tính!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (viTri >= 0 || viTri < dataKho.Rows.Count)
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa không?!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Question)
                                    == DialogResult.OK)
                {
                    string maKho = dataKho.Rows[viTri].Cells[0].Value.ToString();
                    string tenKho = txtTenKho.Text;
                    string diaChi = txtDiachi.Text;
                    string ghiChu = txtGhiChu.Text;
                    string qrSua = "update KHOTHUOC set TENKHO='" + tenKho + "', DIACHI='"+diaChi+"', GHICHU='"+ghiChu+"' where MAKHOTHUOC='" + maKho  + "'";
                    _ketNoi.ThucHien(qrSua);
                    LoadData();
                    MessageBox.Show("Sửa thành công!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn đã chọn sai vị trí cần sửa!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Error);
            }
        }

        private void dataKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            if (viTri >= 0 && viTri < dataKho.Rows.Count)
            {
                txtTenKho.Text = dataKho.Rows[viTri].Cells[1].Value.ToString();
                txtDiachi.Text = dataKho.Rows[viTri].Cells[2].Value.ToString();
                txtGhiChu.Text = dataKho.Rows[viTri].Cells[3].Value.ToString();
            }
        }
    }
}
