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
    public partial class CrearContacto : Form
    {
        public CrearContacto()
        {
            InitializeComponent();
        }

        /*---------------------------------------------------Boton de volver al home-------------------------------------------------------------------*/
        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida nueva = new bienvenida();
            nueva.Show();
        }
        /*---------------------------------------------------Boton de acción de crear contacto--------------------------------------------------------------------*/
        private void CrearClick_Click(object sender, EventArgs e)
        {
            /*comprobamos que los campos de texto de datos no esten vacios, creamos un  nuevo objeto de Contact y lo añadimos al array*/
            if (Nombre.Text.Length!=0 && tel.Text.Length!=0)
            {
                
              Contact contacto = new Contact();
                contacto.Phone = tel.Text ;
                contacto.Name = Nombre.Text;
                ArrayContacts.AgregarContacto(contacto);

            }
            else
            {
                /****si estan en blanco alguno nos saca una ventan de error informandonos de que hay que completarlos todos******/
                MessageBox.Show("Error debe rellenar los campos de datos antes de dar al boton");
            }
        }

        /*-------------------------------------------------------------------------------------------------------------------------------*/
        private void Nombre_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
