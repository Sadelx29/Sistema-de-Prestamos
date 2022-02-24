using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDePrestamos
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            btncalcular i = new btncalcular();
            i.txtnombre.Text = txtnombre.Text;
            i.txtapellido.Text = txtapellido.Text;
            i.txtcedula.Text = txtcedula.Text;


            this.Hide();
            i.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtcedula.Clear();
            txtcelular.Clear();
            txtdireccion.Clear();
            txtemail.Clear();
            txtsector.Clear();
            txttelefono.Clear();
            
        }

        private void registro_Load(object sender, EventArgs e)
        {

        }
    }
}
