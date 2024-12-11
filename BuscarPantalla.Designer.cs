namespace Maria_contactos
{
    partial class BuscarPantalla
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
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            telbuscar = new TextBox();
            NombreBuscar = new TextBox();
            buscar = new Button();
            Volver = new Button();
            label5 = new Label();
            areaContactoEncontrado = new TextBox();
            label6 = new Label();
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
            panel1.Size = new Size(800, 71);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(324, 19);
            label2.Name = "label2";
            label2.Size = new Size(179, 28);
            label2.TabIndex = 7;
            label2.Text = "Buscar contacto";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(25, 128);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 248);
            panel3.TabIndex = 10;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Ivory;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(telbuscar);
            panel2.Controls.Add(NombreBuscar);
            panel2.Controls.Add(buscar);
            panel2.Location = new Point(22, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 213);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
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
            label3.Click += label3_Click;
            // 
            // telbuscar
            // 
            telbuscar.BackColor = SystemColors.WindowFrame;
            telbuscar.ForeColor = Color.White;
            telbuscar.Location = new Point(15, 111);
            telbuscar.Name = "telbuscar";
            telbuscar.Size = new Size(191, 23);
            telbuscar.TabIndex = 10;
            // 
            // NombreBuscar
            // 
            NombreBuscar.BackColor = Color.DimGray;
            NombreBuscar.ForeColor = Color.White;
            NombreBuscar.Location = new Point(15, 49);
            NombreBuscar.Name = "NombreBuscar";
            NombreBuscar.Size = new Size(191, 23);
            NombreBuscar.TabIndex = 9;
            NombreBuscar.TextChanged += textBox1_TextChanged;
            // 
            // buscar
            // 
            buscar.BackColor = SystemColors.AppWorkspace;
            buscar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscar.Location = new Point(15, 159);
            buscar.Name = "buscar";
            buscar.Size = new Size(191, 38);
            buscar.TabIndex = 2;
            buscar.Text = "Buscar contacto";
            buscar.UseVisualStyleBackColor = false;
            buscar.Click += buscarContacto_Click;
            // 
            // Volver
            // 
            Volver.BackColor = SystemColors.AppWorkspace;
            Volver.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.Location = new Point(25, 391);
            Volver.Name = "Volver";
            Volver.Size = new Size(273, 38);
            Volver.TabIndex = 12;
            Volver.Text = "Volver al menu";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += buscarVolver_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(64, 88);
            label5.Name = "label5";
            label5.Size = new Size(185, 28);
            label5.TabIndex = 14;
            label5.Text = "Rellene los datos";
            label5.Click += label5_Click;
            // 
            // areaContactoEncontrado
            // 
            areaContactoEncontrado.BackColor = Color.Ivory;
            areaContactoEncontrado.BorderStyle = BorderStyle.FixedSingle;
            areaContactoEncontrado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            areaContactoEncontrado.Location = new Point(446, 128);
            areaContactoEncontrado.Multiline = true;
            areaContactoEncontrado.Name = "areaContactoEncontrado";
            areaContactoEncontrado.Size = new Size(329, 301);
            areaContactoEncontrado.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(514, 88);
            label6.Name = "label6";
            label6.Size = new Size(203, 28);
            label6.TabIndex = 21;
            label6.Text = "Datos de contacto:";
            // 
            // BuscarPantalla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(areaContactoEncontrado);
            Controls.Add(label5);
            Controls.Add(Volver);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "BuscarPantalla";
            Text = "BuscarPantalla";
            Load += BuscarPantalla_Load;
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
        private Panel panel3;
        private Panel panel2;
        private Button buscar;

        

        private Label label1;
        private Label label3;
        private TextBox telbuscar;
        private TextBox NombreBuscar;
        private Button Volver;
        private Label label2;
        private Label label5;
        private TextBox areaContactoEncontrado;
        private Label label6;
    }
}