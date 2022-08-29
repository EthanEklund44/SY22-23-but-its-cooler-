using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount = 0;
            double.TryParse(usdtextbox.Text, out amount);
            poundtextbox.Text = (amount * 0.85).ToString("");
            rubeetextbox.Text = (amount * 79.79).ToString("");
            eurotextbox.Text = (amount * 1).ToString("");
            franctextbox.Text = (amount * 0.97).ToString("");
            randtextbox.Text = (amount * 16.95).ToString("");
            bittextbox.Text = (amount * 0.000046).ToString("");
        }
    }
}
