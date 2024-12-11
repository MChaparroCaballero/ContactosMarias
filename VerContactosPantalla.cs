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

        private void VerContactosTodos_button(object sender, EventArgs e)
        {
            string[] datos = ArrayContacts.verContactos();

            foreach (var item in datos)
            {
                areatodosContactoEncontrado.AppendText(item + Environment.NewLine); // Añadir cada elemento en una nueva línea
            }
            
        }

        private void VercontactosVolver_button(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida hh = new bienvenida();
            hh.Show();
        }
    }
}
