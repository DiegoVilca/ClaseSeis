using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola formulario");

            string aux;

            aux = this.txtNombre.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "hola ";

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAprobarMateria_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "Aprobar materia";
        }

        private void btnAprobarMateria_MouseHover(object sender, EventArgs e)
        {
            //this.btnAprobarMateria.Visible = false;
        }

        private void btnAprobarMateria_MouseLeave(object sender, EventArgs e)
        {
            this.btnAprobarMateria.Visible = true;
        }

        private void btnAprobarMateria_MouseEnter(object sender, EventArgs e)
        {
            this.btnAprobarMateria.Visible = false;
        }
    }
}
