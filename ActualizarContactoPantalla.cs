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
    public partial class ActualizarContactoPantalla : Form
    {
        public ActualizarContactoPantalla()
        {
            InitializeComponent();
        }

        private void ActualizarVolverclick(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida ll = new bienvenida();
            ll.Show();
        }

        private void ActualizarButon(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
