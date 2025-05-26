using Microsoft.VisualBasic.Logging;
using System.Xml;

namespace Pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Este es el codigo que se va ejecutar el hacer click en el boton            

            if (string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Los campos son requeridos");
                return;
            }

            string nombre = txtNombre.Text;
            int edad = Convert.ToInt16(txtEdad.Text);

            string estadoCivil = checkedListBox1.CheckedItems[0].ToString();

            string sexo = string.Empty;
            string msj = string.Empty;

            switch (estadoCivil)
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
                sexo = "Masculino";
            }

            if (rbtnFemenino.Checked)
            {
                sexo = "Femenino";
            }

            MessageBox.Show("Nombre de usuario: " + nombre + Environment.NewLine +
                "Edad de usuario: " + edad + " años. " + Environment.NewLine +
                "Sexo: " + sexo + Environment.NewLine +
                "Estado Civil: " + estadoCivil + Environment.NewLine +
                "Mensaje: " + msj, "Datos del usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
    }
}
