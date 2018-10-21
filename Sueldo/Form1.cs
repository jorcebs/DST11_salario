using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sueldo = Convert.ToSingle(txtSueldo.Text);

            if (sueldo <= 1000)
                sueldo *= 1.18;
            else if (sueldo <= 1200)
                sueldo *= 1.15;
            else if (sueldo <= 1450)
                sueldo *= 1.12;
            else if (sueldo <= 1600)
                sueldo *= 1.1;
            else
                sueldo *= 1.08;
            
            txtResultado.Text = sueldo.ToString();
        }
    }
}