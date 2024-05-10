using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sustitución
{
    public partial class FormXYZ : Form
    {
        public FormXYZ()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;
            double z = 0;
            double result = 0;

            x = Convert.ToDouble(txtX.Text);
            y = Convert.ToDouble(txtY.Text);
            z = Convert.ToDouble(txtZ.Text);
             
            result = x * y * z;

            txtResultado.Text = Convert.ToString(result);
        }
    }
}
