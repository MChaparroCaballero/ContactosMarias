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

        /*--------------------------------------boton de accion para eliminar un contacto--------------------------------------------------------------------------------*/
        private void EliminarClick_Click(object sender, EventArgs e)
        {

            /*comprobamos que los campos de texo de los datos esten rellenos, creamos un nuevo objeto del que hay que eliminar y llamamos al metodo para eliminarlo del array*/
            if (Nombreeliminar.Text.Length != 0 && teleliminar.Text.Length != 0)
            {
                Contact contact = new Contact();
                contact.Name = Nombreeliminar.Text;
                contact.Phone = teleliminar.Text;
                ArrayContacts.EliminarContacto(contact);
            }
            else
            {
                /****Si falta algun dato nos salta una ventana de error informandonos de que debes rellenarlos todos***/
                MessageBox.Show("Error debe rellenar todos los campos antes de dar al boton");
            }
        }
        /*-------------------------------------------Boton de accion para volver al home------------------------------------------------------------------------------------*/
        private void eliminarVolver(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida jn = new bienvenida();
            jn.Show();
        }
        /*-------------------------------------------------------------------------------------------------------------------------------*/
    }
}
