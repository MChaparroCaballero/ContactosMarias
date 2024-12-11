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
        /*--------------------------------------------------boton de volver al home-----------------------------------------------------------------------------*/
        private void ActualizarVolverclick(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida ll = new bienvenida();
            ll.Show();
        }
        /*----------------------------------------------boton de accion de actualizar contacto---------------------------------------------------------------------------------*/
        private void ActualizarButon(object sender, EventArgs e)
        {

            /*comprobamos que todos los campos estan rellenados, y hacemos dos objeto de cotactos uno de los datos viejo y otro de los datos nuevos*/
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
                /*si falta algun campo por rellenar te salta una ventanita de mensaje indicandote que debes rellenar todos*/
                MessageBox.Show("Error debe rellenar todos los campos antes de pulsar el boton");
            }

            
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------*/
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
