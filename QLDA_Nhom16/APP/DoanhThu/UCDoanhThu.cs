using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class UCDoanhThu : UserControl
    {
        public UCDoanhThu()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        KetNoi _ketnoi = new KetNoi();
        private double lai;
        private void UCDoanhThu_Load(object sender, EventArgs e)
        {
            string querry = "SELECT NHANVIEN.MANHANVIEN MANHANVIEN, NHANVIEN.HOTEN HOTEN, HOADON.NGAYLAP NGAYLAP,CTHOADON.MATHUOC MATHUOC, THUOC.TENTHUOC TENTHUOC, CTHOADON.DONGIA DONGIABAN, ";
            querry += "CTHOADON.SOLUONG SOLUONGBAN, CTPHIEUNHAP.DONGIA DONGIANHAP from THUOC, CTHOADON, CTPHIEUNHAP, NHANVIEN, HOADON where THUOC.MATHUOC=CTHOADON.MATHUOC";
            querry += " and CTHOADON.MATHUOC=CTPHIEUNHAP.MATHUOC AND HOADON.MANHANVIEN=NHANVIEN.MANHANVIEN AND CTHOADON.SOHOADON=HOADON.SOHOADON;";
            DataTable DoanhThu = _ketnoi.TaoBang(querry);
            dataDoanhThu.DataSource = DoanhThu;
            string sumnhap = "SELECT Sum(CTHOADON.SOLUONG) SOLUONG, SUM(CTHOADON.DONGIA) DONGIABAN, SUM( CTPHIEUNHAP.DONGIA) DONGIANHAP ";
            sumnhap += " FROM THUOC, CTHOADON, CTPHIEUNHAP WHERE THUOC.MATHUOC=CTHOADON.MATHUOC  and CTHOADON.MATHUOC=CTPHIEUNHAP.MATHUOC";
            DataTable sumsql = _ketnoi.TaoBang(sumnhap);
            cbtongnhap.DataSource = sumsql;
            cbtongnhap.DisplayMember = "DONGIANHAP";
            cbTongxuat.DataSource = sumsql;
            cbTongxuat.DisplayMember = "DONGIABAN";
            cbSL.DataSource = sumsql;
            cbSL.DisplayMember = "SOLUONG";
            //double nhap = double.Parse(cbtongnhap.Text);
            //double xuat = double.Parse(cbTongxuat.Text);
            //double sl = double.Parse(cbSL.Text);
            //lai = (xuat - nhap) * sl;
            //cbLai.Text = lai.ToString();
        }

       
        int SL = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataDoanhThu.RowCount-1; i++)
            {
                    SL += int.Parse(dataDoanhThu.Rows[i].Cells[5].Value.ToString());
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            
            string querry = "SELECT NHANVIEN.MANHANVIEN MANHANVIEN, NHANVIEN.HOTEN HOTEN, CTHOADON.MATHUOC MATHUOC, THUOC.TENTHUOC TENTHUOC, CTHOADON.DONGIA DONGIABAN, CTHOADON.SOLUONG SOLUONGBAN,";
            querry += " CTPHIEUNHAP.DONGIA DONGIANHAP, HOADON.NGAYLAP NGAYLAP FROM THUOC, CTHOADON, CTPHIEUNHAP, NHANVIEN, HOADON WHERE THUOC.MATHUOC=CTHOADON.MATHUOC and CTHOADON.MATHUOC=CTPHIEUNHAP.MATHUOC AND";
            querry += "   HOADON.MANHANVIEN=NHANVIEN.MANHANVIEN AND CTHOADON.SOHOADON=HOADON.SOHOADON and HOADON.SOHOADON=CTHOADON.SOHOADON and HOADON.NGAYLAP BETWEEN '" + dateFrom.Value.ToShortDateString() + "' and '" + dateTo.Value.ToShortDateString() + "'";
            DataTable DoanhThu = _ketnoi.TaoBang(querry);
            dataDoanhThu.DataSource = DoanhThu;

            string sumnhap = "SELECT Sum(CTHOADON.SOLUONG) SOLUONG, Sum(CTHOADON.DONGIA) DONGIABAN, Sum( CTPHIEUNHAP.DONGIA) DONGIANHAP ";
            sumnhap += " FROM THUOC, CTHOADON, CTPHIEUNHAP, HOADON WHERE THUOC.MATHUOC=CTHOADON.MATHUOC  and CTHOADON.MATHUOC=CTPHIEUNHAP.MATHUOC and HOADON.SOHOADON=CTHOADON.SOHOADON and HOADON.NGAYLAP BETWEEN '" + dateFrom.Value.ToShortDateString() + "' and '" + dateTo.Value.ToShortDateString() + "'";
            DataTable sumsql = _ketnoi.TaoBang(sumnhap);
            cbtongnhap.DataSource = sumsql;
            cbtongnhap.DisplayMember = "DONGIANHAP";
            cbTongxuat.DataSource = sumsql;
            cbTongxuat.DisplayMember = "DONGIABAN";
            cbSL.DataSource = sumsql;
            cbSL.DisplayMember = "SOLUONG";
            //float nhap = float.Parse(cbtongnhap.Text);
            //float xuat = float.Parse(cbTongxuat.Text);
            //float sl = float.Parse(cbSL.Text);
            //lai = (xuat - nhap) * sl;
            //cbLai.Text = lai.ToString();
        }

        private void btnLocNgay_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked == true)
            {
                string querry = "SELECT NHANVIEN.MANHANVIEN MANHANVIEN, NHANVIEN.HOTEN HOTEN, CTHOADON.MATHUOC, THUOC.TENTHUOC, CTHOADON.DONGIA DONGIABAN, CTHOADON.SOLUONG SOLUONGBAN,";
                querry += " CTPHIEUNHAP.DONGIA DONGIANHAP, HOADON.NGAYLAP FROM THUOC, CTHOADON, CTPHIEUNHAP, HOADON,NHANVIEN ";
                querry += " WHERE THUOC.MATHUOC=CTHOADON.MATHUOC and CTHOADON.MATHUOC=CTPHIEUNHAP.MATHUOC and ";
                querry += "HOADON.SOHOADON=CTHOADON.SOHOADON and HOADON.NGAYLAP = (select getdate());";
                DataTable DoanhThu = _ketnoi.TaoBang(querry);
                dataDoanhThu.DataSource = DoanhThu;

                string sumnhap = "SELECT Sum(CTHOADON.SOLUONG) SOLUONG, Sum(CTHOADON.DONGIA) DONGIABAN, Sum( CTPHIEUNHAP.DONGIA) DONGIANHAP ";
                sumnhap += " FROM THUOC, CTHOADON, CTPHIEUNHAP, HOADON WHERE THUOC.MATHUOC=CTHOADON.MATHUOC  and CTHOADON.MATHUOC=CTPHIEUNHAP.MATHUOC and HOADON.SOHOADON=CTHOADON.SOHOADON and HOADON.NGAYLAP = (select getdate())";
                DataTable sumsql = _ketnoi.TaoBang(sumnhap);
                cbtongnhap.DataSource = sumsql;
                cbtongnhap.DisplayMember = "DONGIANHAP";
                cbTongxuat.DataSource = sumsql;
                cbTongxuat.DisplayMember = "DONGIABAN";
                cbSL.DataSource = sumsql;
                cbSL.DisplayMember = "SOLUONG";
                if (cbtongnhap.Text != "" && cbTongxuat.Text != "" && cbSL.Text != "")
                {
                    float nhap = float.Parse(cbtongnhap.Text);
                    float xuat = float.Parse(cbTongxuat.Text);
                    float sl = float.Parse(cbSL.Text);
                    lai = (xuat - nhap) * sl;
                    cbLai.Text = lai.ToString();
                }
                else { 
                    cbtongnhap.Text = "";
                    cbTongxuat.Text = "";
                    cbSL.Text = "";
                    cbLai.Text = "";
                }
            }
            else if(radThang.Checked){
                string querry = "SELECT CTHOADON.MATHUOC, THUOC.TENTHUOC, CTHOADON.DONGIA DONGIABAN, CTHOADON.SOLUONG SOLUONGBAN ,";
                querry += " CTPHIEUNHAP.DONGIA DONGIANHAP, HOADON.NGAYLAP FROM THUOC, CTHOADON, CTPHIEUNHAP, HOADON ";
                querry += " WHERE THUOC.MATHUOC=CTHOADON.MATHUOC and CTHOADON.MATHUOC=CTPHIEUNHAP.MATHUOC and ";
                querry += "HOADON.SOHOADON=CTHOADON.SOHOADON and HOADON.NGAYLAP BETWEEN (SELECT CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(GETDATE())-1),GETDATE()),101)) and (SELECT CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,1,GETDATE()))),DATEADD(mm,1,GETDATE())),101)) ;";
                DataTable DoanhThu = _ketnoi.TaoBang(querry);
                dataDoanhThu.DataSource = DoanhThu;

                string sumnhap = "SELECT Sum(CTHOADON.SOLUONG) SOLUONGBAN, Sum(CTHOADON.DONGIA) DONGIABAN, Sum( CTPHIEUNHAP.DONGIA) DONGIANHAP ";
                sumnhap += " FROM THUOC, CTHOADON, CTPHIEUNHAP, HOADON WHERE THUOC.MATHUOC=CTHOADON.MATHUOC  and CTHOADON.MATHUOC=CTPHIEUNHAP.MATHUOC and HOADON.SOHOADON=CTHOADON.SOHOADON and HOADON.NGAYLAP = (select getdate())";
                DataTable sumsql = _ketnoi.TaoBang(sumnhap);
                cbtongnhap.DataSource = sumsql;
                cbtongnhap.DisplayMember = "DONGIANHAP";
                cbTongxuat.DataSource = sumsql;
                cbTongxuat.DisplayMember = "DONGIABAN";
                cbSL.DataSource = sumsql;
                cbSL.DisplayMember = "SOLUONGBAN";
                if (cbtongnhap.Text != "" && cbTongxuat.Text != "" && cbSL.Text != "")
                {
                    float nhap = float.Parse(cbtongnhap.Text);
                    float xuat = float.Parse(cbTongxuat.Text);
                    float sl = float.Parse(cbSL.Text);
                    lai = (xuat - nhap) * sl;
                    cbLai.Text = lai.ToString();
                }
                else
                {
                    cbtongnhap.Text = "";
                    cbTongxuat.Text = "";
                    cbSL.Text = "";
                    cbLai.Text = "";
                }
            }
            else if(radNam.Checked){
                string querry = "SELECT CTHOADON.MATHUOC, THUOC.TENTHUOC, CTHOADON.DONGIA dongiaban, CTHOADON.SOLUONG ,";
                querry += " CTPHIEUNHAP.DONGIA dongianhap, HOADON.NGAYLAP FROM THUOC, CTHOADON, CTPHIEUNHAP, HOADON ";
                querry += " WHERE THUOC.MATHUOC=CTHOADON.MATHUOC and CTHOADON.MATHUOC=CTPHIEUNHAP.MATHUOC and ";
                querry += "HOADON.SOHOADON=CTHOADON.SOHOADON and HOADON.NGAYLAP BETWEEN (SELECT CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(GETDATE())-1),GETDATE()),101)) and (SELECT CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,1,GETDATE()))),DATEADD(mm,1,GETDATE())),101)) ;";
                DataTable DoanhThu = _ketnoi.TaoBang(querry);
                dataDoanhThu.DataSource = DoanhThu;

                string sumnhap = "SELECT Sum(CTHOADON.SOLUONG) SOLUONG, Sum(CTHOADON.DONGIA) DONGIABAN, Sum( CTPHIEUNHAP.DONGIA) DONGIANHAP ";
                sumnhap += " FROM THUOC, CTHOADON, CTPHIEUNHAP, HOADON WHERE THUOC.MATHUOC=CTHOADON.MATHUOC  and CTHOADON.MATHUOC=CTPHIEUNHAP.MATHUOC and HOADON.SOHOADON=CTHOADON.SOHOADON and HOADON.NGAYLAP = (select getdate())";
                DataTable sumsql = _ketnoi.TaoBang(sumnhap);
                cbtongnhap.DataSource = sumsql;
                cbtongnhap.DisplayMember = "DONGIANHAP";
                cbTongxuat.DataSource = sumsql;
                cbTongxuat.DisplayMember = "DONGIABAN";
                cbSL.DataSource = sumsql;
                cbSL.DisplayMember = "SOLUONG";
                if (cbtongnhap.Text != "" && cbTongxuat.Text != "" && cbSL.Text != "")
                {
                    float nhap = float.Parse(cbtongnhap.Text);
                    float xuat = float.Parse(cbTongxuat.Text);
                    float sl = float.Parse(cbSL.Text);
                    lai = (xuat - nhap) * sl;
                    cbLai.Text = lai.ToString();
                }
                else
                {
                    cbtongnhap.Text = "";
                    cbTongxuat.Text = "";
                    cbSL.Text = "";
                    cbLai.Text = "";
                }
            }
        }
    }
}
