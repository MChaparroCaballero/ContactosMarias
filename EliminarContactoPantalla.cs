﻿using System;
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
    public partial class EliminarContactoPantalla : Form
    {
        public EliminarContactoPantalla()
        {
            InitializeComponent();
        }

        private void EliminarClick_Click(object sender, EventArgs e)
        {

        }

        private void eliminarVolver(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida jn = new bienvenida();
            jn.Show();
        }
    }
}
