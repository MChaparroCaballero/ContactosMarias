﻿namespace Maria_contactos
{
    partial class bienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buscarContacto = new Button();
            CrearContactobutoon = new Button();
            Actualizar_contacto = new Button();
            Eliminar_contacto = new Button();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            VerContactos = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 10);
            label1.Name = "label1";
            label1.Size = new Size(239, 34);
            label1.TabIndex = 1;
            label1.Text = "¿Que desea hacer?";
            label1.Click += label1_Click;
            // 
            // buscarContacto
            // 
            buscarContacto.BackColor = SystemColors.AppWorkspace;
            buscarContacto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscarContacto.Location = new Point(12, 14);
            buscarContacto.Name = "buscarContacto";
            buscarContacto.Size = new Size(214, 37);
            buscarContacto.TabIndex = 2;
            buscarContacto.Text = "Buscar contacto";
            buscarContacto.UseVisualStyleBackColor = false;
            buscarContacto.Click += button1_Click;
            // 
            // CrearContactobutoon
            // 
            CrearContactobutoon.BackColor = SystemColors.ButtonShadow;
            CrearContactobutoon.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrearContactobutoon.Location = new Point(12, 57);
            CrearContactobutoon.Name = "CrearContactobutoon";
            CrearContactobutoon.Size = new Size(214, 37);
            CrearContactobutoon.TabIndex = 3;
            CrearContactobutoon.Text = "Crear contacto";
            CrearContactobutoon.UseVisualStyleBackColor = false;
            CrearContactobutoon.Click += button2_Click;
            // 
            // Actualizar_contacto
            // 
            Actualizar_contacto.BackColor = SystemColors.ButtonShadow;
            Actualizar_contacto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Actualizar_contacto.Location = new Point(12, 100);
            Actualizar_contacto.Name = "Actualizar_contacto";
            Actualizar_contacto.Size = new Size(214, 37);
            Actualizar_contacto.TabIndex = 4;
            Actualizar_contacto.Text = "Actualizar contacto";
            Actualizar_contacto.UseVisualStyleBackColor = false;
            Actualizar_contacto.Click += button3_Click;
            // 
            // Eliminar_contacto
            // 
            Eliminar_contacto.BackColor = SystemColors.ButtonShadow;
            Eliminar_contacto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Eliminar_contacto.Location = new Point(12, 143);
            Eliminar_contacto.Name = "Eliminar_contacto";
            Eliminar_contacto.Size = new Size(215, 37);
            Eliminar_contacto.TabIndex = 5;
            Eliminar_contacto.Text = "Eliminar contacto";
            Eliminar_contacto.UseVisualStyleBackColor = false;
            Eliminar_contacto.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(184, 18);
            label2.Name = "label2";
            label2.Size = new Size(385, 28);
            label2.TabIndex = 6;
            label2.Text = "Bienvenido a su agenda de contactos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 62);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(VerContactos);
            panel2.Controls.Add(Eliminar_contacto);
            panel2.Controls.Add(buscarContacto);
            panel2.Controls.Add(Actualizar_contacto);
            panel2.Controls.Add(CrearContactobutoon);
            panel2.Location = new Point(16, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 279);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(13, 229);
            button1.Name = "button1";
            button1.Size = new Size(214, 37);
            button1.TabIndex = 11;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Salir_click;
            // 
            // VerContactos
            // 
            VerContactos.BackColor = SystemColors.ButtonShadow;
            VerContactos.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VerContactos.Location = new Point(12, 186);
            VerContactos.Name = "VerContactos";
            VerContactos.Size = new Size(214, 37);
            VerContactos.TabIndex = 10;
            VerContactos.Text = "Ver contactos";
            VerContactos.UseVisualStyleBackColor = false;
            VerContactos.Click += VeerContactos_button;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(228, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(274, 352);
            panel3.TabIndex = 9;
            // 
            // bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "bienvenida";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button buscarContacto;
        private Button CrearContactobutoon;
        private Button Actualizar_contacto;
        private Button Eliminar_contacto;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button VerContactos;
        private Button button1;
    }
}
