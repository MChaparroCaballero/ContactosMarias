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
    public partial class CrearContacto : Form
    {
        public CrearContacto()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenida nueva = new bienvenida();
            nueva.Show();
        }

        private void CrearClick_Click(object sender, EventArgs e)
        {

        }
    }
}