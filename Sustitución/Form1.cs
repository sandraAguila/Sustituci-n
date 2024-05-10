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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXY_Click(object sender, EventArgs e)
        {
            Form formulario = new FormXY();
            formulario.Show();
            this.Hide();
        }

        private void btnXYZ_Click(object sender, EventArgs e)
        {
            Form formulario = new FormXYZ();
            formulario.Show();
            this.Hide();
        }

        private void btnXYZW_Click(object sender, EventArgs e)
        {
            Form formulario = new FormXYZW();
            formulario.Show();
            this.Hide(); 
        }
    }
}
