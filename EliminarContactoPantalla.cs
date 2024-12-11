using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Maria_contactos
{
    public partial class EliminarContactoPantalla : Form
    {
        public EliminarContactoPantalla()
        {
            InitializeComponent();
        }

        private void EliminarClick_Click(object sender, EventArgs e)
        {


            if (Nombreeliminar.Text.Length != 0 && teleliminar.Text.Length != 0)
            {
                Contact contact = new Contact();
                contact.Name = Nombreeliminar.Text;
                contact.Phone = teleliminar.Text;
                ArrayContacts.EliminarContacto(contact);
            }
            else
            {
                MessageBox.Show("Error debe rellenar todos los campos antes de dar al boton");
            }
        }

        private void eliminarVolver(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida jn = new bienvenida();
            jn.Show();
        }
    }
}
