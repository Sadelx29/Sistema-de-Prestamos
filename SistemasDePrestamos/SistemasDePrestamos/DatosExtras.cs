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
    public partial class DatosExtras : Form
    {
        public DatosExtras()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnretroceder_Click(object sender, EventArgs e)
        {
            

            btncalcular t = new btncalcular();
            t.txtnombre.Text = txtnombre.Text;
            t.txtapellido.Text = txtapellido.Text;
            t.txtnumprestamo.Text = txtnumprestamo.Text;
            t.txtmontodelprestamo.Text = txtmontodelprestamo.Text;
            
            

            this.Hide();
            t.ShowDialog();



            this.Hide();
            t.ShowDialog();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
