using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maria_contactos
{
    public partial class CrearContactoPantalla : Form
    {
        public CrearContactoPantalla()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida bienvenida = new bienvenida();
            bienvenida.Show();
            
        }

        private void crear_Click(object sender, EventArgs e)
        {

        }
    }
}
