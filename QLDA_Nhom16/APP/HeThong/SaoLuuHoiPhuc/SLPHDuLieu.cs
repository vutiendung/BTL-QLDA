using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class SLPHDuLieu : Form
    {
        public SLPHDuLieu()
        {
            InitializeComponent();
        }  
        private void txtSaoluu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtSaoluu.Text = dlg.SelectedPath;
            }
        }
        KetNoi kn = new KetNoi();
        private void btn_OK_Click(object sender, EventArgs e)
        {
            btn_OK.Enabled = false;
            if (radioButton1.Checked)
            {
                groupBox1.Enabled = true;
                try
                {
                    if (txtSaoluu.Text.CompareTo("") == 0)
                    {
                        MessageBox.Show("Vui lòng chọn cơ sở dữ liệu hoặc đường dẫn", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                   
                    string sql = "BACKUP DATABASE QUANLYBANTHUOC TO DISK = '" + txtSaoluu.Text + "\\" + "QUANLYBANTHUOC" + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
                    kn.ThucHien(sql);
                    MessageBox.Show("Sao luu thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSaoluu.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Co loi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radPhuchoi.Checked)
            {
                try
                {
                    if (txtPhuchoi.Text.CompareTo("") == 0)
                    {
                        MessageBox.Show("Vui lòng chọn đường dẫn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string sql = "ALTER DATABASE QUANLYBANTHUOC SET SINGLE_USER WITH ROLLBACK IMMEDIATE ";
                           sql += "RESTORE DATABASE QUANLYBANTHUOC FROM DISK = '" + txtPhuchoi.Text + "' WITH REPLACE";
                    kn.ThucHien(sql);
                    MessageBox.Show("Thành công");
                    txtPhuchoi.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            btn_OK.Enabled = true;
        }
        private string _fileName;
        private void txtPhuchoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "Backup Files(*.bak)|*.bak|All File(*.*)|*.*";
            openFileDlg.FilterIndex = 0;
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                _fileName = openFileDlg.FileName;
                txtPhuchoi.Text = _fileName;
            }
        }

        private void SLPHDuLieu_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btn_OK.Text = "Sao lưu";
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void radPhuchoi_CheckedChanged(object sender, EventArgs e)
        {
            btn_OK.Text = "Phục hồi";
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void btn_KetThuc_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
