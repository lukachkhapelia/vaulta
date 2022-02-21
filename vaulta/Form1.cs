using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vaulta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a, b;
        int c;
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            b =  this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
        }

       

        private void btn1_Click(object sender, EventArgs e)
        {
            c = int.Parse(txtinput.Text);
            if (a == "GEL" && b == "GEL")
            {
                txtoutput.Text = c.ToString();
            }
            if (a == "GEL" && b == "USD")
            {
                txtoutput.Text = (c / 3.14).ToString();
            }
            if (a == "GEL" && b == "EUR")
            {
                txtoutput.Text = (c / 4).ToString();
            }
            if (a == "GEL" && b == "YAN")
            {
                txtoutput.Text = (c * 38).ToString();
            }




            if (a == "USD" && b == "GEL")
            {
                txtoutput.Text = (c * 3.14).ToString();
            }
            if (a == "USD" && b == "USD")
            {
                txtoutput.Text = c.ToString();
            }
            if (a == "USD" && b == "EUR")
            {
                txtoutput.Text = (c * 0.88).ToString();
            }
            if (a == "USD" && b == "YAN")
            {
                txtoutput.Text = (c * 144).ToString();
            }



            if (a == "EUR" && b == "GEL")
            {
                txtoutput.Text = (c * 4).ToString();
            }
            if (a == "EUR" && b == "USD")
            {
                txtoutput.Text = (c * 1.14).ToString();
            }
            if (a == "EUR" && b == "EUR")
            {
                txtoutput.Text = c.ToString();
            }
            if (a == "EUR" && b == "YAN")
            {
                txtoutput.Text = (c * 130).ToString();
            }


            if (a == "YAN" && b == "GEL")
            {
                txtoutput.Text = (c * 0.026).ToString();
            }
            if (a == "YAN" && b == "USD")
            {
                txtoutput.Text = (c * 0.0087).ToString();
            }
            if (a == "YAN" && b == "EUR")
            {
                txtoutput.Text = (c * 0.0077).ToString();
            }
            if (a == "YAN" && b == "YAN")
            {
                txtoutput.Text = c.ToString();
            }
        }

     
    }
        
}
