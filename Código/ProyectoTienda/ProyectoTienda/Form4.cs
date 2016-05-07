using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoTienda
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string vDescripcion = txtDescripcion.Text;
            Int32 iCant = Convert.ToInt32(txtCantidad.Text);
            decimal dprecio = Convert.ToDecimal(txtPrecio.Text);
            decimal dTotal = iCant * dprecio;

            string[] row = new string[] { "1", vDescripcion, iCant.ToString(), dprecio.ToString(), dTotal.ToString() };
            dtCompras.Rows.Add(row);
            
        }

        
       

     

      
    

      
    }
}
