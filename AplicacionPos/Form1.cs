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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            BBDD BaseDatos = new BBDD(txtUsuario.Text,txtContraseña.Text);
            BaseDatos.Conectar()
            if(BaseDatos.Conectar() == true)
            {
                MessageBox.Show("Conexio Exitosa !");
                if(txtUsuario.Text == "Cajero")
                {
                    this.Hide();
                    frmVenta Venta = new frmVenta();
                    Venta.Show();
                }else if(txtUsuario.Text == "Cliente")
                {
                    this.Hide();
                    frmCliente Cliente = new frmCliente();
                    Cliente.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña erronios !");
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
            BaseDatos.Desconectar();
        }
    }
}
