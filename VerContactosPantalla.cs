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
    public partial class VerContactosPantalla : Form
    {
        public VerContactosPantalla()
        {
            InitializeComponent();
        }

        private void VerContactosTodos_button(object sender, EventArgs e)
        {

        }

        private void VercontactosVolver_button(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida hh = new bienvenida();
            hh.Show();
        }
    }
}
