using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.APP.Nhân_viên;
namespace WindowsFormsApplication2.APP.Nhân_viên
{
    public partial class UCNhanVien : UserControl
    {
        #region Khai báo
        private KetNoi _ketNoi = new KetNoi();
        private DataTable _nhanVien = new DataTable();
        private int viTri;
        #endregion

        public UCNhanVien()
        {
            InitializeComponent();
        }

        private void ClearRow()
        {
            while (dtgNhanVien.Rows.Count > 0)
            {
                dtgNhanVien.Rows.RemoveAt(0);
            }
        }

        private void NhanData(bool change) //cap nhật lại data khi có thay đổi
        {
            if (change)
            {
                LoadData();
            }
        }

        private string TaoMaNhanVienMoi()
        {
            return "NV" + (_nhanVien.Rows.Count + 1);
        }

        private void btnThemClick(object sender, EventArgs e)
        {
            PopupNhanvien nhanvien = new PopupNhanvien(TaoMaNhanVienMoi(),false);
            nhanvien._send = new PopupNhanvien.send(NhanData);
            nhanvien.ShowDialog();
        }

        private void LoadData()
        {
            ClearRow();
            string qr = "select MANHANVIEN,HOTEN,DIACHI,NGAYSINH,GIOITINH,SDT,EMAIL,MUCLUONG,MOTA";
            qr += " from NHANVIEN,CHUCVU WHERE NHANVIEN.MACHUCVU=CHUCVU.MACHUCVU";
            _nhanVien = _ketNoi.TaoBang(qr);
            dtgNhanVien.DataSource = _nhanVien;
        }

        private void NhanVienLoad(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
        }

        private void btnSuaOnClick(object sender, EventArgs e)
        {
            PopupNhanvien nhanvien = new PopupNhanvien(dtgNhanVien.Rows[viTri].Cells[0].Value.ToString(), true);
            nhanvien._send = new PopupNhanvien.send(NhanData);
            nhanvien.ShowDialog();
        }

        private void _btnXoa_Click(object sender, EventArgs e)
        {
            if (viTri < 0 || viTri >= dtgNhanVien.Rows.Count)
            {
                MessageBox.Show("Bạn chưa chọn vị trí cần xóa!"
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên " + dtgNhanVien.Rows[viTri].Cells[1].Value.ToString() + " không"
                                , "Thông báo"
                                , MessageBoxButtons.OKCancel
                                , MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string qr = "delete from NHANVIEN where MANHANVIEN='"+dtgNhanVien.Rows[viTri].Cells[0].Value.ToString()+"'";
                    _ketNoi.ThucHien(qr);
                    LoadData();
                    MessageBox.Show("Xóa thành công!"
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                    qr = null;
                }
            }
        }
    }
}
