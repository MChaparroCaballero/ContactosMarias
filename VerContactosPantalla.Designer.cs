namespace Maria_contactos
{
    partial class VerContactosPantalla
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
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            VercontactosVolver = new Button();
            Ver = new Button();
            areatodosContactoEncontrado = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 75);
            label4.Name = "label4";
            label4.Size = new Size(111, 30);
            label4.TabIndex = 14;
            label4.Text = "Contactos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 65);
            panel1.TabIndex = 16;
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
            label2.Size = new Size(153, 28);
            label2.TabIndex = 7;
            label2.Text = "Ver contactos";
            // 
            // VercontactosVolver
            // 
            VercontactosVolver.BackColor = SystemColors.AppWorkspace;
            VercontactosVolver.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VercontactosVolver.Location = new Point(609, 388);
            VercontactosVolver.Name = "VercontactosVolver";
            VercontactosVolver.Size = new Size(165, 38);
            VercontactosVolver.TabIndex = 17;
            VercontactosVolver.Text = "Volver al menu";
            VercontactosVolver.UseVisualStyleBackColor = false;
            VercontactosVolver.Click += VercontactosVolver_button;
            // 
            // Ver
            // 
            Ver.BackColor = SystemColors.AppWorkspace;
            Ver.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ver.Location = new Point(32, 404);
            Ver.Name = "Ver";
            Ver.Size = new Size(220, 34);
            Ver.TabIndex = 18;
            Ver.Text = "Ver contactos";
            Ver.UseVisualStyleBackColor = false;
            Ver.Click += VerContactosTodos_button;
            // 
            // areatodosContactoEncontrado
            // 
            areatodosContactoEncontrado.BackColor = Color.Ivory;
            areatodosContactoEncontrado.BorderStyle = BorderStyle.FixedSingle;
            areatodosContactoEncontrado.Location = new Point(32, 108);
            areatodosContactoEncontrado.Multiline = true;
            areatodosContactoEncontrado.Name = "areatodosContactoEncontrado";
            areatodosContactoEncontrado.Size = new Size(217, 290);
            areatodosContactoEncontrado.TabIndex = 19;
            // 
            // VerContactosPantalla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(areatodosContactoEncontrado);
            Controls.Add(Ver);
            Controls.Add(VercontactosVolver);
            Controls.Add(panel1);
            Controls.Add(label4);
            Name = "VerContactosPantalla";
            Text = "VerContactosPantalla";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Panel panel1;
        private Label label2;
        private Button VercontactosVolver;
        private Button Ver;
        private TextBox areatodosContactoEncontrado;
    }
}