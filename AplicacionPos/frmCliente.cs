using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionPos
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            //BBDD BaseDatos = new BBDD("Cajero", "CA1234");
            //BaseDatos.Conectar(); 
            BaseDatos 

            bool bd = BaseDatos.comando(txtCodigo.Text, txtNombre.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(txtStock.Text));
            BaseDatos.comando(txtCodigo.Text,txtNombre.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(txtStock.Text));
            if (bd == true)
            {
                MessageBox.Show("Ingreso exitoso del producto en el stock !");
                txtCodigo.Clear();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtStock.Clear();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al ingresar el producto !");
                txtCodigo.Clear();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtStock.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
