﻿namespace Maria_contactos
{
    partial class EliminarContactoPantalla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            teleliminar = new TextBox();
            Nombreeliminar = new TextBox();
            EliminarClick = new Button();
            VolverCrear = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 72);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(296, 23);
            label2.Name = "label2";
            label2.Size = new Size(205, 28);
            label2.TabIndex = 10;
            label2.Text = "Eliminar Contacto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(78, 122);
            label5.Name = "label5";
            label5.Size = new Size(185, 28);
            label5.TabIndex = 19;
            label5.Text = "Rellene los datos";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(39, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 248);
            panel3.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Ivory;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(teleliminar);
            panel2.Controls.Add(Nombreeliminar);
            panel2.Controls.Add(EliminarClick);
            panel2.Location = new Point(22, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 213);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(172, 21);
            label1.TabIndex = 9;
            label1.Text = "Nombre del contacto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 87);
            label3.Name = "label3";
            label3.Size = new Size(176, 21);
            label3.TabIndex = 11;
            label3.Text = "Telefono del contacto";
            // 
            // teleliminar
            // 
            teleliminar.BackColor = SystemColors.WindowFrame;
            teleliminar.ForeColor = Color.White;
            teleliminar.Location = new Point(15, 111);
            teleliminar.Name = "teleliminar";
            teleliminar.Size = new Size(191, 23);
            teleliminar.TabIndex = 10;
            // 
            // Nombreeliminar
            // 
            Nombreeliminar.BackColor = Color.DimGray;
            Nombreeliminar.ForeColor = Color.White;
            Nombreeliminar.Location = new Point(15, 49);
            Nombreeliminar.Name = "Nombreeliminar";
            Nombreeliminar.Size = new Size(191, 23);
            Nombreeliminar.TabIndex = 9;
            // 
            // EliminarClick
            // 
            EliminarClick.BackColor = SystemColors.AppWorkspace;
            EliminarClick.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EliminarClick.Location = new Point(15, 159);
            EliminarClick.Name = "EliminarClick";
            EliminarClick.Size = new Size(191, 38);
            EliminarClick.TabIndex = 2;
            EliminarClick.Text = "Eliminar";
            EliminarClick.UseVisualStyleBackColor = false;
            EliminarClick.Click += EliminarClick_Click;
            // 
            // VolverCrear
            // 
            VolverCrear.BackColor = SystemColors.AppWorkspace;
            VolverCrear.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VolverCrear.Location = new Point(612, 371);
            VolverCrear.Name = "VolverCrear";
            VolverCrear.Size = new Size(162, 39);
            VolverCrear.TabIndex = 20;
            VolverCrear.Text = "Volver al menu";
            VolverCrear.UseVisualStyleBackColor = false;
            VolverCrear.Click += eliminarVolver;
            // 
            // EliminarContactoPantalla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VolverCrear);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "EliminarContactoPantalla";
            Text = "EliminarContactoPantalla";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label5;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private TextBox teleliminar;
        private TextBox Nombreeliminar;
        private Button EliminarClick;
        private Button VolverCrear;
    }
}