using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac=0;
        private void button2_Click(object sender, EventArgs e)
        {
            
            lblsayac.Text = sayac.ToString();
            if (sayac < 10)
            {
                sayac++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblsayac.Text = "0";
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            
            lblsayac.Text=sayac.ToString();
            if (sayac> -10)
            {
                sayac--;
            }
        }
    }
}
