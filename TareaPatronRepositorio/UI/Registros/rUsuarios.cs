using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TareaPatronRepositorio.BLL;
using TareaPatronRepositorio.DAL;
using TareaPatronRepositorio.Entidades;

namespace TareaPatronRepositorio.UI.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private Usuarios LlenarCampos()
        {
            var usuario = new Usuarios();
            usuario.NombreUsuario = NombreUsuariostextBox.Text;
            usuario.Clave = ClavetextBox.Text;
            return usuario;
        }

        public void Limpiar()
        {
            UsuarioIdtextBox.Clear();
            NombreUsuariostextBox.Clear();
            ClavetextBox.Clear();
            ConfirmarClavetextBox.Clear();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(NombreUsuariostextBox.Text))
            {
                NombreUsuarioerrorProvider.SetError(NombreUsuariostextBox, "Debe introducir el Nombre del Usuario");
                if (string.IsNullOrEmpty(ClavetextBox.Text))
                {
                    ClaveerrorProvider.SetError(ClavetextBox, "Debe introducir la Contraseña");
                    if (string.IsNullOrEmpty(ConfirmarClavetextBox.Text))
                    {
                        ConfirmarClaveerrorProvider.SetError(ConfirmarClavetextBox, "Debe introducir la Contraseña de confirmacion");
                    }
                }
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
            var usuario = new Usuarios();
            usuario = LlenarCampos();
            if (ClavetextBox.Text == ConfirmarClavetextBox.Text)
            {
                if (!Validar())
                {
                    MessageBox.Show("Debe llenar los Campos vacios");
                }
                else
                if (PatronRepositorioBLL.Guardar(usuario))
                {
                    MessageBox.Show("El usuario ha sido Guardado.");
                    Limpiar();
                }                
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();
            if (PatronRepositorioBLL.Eliminar(usuario))
            {
                MessageBox.Show("Se ha eliminado");
            }
        }
    }
}
