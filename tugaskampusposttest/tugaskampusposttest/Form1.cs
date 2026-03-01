using System;
using System.Collections.Generic;
using System.Linq; 
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tugaskampusposttest
{
    public partial class Form1 : Form
    {

        List<double> daftarIP = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnTambah_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out double ipInput))
            {

                if (ipInput >= 0 && ipInput <= 4.0)
                {

                    daftarIP.Add(ipInput);


                    double ipk = daftarIP.Average();


                    lblIPK.Text = "IPK Kumulatif: " + ipk.ToString("0.00");


                    if (ipk >= 3.01)
                        lblPredikat.Text = "Predikat: Sangat Memuaskan";
                    else if (ipk >= 2.76)
                        lblPredikat.Text = "Predikat: Memuaskan";
                    else if (ipk >= 2.00)
                        lblPredikat.Text = "Predikat: Cukup";
                    else
                        lblPredikat.Text = "Predikat: Kurang";


                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Masukkan nilai IP antara 0.00 sampai 4.00!");
                }
            }
            else
            {
                MessageBox.Show("Tolong masukkan angka yang valid!");
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {

            daftarIP.Clear();


            lblIPK.Text = "IPK Kumulatif: 0.00";
            lblPredikat.Text = "Predikat: -";
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double ipInput))
            {

                if (ipInput >= 0 && ipInput <= 4.0)
                {

                    daftarIP.Add(ipInput);


                    double ipk = daftarIP.Average();


                    lblIPK.Text = "IPK: " + ipk.ToString("0.00");


                    if (ipk >= 3.01) lblPredikat.Text = "Predikat: Sangat Memuaskan";
                    else if (ipk >= 2.76) lblPredikat.Text = "Predikat: Memuaskan";
                    else if (ipk >= 2.00) lblPredikat.Text = "Predikat: Cukup";
                    else lblPredikat.Text = "Predikat: Kurang";


                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Masukkan angka IP antara 0 - 4 ya!");
                }
            }
            else
            {
                MessageBox.Show("Tolong masukkan angka yang valid!");
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

            daftarIP.Clear();


            lblIPK.Text = "IPK: 0.00";
            lblPredikat.Text = "Predikat: -";


            textBox1.Clear();


            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}