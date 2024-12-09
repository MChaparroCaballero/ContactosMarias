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
    public partial class BuscarPantalla : Form
    {
        public BuscarPantalla()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buscarContacto_Click(object sender, EventArgs e)
        {
            /**botn de accion de la pantalla de buscar contactos***/

            if (Nombre.Text != null&& tel.Text!=null)
          {
                searchContact();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

    }
}
