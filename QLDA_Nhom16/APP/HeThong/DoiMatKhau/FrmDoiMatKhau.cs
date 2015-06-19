using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2.APP
{
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();       
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (txtNewPass.Text == txtOldPass.Text)
                {
                    MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ, vui lòng nhập lại",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtNewPass.Text == txtConfim.Text)
                {
                    string sql = "update NHANVIEN set MATKHAU = '" + txtNewPass.Text + "' WHERE MANHANVIEN = '" + FrmMain.maNV + "'";
                    kn.ThucHien(sql);
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(txtConfim.Text!=txtNewPass.Text)
                {
                        MessageBox.Show("Xác nhận mật khẩu không trùng nhau",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
                {
                MessageBox.Show(ex.Message,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            
        }
    }
}
