﻿using Final.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class UserControlTinhDiem : UserControl
    {
        public UserControlTinhDiem()
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = Image.FromFile("./Images/result.png");
        }

        private void UserControlTinhDiem_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ToHopMonDAO.Instance.GetListTHM();
            List<string> listTHM = new List<string>();
            foreach (DataRow d in dt.Rows)
            {
                listTHM.Add(d[0].ToString());
            }
            comboBoxSelect.Items.Clear();
            comboBoxSelect.DataSource = listTHM;
            comboBoxSelect.DisplayMember = "Name";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (comboBoxSelect.Text)
            {
                case "A00":
                    txbketqua.Text = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "A01": //tla
                    txbketqua.Text = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbAnhVan.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "A02": //tls
                    txbketqua.Text = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "B00": //ths
                    txbketqua.Text = (float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "B01": //tSinhsu
                    txbketqua.Text = (float.Parse(txbToan.Text) + float.Parse(txbSinh.Text) + float.Parse(txbSu.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "B02": //tsinhdia
                    txbketqua.Text = (float.Parse(txbToan.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDia.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "C00": //vansusia
                    txbketqua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbSu.Text) + float.Parse(txbDia.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "C01": //vantoanli
                    txbketqua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "C02": //vantoanhoa
                    txbketqua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "C03": //vantoansu
                    txbketqua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbSu.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "D01": //vantoananh
                    txbketqua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbAnhVan.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "D07": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbAnhVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "H00": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbHinhHoa.Text) + float.Parse(txbBoCuc.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T00": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbSinh.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T03": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbSinh.Text) + float.Parse(txbNguVan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T04": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbLy.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T05": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbGDCD.Text) + float.Parse(txbNguVan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
                case "T06": //toanhoaanh
                    txbketqua.Text = (float.Parse(txbDia.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
                    break;
            }
            
            txbA00.Text = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbA01.Text = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbAnhVan.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbA02.Text = (float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbB00.Text = (float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbB01.Text = (float.Parse(txbToan.Text) + float.Parse(txbSinh.Text) + float.Parse(txbSu.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbB02.Text = (float.Parse(txbToan.Text) + float.Parse(txbSinh.Text) + float.Parse(txbDia.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbC00.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbSu.Text) + float.Parse(txbDia.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbC01.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbLy.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbC02.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbC03.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbSu.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbD01.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbAnhVan.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbD07.Text = (float.Parse(txbAnhVan.Text) + float.Parse(txbToan.Text) + float.Parse(txbHoa.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbH00.Text = (float.Parse(txbNguVan.Text) + float.Parse(txbHinhHoa.Text) + float.Parse(txbBoCuc.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbT00.Text = (float.Parse(txbSinh.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbT03.Text = (float.Parse(txbSinh.Text) + float.Parse(txbNguVan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbT04.Text = (float.Parse(txbLy.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbT05.Text = (float.Parse(txbGDCD.Text) + float.Parse(txbNguVan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
            txbT06.Text = (float.Parse(txbDia.Text) + float.Parse(txbToan.Text) + float.Parse(txbNK.Text) + float.Parse(txbDiemCong.Text)).ToString();
        }
    }
}
