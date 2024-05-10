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
    public partial class FormXY : Form
    {
        public FormXY()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x = 0;
            double y = 0;
            double result = 0;

            x = Convert.ToDouble(txtX.Text);
            y = Convert.ToDouble(txtY.Text);

            result = x * y;

            txtResultado .Text = Convert.ToString(result);
        }
    }
}
