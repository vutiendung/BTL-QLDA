using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Security.Cryptography;

namespace WindowsFormsApplication2.APP
{
    public partial class UCThuoc : UserControl
    {
        private KetNoi _ketNoi = new KetNoi();
        private static int viTri;
        private DataTable dataLoaiThuoc;

        private void NhanData(bool change)
        {
            if (change)
            {
                ClearRow();
                LoadData();
            }
        }

        public UCThuoc()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text;
            if (key.Length != 0)
            {
                string qr = "select MATHUOC,TENTHUOC,LOAITHUOC.MOTA,DONVITINH,DONVIQUYDOI,TYLEQUYDOI,CACHSUDUNG,XUATXU";
                qr += " FROM THUOC,LOAITHUOC,DONVITINH WHERE THUOC.MALOAITHUOC=LOAITHUOC.MALOAITHUOC AND THUOC.DONVIQUYDOI=DONVITINH.MADONVI";
                qr += " AND(TENTHUOC LIKE N'" + key + "%')";
                DataTable kq = _ketNoi.TaoBang(qr);
                ClearRow();
                dtgThuoc.DataSource = kq;
            }
            else
            {
                LoadData();
            }
        }

        private void UCThuocLoad(object sender, EventArgs e)
        {
            LoadData();
            LoadDataCombobox();

        }

        private void ClearRow()
        {
            while (dtgThuoc.Rows.Count > 0)
            {
                dtgThuoc.Rows.RemoveAt(0);
            }
        }

        private void LoadData()
        {
            string qrLoadData = "select MATHUOC,TENTHUOC,LOAITHUOC.MOTA,DONVITINH,DONVIQUYDOI,TYLEQUYDOI,CACHSUDUNG,XUATXU";
            qrLoadData += " FROM THUOC,LOAITHUOC,DONVITINH WHERE THUOC.MALOAITHUOC=LOAITHUOC.MALOAITHUOC AND THUOC.DONVIQUYDOI=DONVITINH.MADONVI";
            DataTable thuoc = _ketNoi.TaoBang(qrLoadData);
            dtgThuoc.DataSource = thuoc;
        }

        private void LoadDataCombobox()
        {
            string qrLoadLoaiTHuoc = "select * from LOAITHUOC";
            string qrLoadDVQD = "select * from DONVITINH";
            DataTable loaiThuoc = _ketNoi.TaoBang(qrLoadLoaiTHuoc);
            DataTable donViTinh = _ketNoi.TaoBang(qrLoadDVQD);
            DataTable donViQuyDoi = _ketNoi.TaoBang(qrLoadDVQD);
            dataLoaiThuoc = loaiThuoc;

            cbLoaiThuoc.DataSource = loaiThuoc;
            cbLoaiThuoc.DisplayMember = "MOTA";
            cbLoaiThuoc.ValueMember = "MALOAITHUOC";

            cbDVQD.DataSource = donViTinh;
            cbDVQD.ValueMember = "MADONVI";
            cbDVQD.DisplayMember = "MOTA";

            cbDVT.DataSource = donViQuyDoi;
            cbDVT.ValueMember = "MADONVI";
            cbDVT.DisplayMember = "MOTA";
        }

        private void DTGThuocOnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            if (viTri >= 0 && viTri < dtgThuoc.Rows.Count)
            {
                txtMaThuoc.Text = dtgThuoc.Rows[viTri].Cells[0].Value.ToString();
                txtTenThuoc.Text = dtgThuoc.Rows[viTri].Cells[1].Value.ToString();
                txtXuatXu.Text = dtgThuoc.Rows[viTri].Cells[7].Value.ToString();
                txtCachDung.Text = dtgThuoc.Rows[viTri].Cells[6].Value.ToString();
                txtTLQD.Text = dtgThuoc.Rows[viTri].Cells[5].Value.ToString();
                cbLoaiThuoc.SelectedIndex = FindIndexOfLoaiThuoc(dtgThuoc.Rows[viTri].Cells[2].Value.ToString());
                cbDVT.SelectedValue = dtgThuoc.Rows[viTri].Cells[3].Value.ToString();
                cbDVQD.SelectedValue = dtgThuoc.Rows[viTri].Cells[4].Value.ToString();
            }
        }

        private int FindIndexOfLoaiThuoc(string s)
        {
            int i = 0;
            foreach (DataRow dr in dataLoaiThuoc.Rows)
            {
                if (s.Equals(dr[1].ToString()) == true)
                {
                    return i;
                }
                i++;
            }
            return 0;
        }

        private void btnXoaOnClick(object sender, EventArgs e)
        {
            if (viTri >= 0 && viTri < dtgThuoc.Rows.Count)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?"
                                    , "Thông báo"
                                    , MessageBoxButtons.OKCancel
                                    , MessageBoxIcon.Question)
                                    == DialogResult.OK)
                {
                    string maThuoc = txtMaThuoc.Text;
                    string qrXoa = "delete from THUOC where MATHUOC='" + maThuoc + "'";
                    _ketNoi.ThucHien(qrXoa);
                    LoadData();
                    MessageBox.Show("Xóa thanh công!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vị trí cần xóa không hợp lệ!"
                                    , "Thông báo"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
            }
        }
       
        private void btn_Import_Click(object sender, EventArgs e)
        {
            frmImortThuoc _frmImport = new frmImortThuoc();
            _frmImport._send = new frmImortThuoc.send(NhanData);
            _frmImport.ShowDialog();
        }

        private int LaySLThuoc()
        {
            string qr = "select count(MATHUOC) from THUOC";
            DataTable dt = _ketNoi.TaoBang(qr);
            return int.Parse(dt.Rows[0][0].ToString());
        }

        private void btnThemOnClick(object sender, EventArgs e)
        {
            string maThuoc = "T" + (LaySLThuoc() + 1);
            txtMaThuoc.Text = maThuoc;
            string tenThuoc = txtTenThuoc.Text;
            string loaiThuoc = cbLoaiThuoc.SelectedValue.ToString();
            string donViTinh = cbDVT.SelectedValue.ToString();
            string donVIQuyDoi = cbDVQD.SelectedValue.ToString();
            string tyLeQuyDoi = txtTLQD.Text;
            string cachDung = txtCachDung.Text;
            string xuatXu = txtXuatXu.Text;
            if (tenThuoc == "" || tyLeQuyDoi == "")
            {
                MessageBox.Show("Bạn không được để các trường có dấu * trống!"
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
            }
            else
            {
                string qr = "insert into THUOC values ('" + maThuoc + "',N'" + tenThuoc + "','" + loaiThuoc + "'";
                qr += ",'" + donViTinh + "','" + donVIQuyDoi + "','" + tyLeQuyDoi + "',N'" + cachDung + "',N'" + xuatXu + "')";
                _ketNoi.ThucHien(qr);
                LoadData();
                MessageBox.Show("Thêm mới thành công!"
                               , "Thông báo"
                               , MessageBoxButtons.OK
                               , MessageBoxIcon.Information);

            }
        }

        private void _btnSua_Click(object sender, EventArgs e)
        {
            string maThuoc = txtMaThuoc.Text;
            string tenThuoc = txtTenThuoc.Text;
            string loaiThuoc = cbLoaiThuoc.SelectedValue.ToString();
            string donViTinh = cbDVT.SelectedValue.ToString();
            string donVIQuyDoi = cbDVQD.SelectedValue.ToString();
            string tyLeQuyDoi = txtTLQD.Text;
            string cachDung = txtCachDung.Text;
            string xuatXu = txtXuatXu.Text;
            if (tenThuoc == "" || tyLeQuyDoi == "")
            {
                MessageBox.Show("Bạn không được để các trường có dấu * trống!"
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
            }
            else
            {
                string qr = "update THUOC set TENTHUOC=N'"+tenThuoc+"',MALOAITHUOC='"+loaiThuoc+"',DONVITINH='"+donViTinh+"'";
                qr += ",DONVIQUYDOI='"+donVIQuyDoi+"',TYLEQUYDOI='"+tyLeQuyDoi+"',CACHSUDUNG=N'"+cachDung+"',XUATXU=N'"+xuatXu+"'";
                qr += " where MATHUOC='"+maThuoc+"'";
                _ketNoi.ThucHien(qr);
                LoadData();
                MessageBox.Show("Sửa thành công!"
                               , "Thông báo"
                               , MessageBoxButtons.OK
                               , MessageBoxIcon.Information);
            }
        }
    }
}
