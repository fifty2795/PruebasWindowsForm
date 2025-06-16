using Microsoft.VisualBasic.Logging;
using Pruebas.Entidades;
using System.ComponentModel;
using System.Xml;

namespace Pruebas
{
    public partial class Form1 : Form
    {
        BindingList<Usuario> listaUsuarios = new BindingList<Usuario>();
        List<Usuario> lstUsuario = new List<Usuario>();        

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = listaUsuarios;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Este es el codigo que se va ejecutar el hacer click en el boton            
            Usuario usuario = new Usuario();

            if (string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Los campos son requeridos");
                return;
            }

            usuario.Nombre = txtNombre.Text;
            usuario.Edad = Convert.ToInt16(txtEdad.Text);
            usuario.EstadoCivil = checkedListBox1.CheckedItems[0].ToString();

            string msj = string.Empty;

            switch (usuario.EstadoCivil)
            {
                case "Soltero":

                    msj = "Sigue soltero";

                    break;
                case "Casado":

                    msj = "Felicidades por casarte";

                    break;
                case "Divorciado":

                    msj = "Busca otra pareja";

                    break;
                case "Juntado":

                    msj = "Ya casate pronto";

                    break;
                default:
                    break;
            }

            if (rbtnMasculino.Checked)
            {
                usuario.Sexo = "Masculino";
            }

            if (rbtnFemenino.Checked)
            {
                usuario.Sexo = "Femenino";
            }

            //MessageBox.Show("Nombre de usuario: " + usuario.Nombre + Environment.NewLine +
            //    "Edad de usuario: " + usuario.Edad.ToString() + " años. " + Environment.NewLine +
            //    "Sexo: " + usuario.Sexo + Environment.NewLine +
            //    "Estado Civil: " + usuario.EstadoCivil + Environment.NewLine +
            //    "Mensaje: " + msj, "Datos del usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            DialogResult result = MessageBox.Show("Nombre de usuario: " + usuario.Nombre + Environment.NewLine +
                "Edad de usuario: " + usuario.Edad.ToString() + " años. " + Environment.NewLine +
                "Sexo: " + usuario.Sexo + Environment.NewLine +
                "Estado Civil: " + usuario.EstadoCivil + Environment.NewLine +
                "Mensaje: " + msj + Environment.NewLine + Environment.NewLine +
                "¿Desesas agregar este usuario?",
                "Agregar Usuario",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                listaUsuarios.Add(usuario);
                LimpiarFormulario();
                lstUsuario.Add(usuario);
            }
        }

        private void rbtnFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control keys como backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear tecla
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Desmarcar el resto de los elementos
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;

            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }         
        }        

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
