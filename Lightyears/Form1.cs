using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightyears
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            try {
                Double light_year = Convert.ToDouble(lightText.Text.ToString());
                kmText.Text = Convert.ToString(light_year * 9461000000000);
            }
            catch(Exception){

            }
           
        }
    }
}
