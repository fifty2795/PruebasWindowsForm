namespace Pruebas
{
    partial class Form2
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
            rbtnFemenino = new RadioButton();
            rbtnMasculino = new RadioButton();
            label1 = new Label();
            lblNombre = new Label();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            SuspendLayout();
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Location = new Point(134, 201);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(95, 24);
            rbtnFemenino.TabIndex = 14;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(132, 150);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(97, 24);
            rbtnMasculino.TabIndex = 13;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 152);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 12;
            label1.Text = "Sexo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(134, 90);
            txtEdad.MaxLength = 33434;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 9;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(32, 87);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 10;
            lblEdad.Text = "Edad";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 260);
            Controls.Add(rbtnFemenino);
            Controls.Add(rbtnMasculino);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtnFemenino;
        private RadioButton rbtnMasculino;
        private Label label1;
        private Label lblNombre;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lblEdad;
    }
}