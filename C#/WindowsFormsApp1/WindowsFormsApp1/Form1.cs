using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void amounttextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount = 0;
            double.TryParse(amounttextbox.Text, out amount);
            feetextbox.Text = (amount * 0.03).ToString("c2");
            if (amount > 500)
                this.BackColor = Color.Red;
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clear()
        {
            nametextbox.Clear(); 
            cctextbox.Clear();
            exptextbox.Clear(); 
            ziptextbox.Clear(); 
            ccvtextbox.Clear(); 
            amounttextbox.Clear();
        }
        }
}
