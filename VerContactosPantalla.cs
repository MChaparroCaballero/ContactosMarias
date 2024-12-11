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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Maria_contactos
{
    public partial class VerContactosPantalla : Form
    {
        public VerContactosPantalla()
        {
            InitializeComponent();
        }

        /*-------------------------boton de accion de ver todos los contactos-------------------------------------------------------------------------------------------*/
        private void VerContactosTodos_button(object sender, EventArgs e)
        {

            /******en un array de string guardamos el resultado de llamar a la funcion ver contactos de la clase arraycontactos*****/
            string[] datos = ArrayContacts.verContactos();

            /*****recorremos y editamos el texto de la textbox, añadiendo cada elemento del array en una nueva linea ****/
            foreach (var item in datos)
            {
                areatodosContactoEncontrado.AppendText(item + Environment.NewLine);
            }
            
        }
        /*-----------------------------boton de accion de volver al home--------------------------------------------------------------------------------*/
        private void VercontactosVolver_button(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida hh = new bienvenida();
            hh.Show();
        }
    }
}
