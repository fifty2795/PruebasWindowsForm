namespace Pruebas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblNombre = new Label();
            button1 = new Button();
            txtNombre = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            label1 = new Label();
            rbtnMasculino = new RadioButton();
            rbtnFemenino = new RadioButton();
            pictureBox1 = new PictureBox();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(271, 103);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // button1
            // 
            button1.Location = new Point(302, 517);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 1;
            button1.Text = "Mostrar Datos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(370, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(271, 170);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(373, 173);
            txtEdad.MaxLength = 33434;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 4;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 235);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 5;
            label1.Text = "Sexo";
            label1.Click += label1_Click;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(371, 233);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(97, 24);
            rbtnMasculino.TabIndex = 6;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Location = new Point(373, 284);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(95, 24);
            rbtnFemenino.TabIndex = 7;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            rbtnFemenino.CheckedChanged += rbtnFemenino_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Soltero", "Casado", "Divorciado", "Juntado" });
            checkedListBox1.Location = new Point(376, 352);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 9;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 352);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 10;
            label2.Text = "Estado Civil";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(134, 595);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(744, 188);
            dataGridView1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(590, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 483);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 817);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(pictureBox1);
            Controls.Add(rbtnFemenino);
            Controls.Add(rbtnMasculino);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(button1);
            Controls.Add(lblEdad);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Button button1;
        private TextBox txtNombre;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label label1;
        private RadioButton rbtnMasculino;
        private RadioButton rbtnFemenino;
        private PictureBox pictureBox1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel1;
    }
}
