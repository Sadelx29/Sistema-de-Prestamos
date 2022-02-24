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
    public partial class btncalcular : Form
    {
       
        public btncalcular()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            DatosExtras d = new DatosExtras();
            d.txtnombre.Text = txtnombre.Text;
            d.txtapellido.Text = txtapellido.Text;
            d.txtnumprestamo.Text = txtnumprestamo.Text;
            d.txtmontodelprestamo.Text = txtmontodelprestamo.Text;
        

            this.Hide();
            d.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnretroceder_Click(object sender, EventArgs e)
        {
            //DECLARACION
            double prestamo, cuotas, interes, tinteres, montodelprestamo;
            int periodo;
            string garantia;
            //ENTRADA
            prestamo = Convert.ToDouble(txtprestamo.Text);
            tinteres = Convert.ToDouble(txttinteres.Text);      
            periodo = Convert.ToInt32(txtperiododeprestamo.Text);
            garantia = Convert.ToString(txtgarantia.Text);
            //PROCESO
            tinteres = tinteres *  12 / 100;
            interes  = prestamo * tinteres;
            interes = interes * periodo;
            montodelprestamo = prestamo + interes;
            cuotas = montodelprestamo / periodo;
            //SALIDA
            txtcuotas.Text = Convert.ToString(cuotas);
            txtinteres.Text = Convert.ToString(interes);
            txtmontodelprestamo.Text = Convert.ToString(montodelprestamo);

          









        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Load(object sender, EventArgs e)
        {

        }
    }
    }

