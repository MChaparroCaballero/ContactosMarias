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
            if (NombreViejo.Text.Length!=0 && telViejo.Text.Length!=0 && nombrenuevo.Text.Length !=0 && telnuevo.Text.Length!=0)
            {
                Contact VIEJO = new Contact();
                VIEJO.Name = NombreViejo.Text;
                VIEJO.Phone = telViejo.Text;
                Contact nuevo = new Contact();
                nuevo.Name = nombrenuevo.Text;
                nuevo.Phone= telnuevo.Text;
                ArrayContacts.ActualizarContacto(VIEJO, nuevo);
            }
            else
            {
                MessageBox.Show("Error debe rellenar todos los campos antes de pulsar el boton");
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
