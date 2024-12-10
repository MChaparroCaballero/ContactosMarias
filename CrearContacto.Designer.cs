namespace Maria_contactos
{
    partial class CrearContacto
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
            VolverCrear = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            tel = new TextBox();
            Nombre = new TextBox();
            CrearClick = new Button();
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
            panel1.Size = new Size(800, 86);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(271, 25);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 10;
            label2.Text = "Crear contacto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(70, 114);
            label5.Name = "label5";
            label5.Size = new Size(185, 28);
            label5.TabIndex = 17;
            label5.Text = "Rellene los datos";
            // 
            // VolverCrear
            // 
            VolverCrear.BackColor = SystemColors.AppWorkspace;
            VolverCrear.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VolverCrear.Location = new Point(616, 385);
            VolverCrear.Name = "VolverCrear";
            VolverCrear.Size = new Size(162, 39);
            VolverCrear.TabIndex = 16;
            VolverCrear.Text = "Volver al menu";
            VolverCrear.UseVisualStyleBackColor = false;
            VolverCrear.Click += Volver_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(31, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 248);
            panel3.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Ivory;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tel);
            panel2.Controls.Add(Nombre);
            panel2.Controls.Add(CrearClick);
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
            // tel
            // 
            tel.BackColor = SystemColors.WindowFrame;
            tel.ForeColor = Color.White;
            tel.Location = new Point(15, 111);
            tel.Name = "tel";
            tel.Size = new Size(191, 23);
            tel.TabIndex = 10;
            // 
            // Nombre
            // 
            Nombre.BackColor = Color.DimGray;
            Nombre.ForeColor = Color.White;
            Nombre.Location = new Point(15, 49);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(191, 23);
            Nombre.TabIndex = 9;
            Nombre.TextChanged += Nombre_TextChanged;
            // 
            // CrearClick
            // 
            CrearClick.BackColor = SystemColors.AppWorkspace;
            CrearClick.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrearClick.Location = new Point(15, 159);
            CrearClick.Name = "CrearClick";
            CrearClick.Size = new Size(191, 38);
            CrearClick.TabIndex = 2;
            CrearClick.Text = "Crear";
            CrearClick.UseVisualStyleBackColor = false;
            CrearClick.Click += CrearClick_Click;
            // 
            // CrearContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(VolverCrear);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CrearContacto";
            Text = "CrearContacto";
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
        private Button VolverCrear;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private TextBox tel;
        private TextBox Nombre;
        private Button CrearClick;
    }
}