using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace BTL_HCG
{
    public partial class Form_User : Form
    {
        TreeNode node;
        Validation vd;
        string id1String = "", id2String = "", id3String = "";
        float x1 = 0, x2 = 0, x3 = 0;
        public Form_User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DataTable dt = null;
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cmbTenSheet.Items.Clear();
                string strFileName = openFileDialog1.FileName;
                txtTenFile.Text = strFileName;
                NapDLVaoCombobox();
            }
        }


        private void NapDLVaoCombobox()
        {
            string[] tblNames = MoFileExcel.getTableName(txtTenFile.Text);
            foreach (string s in tblNames)
            {
                cmbTenSheet.Items.Add(s);
            }
        }

        private void cmbTenSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenSheet.Text != 0.ToString())
            {
                dt = MoFileExcel.GetDatasetFromExcel(txtTenFile.Text, cmbTenSheet.Text);
                dgvDuLieu.DataSource = dt;
                dgvDuLieu.Refresh();
            }
        }
        //tao bien kNN va ANN
        DST_kNN kNN;
        DST_ANN ANN;
        DST_ID3 dST_iD3;
        //tao luong thread
        Thread t;
        //Nút huấn luyện
        private void btnHuanLuyen_Click(object sender, EventArgs e)
        {
            if (dt == null) // nếu data=null, Chưa nạp file
            {
                btnBrowser.PerformClick();
            }
            else
            {
                int soDong = dt.Rows.Count;
                double[,] dlVao = new double[soDong, 3];
                double[] dlRa = new double[soDong];
                double[,] dlVaoID3 = new double[soDong, 3];
                double[] dlRaID3 = new double[soDong];
                for (int i = 0; i < soDong; i++)
                {
                    dlVao[i, 0] = double.Parse(dt.Rows[i][2].ToString()) / 200;
                    dlVao[i, 1] = double.Parse(dt.Rows[i][3].ToString()) / 100;
                    dlVao[i, 2] = double.Parse(dt.Rows[i][4].ToString()) / 500;

                    dlRa[i] = double.Parse(dt.Rows[i][5].ToString()) / 100;


                    dlVaoID3[i, 0] = double.Parse(dt.Rows[i][2].ToString());
                    dlVaoID3[i, 1] = double.Parse(dt.Rows[i][3].ToString());
                    dlVaoID3[i, 2] = double.Parse(dt.Rows[i][4].ToString());

                    dlRaID3[i] = double.Parse(dt.Rows[i][5].ToString());
                }

                if (rdANN.Checked)
                {
                    ANN = new DST_ANN();
                    ANN.thietLap_TocDoHoc(0.5);
                    ANN.thietLapMoment(0.2);
                    ANN.ann_set_lr_changing_factor(0.1);
                    ANN.setDoDoc(0.5);
                    ANN.setPhuongThuc_KhoiTaoTrongSo(INIT_METHODs.NGUYEN, 10.0);
                    ANN.createNetwork(3, 1, 1, 10);

                    //Thiết lập thông số mạng nơ-ron
                    ANN.SetTrainData(dlVao, dlRa, 100000, 0.00001);

                    t = new Thread(new ThreadStart(ANN.Train));
                    t.Start();
                    timer1.Enabled = true;
                }
                else if (rdKNN.Checked)
                {
                    kNN = new DST_kNN(new MaTran(dlVao), dlRa, 5);
                    kNN.HuanLuyen(new MaTran(dlVao), dlRa);
                    MessageBox.Show("Huấn luyện thành công");
                    kNN.Save("knn.txt");
                    btnDuBao.Enabled = true;
                }
                else
                {
                    dST_iD3 = new DST_ID3(new MaTran(dlVaoID3), dlRaID3);
                    MessageBox.Show("Huấn luyện thành công");
                    dST_iD3.kiemTraMoHoa("moHoaDuLieu.txt");
                   
                    btnDuBao.Enabled = true;
                }
            }
        }

        private void btnDuBao_Click(object sender, EventArgs e)
        {
            if (ANN != null)
            {
                convertTextToNumber();
                double[] dlInput = new double[3];
                dlInput[0] = x1 / 200; dlInput[1] = x2 / 100; dlInput[2] = x3 / 500;
                double duDoan = 0;

                double[] kq = ANN.Predict(new double[][] { dlInput });
                duDoan = kq[0] * 100;

                lblNhietDo.Text = duDoan.ToString();

            }
            else if (kNN != null)
            {
                convertTextToNumber();
                double[] dlInput = new double[3];
                dlInput[0] = x1 / 200; dlInput[1] = x2 / 100; dlInput[2] = x3 / 500;
                double duDoan = 0;

                duDoan = kNN.DuDoan(dlInput) * 100;
                lblNhietDo.Text = duDoan.ToString();
            }
            else if (dST_iD3 != null)
            {
                vd = new Validation();
                //vd.dataTest();
                vd.K_fold();
                node = vd.id3.getTreeNode();
                moHoaID3();
                int inp = 0;//Console.ReadLine();
                while (inp<3)
                {
                    DecisionTree.askQuestion(node,id1String,id2String,id3String,inp);
                    //Console.Write("Test set : (yes/no)? ");
                    inp ++;
                }
                lblNhietDo.Text = DecisionTree.result;
            }
        }

        private void moHoaID3()
        {
            convertTextToNumber();
            if (x1 < 120) id1String = "small";
            else if (x1 >= 120 && x1 < 160) id1String = "normal";
            else if (x1 >= 160) id1String = "big";

            if (x2 < 50) id2String = "thap";
            else if (x2 >= 50 && x2< 70) id2String = "tb";
            else if (x2 >= 70) id2String = "cao";

            if (x3 < 100) id3String = "nho";
            else if (x3 >= 100 && x3 < 200) id3String = "vua";
            else if (x3 >= 200 && x3 < 300) id3String = "to";
            else if (x3 >= 300) id3String = "ratto";

        }
        private void convertTextToNumber()
        {
            x1 = float.Parse(txtGioNang.Text.ToString());
            x2 = float.Parse(txtDoAm.Text.ToString());
            x3 = float.Parse(txtLuongMua.Text.ToString());
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaiSo.Text = ANN.m_LoiTrungBinh.ToString();
            lblSoVongLap.Text = ANN.m_Iteraton.ToString();
            if (ANN.trainComplete)
            {
                timer1.Enabled = false;
                btnDuBao.Enabled = true;
                MessageBox.Show("Train thành công!");
            }
        }

        private void rdANN_CheckedChanged(object sender, EventArgs e)
        {
            lblNhietDo.Text = 0.ToString();
            lblSoVongLap.Text = 0.ToString();
            lblSaiSo.Text = 0.ToString();
        }

        private void rdKNN_CheckedChanged(object sender, EventArgs e)
        {
            lblNhietDo.Text = 0.ToString();
            lblSoVongLap.Text = 0.ToString();
            lblSaiSo.Text = 0.0.ToString();
        }

        private void dgvDuLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void id3_CheckedChanged(object sender, EventArgs e)
        {
            lblNhietDo.Text = 0.ToString();
            lblSoVongLap.Text = 0.ToString();
            lblSaiSo.Text = 0.0.ToString();
        }
    }

}
