using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int adet = 0;
            decimal deger = Convert.ToDecimal( textBox1.Text);

            for (int i = 2; i <= deger; i++)
            {
                int sayac = 0;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sayac++;
                    }
                }

                if (sayac == 0)
                {
                    listBox1.Items.Add(i);
                    adet++;
                }
                label1.Text = adet.ToString();
            }    }
    }
}
