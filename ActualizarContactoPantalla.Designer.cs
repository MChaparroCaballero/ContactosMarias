namespace Maria_contactos
{
    partial class ActualizarContactoPantalla
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
            VolverActualizar = new Button();
            label5 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            telViejo = new TextBox();
            NombreViejo = new TextBox();
            actualizarClick = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            label7 = new Label();
            telnuevo = new TextBox();
            nombrenuevo = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 74);
            panel1.TabIndex = 9;
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
            label2.Size = new Size(214, 28);
            label2.TabIndex = 10;
            label2.Text = "Actualizar contacto";
            // 
            // VolverActualizar
            // 
            VolverActualizar.BackColor = SystemColors.AppWorkspace;
            VolverActualizar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VolverActualizar.Location = new Point(694, 372);
            VolverActualizar.Name = "VolverActualizar";
            VolverActualizar.Size = new Size(94, 66);
            VolverActualizar.TabIndex = 17;
            VolverActualizar.Text = "Volver al menu";
            VolverActualizar.UseVisualStyleBackColor = false;
            VolverActualizar.Click += ActualizarVolverclick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(254, 109);
            label5.Name = "label5";
            label5.Size = new Size(185, 28);
            label5.TabIndex = 21;
            label5.Text = "Rellene los datos";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 192);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(42, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(290, 248);
            panel3.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Ivory;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(telViejo);
            panel2.Controls.Add(NombreViejo);
            panel2.Location = new Point(22, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 213);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(214, 21);
            label1.TabIndex = 9;
            label1.Text = "Nombre del contacto viejo";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 87);
            label3.Name = "label3";
            label3.Size = new Size(218, 21);
            label3.TabIndex = 11;
            label3.Text = "Telefono del contacto viejo";
            // 
            // telViejo
            // 
            telViejo.BackColor = SystemColors.WindowFrame;
            telViejo.ForeColor = Color.White;
            telViejo.Location = new Point(15, 111);
            telViejo.Name = "telViejo";
            telViejo.Size = new Size(213, 23);
            telViejo.TabIndex = 10;
            // 
            // NombreViejo
            // 
            NombreViejo.BackColor = Color.DimGray;
            NombreViejo.ForeColor = Color.White;
            NombreViejo.Location = new Point(15, 49);
            NombreViejo.Name = "NombreViejo";
            NombreViejo.Size = new Size(213, 23);
            NombreViejo.TabIndex = 9;
            // 
            // actualizarClick
            // 
            actualizarClick.BackColor = SystemColors.AppWorkspace;
            actualizarClick.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            actualizarClick.Location = new Point(15, 159);
            actualizarClick.Name = "actualizarClick";
            actualizarClick.Size = new Size(213, 38);
            actualizarClick.TabIndex = 2;
            actualizarClick.Text = "Actualizar";
            actualizarClick.UseVisualStyleBackColor = false;
            actualizarClick.Click += ActualizarButon;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 255, 192);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(384, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(290, 248);
            panel4.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Ivory;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(telnuevo);
            panel5.Controls.Add(nombrenuevo);
            panel5.Controls.Add(actualizarClick);
            panel5.Location = new Point(22, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(246, 213);
            panel5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 15);
            label6.Name = "label6";
            label6.Size = new Size(224, 21);
            label6.TabIndex = 9;
            label6.Text = "Nombre del contacto nuevo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 87);
            label7.Name = "label7";
            label7.Size = new Size(228, 21);
            label7.TabIndex = 11;
            label7.Text = "Telefono del contacto nuevo";
            // 
            // telnuevo
            // 
            telnuevo.BackColor = SystemColors.WindowFrame;
            telnuevo.ForeColor = Color.White;
            telnuevo.Location = new Point(15, 111);
            telnuevo.Name = "telnuevo";
            telnuevo.Size = new Size(213, 23);
            telnuevo.TabIndex = 10;
            // 
            // nombrenuevo
            // 
            nombrenuevo.BackColor = Color.DimGray;
            nombrenuevo.ForeColor = Color.White;
            nombrenuevo.Location = new Point(15, 49);
            nombrenuevo.Name = "nombrenuevo";
            nombrenuevo.Size = new Size(213, 23);
            nombrenuevo.TabIndex = 9;
            // 
            // ActualizarContactoPantalla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(VolverActualizar);
            Controls.Add(panel1);
            Name = "ActualizarContactoPantalla";
            Text = "ActualizarContactoPantalla";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button VolverActualizar;
        private Label label5;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private TextBox telViejo;
        private TextBox NombreViejo;
        private Button actualizarClick;
        private Panel panel4;
        private Panel panel5;
        private Label label6;
        private Label label7;
        private TextBox telnuevo;
        private TextBox nombrenuevo;
    }
}