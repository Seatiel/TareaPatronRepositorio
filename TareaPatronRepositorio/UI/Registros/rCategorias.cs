using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TareaPatronRepositorio.Entidades;

namespace TareaPatronRepositorio.UI.Registros
{
    public partial class rCategorias : Form
    {
        public rCategorias()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            CategoriaIdtextBox.Clear();
            CategoriatextBox.Clear();
        }

        private Categorias LlenarCampos()
        {
            var categoria = new Categorias();
            categoria.Categoria = CategoriatextBox.Text;
            return categoria;
        }

        public bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(CategoriatextBox.Text))
            {
                CategoriaerrorProvider.SetError(CategoriatextBox, "Debe escribir la categoria.");
                retorno = false;
            }
            return retorno;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            //var categoria = new Categorias();
            //categoria = LlenarCampos();
            //if (!Validar())
            //{
            //    MessageBox.Show("Debe de completar los Campos.");
            //    return;
            //}
            //else if ()
            //{
            //    MessageBox.Show("Se ha guardado la Categoria.");
            //    Limpiar();
            //}
        }
    }
}
