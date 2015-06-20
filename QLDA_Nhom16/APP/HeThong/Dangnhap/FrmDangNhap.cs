using System;
using System.Windows.Forms;
using WindowsFormsApplication2.APP.SplashScreen;
using System.Data;
namespace WindowsFormsApplication2
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            _txtusername.Text = Properties.Settings.Default.user;
            _txtpass.Text = Properties.Settings.Default.pass;
        }

        static int dem=0;
        private void _btnLogin_Click(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            DTO_TaiKhoan tk = new DTO_TaiKhoan();
           

            try {
                tk.UserName = _txtusername.Text.Trim();
                tk.Pass = _txtpass.Text.Trim();
                if(_txtusername.Text=="" || _txtpass.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập đầy đủ thông tin","Thông báo",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    _txtusername.Focus();
                }
                else
                {
                    string sql = "Select * from NHANVIEN where MANHANVIEN ='" + tk.UserName + "'";
                    DataTable dt = kn.TaoBang(sql);
                    if (dt.Rows.Count != 0)
                    {
                        if (dt.Rows[0][0].ToString() == tk.Pass)
                        {
                            SplashScreen SplashScreen = new SplashScreen();
                            SplashScreen.Show();
                            this.Hide();
                            string sql1 = "SELECT MOTA FROM NHANVIEN, CHUCVU WHERE CHUCVU.MACHUCVU = NHANVIEN.MACHUCVU AND MANHANVIEN = '" + _txtusername.Text + "'";
                            FrmMain.quyen = kn.TaoBang(sql1).Rows[0][0].ToString().Trim();
                            FrmMain.maNV = _txtusername.Text;
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu sai! vui lòng kiểm tra lại"
                                            ,"Thông báo"
                                            ,MessageBoxButtons.OK
                                            ,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu, vui lòng đăng nhập lại!","Thông báo");
                        dem++;
                        
                    }
                    if (dem == 3)
                    {
                        MessageBox.Show("Bạn đã đăng nhập quá số lần quy định, vui lòng liên hệ với quản trị viên để được cấp lại mật khẩu!",
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                
            } catch(Exception ex) {
                MessageBox.Show(ex.Message,"Thông báo", MessageBoxButtons.OK);
            }
            if (_checkRemember.Checked)
            {
                Properties.Settings.Default.user = _txtusername.Text;
                Properties.Settings.Default.pass = _txtpass.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.user = "";
                Properties.Settings.Default.pass = "";
                Properties.Settings.Default.Save();
            }
        }
        private void _linkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Nếu bạn quên mật khẩu đăng nhập, vui lòng liên lạc với quản trị viên để được cấp lại hoặc liên hệ số điện thoại 0966191994","Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void _btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
