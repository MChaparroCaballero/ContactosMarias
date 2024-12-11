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

            if (NombreBuscar.Text.Length != 0 && telbuscar.Text.Length != 0)
            {
                areaContactoEncontrado.Text = ArrayContacts.BuscarContacto(telbuscar.Text);
            }
            else
            {
                MessageBox.Show("Error debe rellenar todos los campos antes de pulsar el boton");
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
            this.Hide();
            bienvenida nn = new bienvenida();
            nn.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buscarVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida hnueva = new bienvenida();
            hnueva.Show();
        }

        private void BuscarPantalla_Load(object sender, EventArgs e)
        {

        }
    }
}
