using Pruebas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class Form2 : Form
    {
        BindingList<Usuario> _listaUsuarios;

        public Form2(BindingList<Usuario> listaUsuarios)
        {
            _listaUsuarios = listaUsuarios;

            InitializeComponent();
        }

        public void Metodo(int valor, int valor2)
        {
            // Escribir en un txt log, los valores 1 y 2
            
            /// Ejecutar lineas
        }

        public int Sumar(int valor, int valor2)
        {
            int suma = valor + valor2;

            Metodo(valor, valor2);

            return suma;
        }
    }
}
