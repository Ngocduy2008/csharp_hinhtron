using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_hinhtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnchuvi_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            double chuvi = bankinh * 2 * Math.PI;
            lblketqua.Text = "- Chu vi " + Convert.ToString(chuvi);
        }

        private void btndientich_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            double dientich = bankinh * bankinh * Math.PI;
            lblketqua.Text = "- diện tich " + Convert.ToString(dientich);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbchuvi_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void btntn1_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            if (rdbchuvi.Checked)
            {
                double chuvi = bankinh * 2 *Math.PI;
                string thongbao = "- chu vi " + Convert.ToString((double)chuvi);
                MessageBox.Show(thongbao, "thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            if (rdbdientich.Checked)
            {
                double dientich = bankinh * bankinh * Math.PI;
                string thongbao = "- diện tích " + Convert.ToString((double)dientich);
                MessageBox.Show(thongbao, "thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

            }
        }
    }
    

