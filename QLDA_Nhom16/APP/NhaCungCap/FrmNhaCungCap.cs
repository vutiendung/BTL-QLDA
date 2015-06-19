using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.APP.NhaCungCap
{
    public partial class FrmNhaCungCap : Form
    {
        private KetNoi _ketNoi = new KetNoi();
        private static int viTri;
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            LoadData();
        }
        void ClearRows()
        {
            while (dtgNCC.Rows.Count > 0)
            {
                dtgNCC.Rows.RemoveAt(0);
            }
        }
        void LoadData()
        {
            ClearRows();
            txtMaNCC.Text = "NCC" + (dtgNCC.Rows.Count + 1);
            string qr="select * from NHACUNGCAP";
            DataTable nhaCC = _ketNoi.TaoBang(qr);
            dtgNCC.DataSource = nhaCC;

        }

        private void DataGridviewOnClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            if (viTri >= 0 && viTri < dtgNCC.Rows.Count)
            {
                txtMaNCC.Text = dtgNCC.Rows[viTri].Cells[0].Value.ToString();
                txtSDT.Text = dtgNCC.Rows[viTri].Cells[3].Value.ToString();
                txtDiaChi.Text = dtgNCC.Rows[viTri].Cells[2].Value.ToString();
                txtTenNCC.Text = dtgNCC.Rows[viTri].Cells[1].Value.ToString();
            }
        }

        private void btnXoaOnClick(object sender, EventArgs e)
        {
            if (viTri >= 0 && viTri < dtgNCC.Rows.Count)
            {
                if(MessageBox.Show("Bạn có muốn xóa không?!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Error)
                                    ==DialogResult.OK)
                {
                    string maNCC=txtMaNCC.Text;
                    string qrXoa = "delete from NHACUNGCAP WHERE MANCC='"+maNCC+"'";
                    _ketNoi.ThucHien(qrXoa);
                    LoadData();

                    txtTenNCC.Text = "";
                    txtDiaChi.Text = "";
                    txtSDT.Text = "";
                    txtMaNCC.Text = "";

                    MessageBox.Show("Xóa thành công!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
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

        private void btnThemOnClick(object sender, EventArgs e)
        {
            string maNCC = "NCC"+ (dtgNCC.Rows.Count+1);
            string tenNCC = txtTenNCC.Text;
            string diaChi = txtDiaChi.Text;
            string sDT = txtSDT.Text;

            string qrThem = "insert into NHACUNGCAP VALUES('"+maNCC+"',N'"+tenNCC+"',N'"+diaChi+"','"+sDT+"')";
            _ketNoi.ThucHien(qrThem);
            LoadData();
            MessageBox.Show("Thêm thành công!"
                            ,"Thông báo"
                            ,MessageBoxButtons.OK
                            ,MessageBoxIcon.Information);
            txtMaNCC.Text = "NCC" + (dtgNCC.Rows.Count + 1);
        }

        private void btnSuaOnClick(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text;
            string tenNCC = txtTenNCC.Text;
            string diaChi = txtDiaChi.Text;
            string sDT = txtSDT.Text;

            string qrSua = "update NHACUNGCAP SET TENNCC=N'"+tenNCC+"',DIACHI=N'"+diaChi+"',SDT='"+sDT+"' WHERE MANCC='"+maNCC+"'";
            if (MessageBox.Show("Bạn có muốn sửa không?"
                            , "Thông báo"
                            , MessageBoxButtons.OKCancel
                            , MessageBoxIcon.Question) == DialogResult.OK)
            {
                _ketNoi.ThucHien(qrSua);
                LoadData();
                MessageBox.Show("Sửa thành công!"
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text;
            if (key.Length == 0)
            {
                LoadData();
            }
            else
            {
                string qrSearch = "select * from NHACUNGCAP WHERE TENNCC LIKE '%"+key+"%' ";
                qrSearch+="OR DIACHI LIKE '%"+key+"%' ";
                qrSearch+="OR SDT LIKE '%"+key+"%'";
                DataTable resultSearch = _ketNoi.TaoBang(qrSearch);
                ClearRows();
                dtgNCC.DataSource = resultSearch;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
