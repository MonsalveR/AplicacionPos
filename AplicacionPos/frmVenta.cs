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
    public partial class frmVenta : Form
    {
        BBDD baseDatos;
        public frmVenta()
        {
            InitializeComponent();
        }
    

        private void btnVender_Click(object sender, EventArgs e)
        {
            BBDD BaseDatos = new BBDD("Cajero","CA1234");
            BaseDatos.Conectar();
            //string query = $"insert into tblVenta values ('{txtCodigoV.Text}',{txtCantidad.Text},'{txtCodigoP.Text}')";
            bool bd = BaseDatos.comando(txtCodigoV.Text,Convert.ToInt32(txtCantidad.Text),txtCodigoP.Text);
            BaseDatos.comando(txtCodigoV.Text, Convert.ToInt32(txtCantidad.Text), txtCodigoP.Text);
            if (bd == true)
            {
                MessageBox.Show("Ingreso exitoso de la venta !");
                txtCantidad.Clear();
                txtCodigoP.Clear();
                txtCodigoV.Clear();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al ingresar la venta !");
                txtCantidad.Clear();
                txtCodigoP.Clear();
                txtCodigoV.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
