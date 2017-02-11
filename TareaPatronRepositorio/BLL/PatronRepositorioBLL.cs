using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TareaPatronRepositorio.Entidades;

namespace TareaPatronRepositorio.BLL
{
    public class PatronRepositorioBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool retorno = false;
            using (var repositorio = new DAL.Repositorio<Usuarios>())
            {
                retorno = repositorio.Guardar(usuario) != null;
            }
            return retorno;
        }

        public static bool Eliminar(Usuarios usuario)
        {
            bool retorno = false;
            using (var repositorio = new DAL.Repositorio<Usuarios>())
            {
                retorno = repositorio.Eliminar(usuario); //!= null;
            }
            return retorno;
        }

        //public static bool Buscar(int id)
        //{
        //    bool retorno = false;
        //    using (var repositorio = new DAL.Repositorio<Usuarios>())
        //    {
        //        retorno = repositorio.Buscar;
        //    }
        //    return retorno;
        //}
    }
}
