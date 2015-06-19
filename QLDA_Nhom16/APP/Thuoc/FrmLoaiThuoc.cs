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
    public partial class FrmLoaiThuoc : Form
    {
        public FrmLoaiThuoc()
        {
            InitializeComponent();
            LoadData();
        }
        private KetNoi _ketNoi = new KetNoi();
        private static int viTri;
        void ClearRows()
        {
            while (data_LoaiThuoc.Rows.Count > 0)
            {
                data_LoaiThuoc.Rows.RemoveAt(0);
            }
        }
        void LoadData()
        {
            string querry = "select * from LOAITHUOC";
            DataTable loaithuoc = _ketNoi.TaoBang(querry);
            data_LoaiThuoc.DataSource = loaithuoc;
        }

        private void btnn_Xóa_Click(object sender, EventArgs e)
        {
            if (viTri >= 0 || viTri < data_LoaiThuoc.Rows.Count)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Question)
                                    == DialogResult.OK)
                {
                    string maLoaiThuoc = data_LoaiThuoc.Rows[viTri].Cells[0].Value.ToString();
                    string qrXoa = "delete from LOAITHUOC where MALOAITHUOC='" + maLoaiThuoc + "'";
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

        private void data_LoaiThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            if (viTri >= 0 && viTri < data_LoaiThuoc.Rows.Count)
            {
                txtTenLoaiThuoc.Text = data_LoaiThuoc.Rows[viTri].Cells[1].Value.ToString();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (viTri >= 0 || viTri < data_LoaiThuoc.Rows.Count)
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa không?!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Question)
                                    == DialogResult.OK)
                {
                    string maLoaiThuoc = data_LoaiThuoc.Rows[viTri].Cells[0].Value.ToString();
                    string tenLoaiThuoc = txtTenLoaiThuoc.Text;
                    string qrSua = "update LOAITHUOC set MOTA='" + tenLoaiThuoc + "' where MALOAITHUOC='" + maLoaiThuoc + "'";
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
        bool KiemTraTonTaiDVT(string tenLoaiThuoc)
        {
            string qr = "select MOTA from LOAITHUOC where MOTA='" + tenLoaiThuoc + "'";
            DataTable LoaiThuoc = _ketNoi.TaoBang(qr);
            if (LoaiThuoc.Rows.Count == 0)
                return false;
            else
                return true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {

            string maLoaiThuoc = "LT" + (data_LoaiThuoc.Rows.Count + 1);
            string tenLoaiThuoc = txtTenLoaiThuoc.Text;
            if (tenLoaiThuoc.Length != 0)
            {
                if (KiemTraTonTaiDVT(tenLoaiThuoc) == false)
                {
                    string qr = "insert into LOAITHUOC VALUES('" + maLoaiThuoc + "',N'" + tenLoaiThuoc + "')";
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

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void data_LoaiThuoc_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu ctx = new ContextMenu();
            MenuItem mItem = new MenuItem();
            mItem.Text = "Xóa";
            ctx.MenuItems.Add(mItem);
            mItem.Click += new System.EventHandler(this.menuItem1_Click);
            MenuItem mItem2 = new MenuItem();
            mItem2.Text = "Sửa";
            ctx.MenuItems.Add(mItem2);
            if (e.Button == MouseButtons.Right)
            {
                Point pt = new Point(e.X, e.Y);
                ctx.Show(data_LoaiThuoc, pt);
            }
           
                
            
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            if (viTri >= 0 || viTri < data_LoaiThuoc.Rows.Count)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Question)
                                    == DialogResult.OK)
                {
                    string maLoaiThuoc = data_LoaiThuoc.Rows[viTri].Cells[0].Value.ToString();
                    string qrXoa = "delete from LOAITHUOC where MALOAITHUOC='" + maLoaiThuoc + "'";
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

     
    }
}
