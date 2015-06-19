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
    public partial class frmImortThuoc : Form
    {
        private KetNoi _ketNoi = new KetNoi();
        private MoFileExcel _openExel = new MoFileExcel();
        private string _fileName = "";
        public delegate void send(bool change = false);
        public send _send;
        private bool run = false;
        private DataTable binThuoc;
        private DataTable binThuocThem;
        List<string> nameThuoc = new List<string>();
        Dictionary<string, string> ListDonViTinh=new Dictionary<string,string>();
        Dictionary<string, string> ListLoaiThuoc = new Dictionary<string, string>();
        public frmImortThuoc()
        {
            InitializeComponent();
        }

        public void txtPatch_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.Filter = "Excel 2007 (*.xls)|*.xls|Laster version (*.xlsx*)|*.xlsx*";
            _openFileDialog.Title = "Chọn  file Exel cần nhập";
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _fileName = _openFileDialog.FileName;
                txtPatch.ForeColor = Color.Black;
                txtPatch.Text = _fileName;
                string[] tblNames = MoFileExcel.getTableName(_fileName);
                foreach (string s in tblNames)
                {
                    cbTenSheet.Items.Add(s);
                }
                cbTenSheet.SelectedItem = tblNames[0];
            }
        }

        private bool KTTonTaiThuoc(string tenThuoc)
        {
            return nameThuoc.Contains(tenThuoc);
        }

        private string LayMaLoaiThuoc(string moTaLoaiThuoc)
        {
            foreach (var s in ListLoaiThuoc)
            {
                if (s.Value.Contains(moTaLoaiThuoc))
                {
                    return s.Key.ToString();
                }
            }
            return "";
        }

        private string LayMaDonVi(string moTaDonViTinh)
        {
            foreach (var s in ListDonViTinh)
            {
                if (s.Value.Contains(moTaDonViTinh))
                {
                    return s.Key.ToString();
                }
            }
            return "";
        }

        private void XoaTruocKhiNhap()
        {
            string qr = "delete from Thuoc";
            _ketNoi.ThucHien(qr);
            this._send(true);
        }

        private int LaySoLuong()
        {
            return (binThuoc.Rows.Count + nameThuoc.Count);

        }

        private string XoaKyTuDacBiet(string s)
        {
            int i = 0;
            int sl = s.Length;
            while (i < sl)
            {
                if (s[i] == '%' || s[i] == '/' || s[i] == '-' || s[i] == '.' || s[i] == '+')
                    s.Remove(i, 1);
                i++;

            }
            return s;
        }

        private void btnNhapOnClick(object sender, EventArgs e)
        {
            AddNameToList();
            binThuocThem = null;
            binThuocThem = new DataTable();
            binThuocThem = binThuoc.Clone();
            lblNanemProgess.Text = "Đang kiểm tra tính hợp lệ của dữ liệu ...";
            if (run)
            {
                run = false;
                btnNhap.Text = "Bắt đầu nhập";
            }
            else
            {
                run = true;
                btnNhap.Text = "Dừng nhập";
            }

            if (_fileName != "" && _fileName != "Click để chọn File")
            {
                while (run)
                {
                    if (checkDeleteall.Checked == true)
                    {
                        XoaTruocKhiNhap();
                    }
                    DataTable dataThuoc = MoFileExcel.GetDatasetFromExcel(_fileName, cbTenSheet.Text);
                    if (dataThuoc.Rows.Count > 0)
                    {
                        progressBar.Minimum = 1;
                        progressBar.Maximum = dataThuoc.Rows.Count;
                        int i = 0;
                        int sl = dataThuoc.Rows.Count;
                        int demLoi = 0;
                        bool error = false;
                        label4.Visible = true;
                        while (dataThuoc.Rows.Count>0)
                        {

                            string erroString = "Lỗi dòng " + i + " ";
                            error = false;
                            string maThuoc = "T" + (LaySoLuong() + 1);
                            string tenThuoc =dataThuoc.Rows[0][0].ToString();
                            string maLoaiThuoc = LayMaLoaiThuoc(dataThuoc.Rows[0][1].ToString());
                            string maDonVi = LayMaDonVi(dataThuoc.Rows[0][3].ToString());
                            string maTLQD = LayMaDonVi(dataThuoc.Rows[0][4].ToString());
                            string cachSuDung = "  --";
                            string xuatXu = dataThuoc.Rows[0][8].ToString();
                            int tLQD = int.Parse(dataThuoc.Rows[0][5].ToString());
                            dataThuoc.Rows.RemoveAt(0);

                            //
                            if (KTTonTaiThuoc(tenThuoc) == true)
                            {
                                error = true;
                                erroString += "-Thuốc đã tồn tại";
                            }
                            if (maLoaiThuoc == "")
                            {
                                error = true;
                                erroString += "-Không có thông tin vê loại thuốc";
                            }
                            if (maDonVi == "")
                            {
                                error = true;
                                erroString += "-Không có thông tin vê đơn vị tính";
                            }
                            if (maThuoc == "")
                            {
                                error = true;
                                erroString += "-Không có thông tin về đơn vị quy đổi";
                            }
                            if (error == true)
                            {
                                erroString += "\n";
                                rtxtErrorInfor.Text += erroString;
                                demLoi++;
                                lblError.Text = demLoi.ToString();
                            }
                            else
                            {
                                binThuocThem.Rows.Add(new Object[8]{maThuoc,tenThuoc,maLoaiThuoc,maDonVi,maTLQD,tLQD,cachSuDung,xuatXu});

                                nameThuoc.Add(tenThuoc);
                            }
                            //

                            i++;
                            lblProgess.Text = i + "/" + sl;
                            progressBar.Value = i;
                            SendKeys.Flush();
                            if (!run)
                            {
                                this._send(true);
                                break;
                            }
                            if (i == sl)
                            {
                                btnNhap.Text = "Nhập lại";
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("File rỗng!"
                                , "Thông báo"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                    }
                    //them thuoc vao csdl
                    if (binThuocThem.Rows.Count > 0)
                    {
                        lblError.Text = "";
                        label4.Visible = false;
                        int sl = binThuocThem.Rows.Count;
                        lblNanemProgess.Text = "Import dữ liệu vào CSDL ...";
                        progressBar.Maximum = binThuocThem.Rows.Count;
                        progressBar.Minimum = 0;
                        int ii = 0;
                        string qr = "";
                        lblProgess.Text = ii + "/" + sl;
                        foreach (DataRow dr in binThuocThem.Rows)
                        {
                            qr = "insert into THUOC values('" + dr[0].ToString() + "','" + dr[1].ToString() + "','" + dr[2].ToString() + "','" + dr[3].ToString() + "','" + dr[4].ToString() + "','" + dr[5].ToString() + "','" + dr[6].ToString() + "','" + dr[7].ToString() + "')";
                            _ketNoi.ThucHien(qr);
                            qr = "";
                            ii++;
                            lblProgess.Text = ii + "/" + sl;
                            progressBar.Value = ii;
                            SendKeys.Flush();
                        }
                        run = false;
                        this._send(true);
                        lblNanemProgess.Text = "Xong!";
                        MessageBox.Show("Import thanh cong!!"
                               , "Thông báo"
                               , MessageBoxButtons.OK
                               , MessageBoxIcon.Information);
                    }

                }
            }
            else
                MessageBox.Show("Bạn cần chọn file để nhập"
                        , "Thông báo"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
            
            
        }
        private void AddNameToList()
        {
            nameThuoc = null;
            nameThuoc = new List<string>();
            string qr2 = "select * from THUOC";
            DataTable dt2 = _ketNoi.TaoBang(qr2);
            binThuoc = dt2;
            foreach (DataRow dr in dt2.Rows)
            {
                if (nameThuoc.Contains(dr[1].ToString()) == false)
                {
                    nameThuoc.Add(dr[1].ToString());
                }
            }
        }
        private void frmImortThuoc_Load(object sender, EventArgs e)
        {
            string qr = "select *from DONVITINH";
            DataTable dt = _ketNoi.TaoBang(qr);
            foreach (DataRow dr in dt.Rows)
            {
                if (ListDonViTinh.ContainsKey(dr[0].ToString()) == false)
                {
                    ListDonViTinh.Add(dr[0].ToString(),dr[1].ToString());
                }
            }

            string qr1 = "select *from LOAITHUOC";
            DataTable dt1 = _ketNoi.TaoBang(qr1);
            foreach (DataRow dr in dt1.Rows)
            {
                if (ListLoaiThuoc.ContainsKey(dr[0].ToString()) == false)
                {
                    ListLoaiThuoc.Add(dr[0].ToString(), dr[1].ToString());
                }
            }
            AddNameToList();
            
        }
    }
}
