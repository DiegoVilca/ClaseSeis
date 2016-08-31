using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteFacturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.txtPrecio1.Text);
            int num2 = int.Parse(this.txtPrecio2.Text);
            int num3 = int.Parse(this.txtPrecio3.Text);

            int suma = num1 + num2 + num3 ;
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.txtPrecio1.Text);
            int num2 = int.Parse(this.txtPrecio2.Text);
            int num3 = int.Parse(this.txtPrecio3.Text);

            int suma = num1 + num2 + num3; 
            int promedio = suma/3 ;

        }

        private void btnPrecioFinal_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.txtPrecio1.Text);
            int num2 = int.Parse(this.txtPrecio2.Text);
            int num3 = int.Parse(this.txtPrecio3.Text);

            int suma = num1 + num2 + num3;
            double precioFinal = suma * 0.21;
        }
    }
}
