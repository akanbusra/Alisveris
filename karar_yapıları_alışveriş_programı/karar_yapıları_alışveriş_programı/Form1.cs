using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karar_yapıları_alışveriş_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet;
            double toplam;

            adet = Convert.ToInt32(textBox1.Text);

            if (adet>0 && adet<=20)
            {
                toplam = (adet * 8) - (adet * 8 * 0.20);
                label3.Text = toplam.ToString();
            }
            if (adet>20 && adet<=40)
            {
                toplam = (adet * 8) - (adet * 8 * 0.40);
                label3.Text = toplam.ToString();
            }
            if (adet>=41)
            {
                toplam = (adet * 8) - (adet * 8 * 0.50);
                label3.Text = toplam.ToString();
            }

        }
    }
}
