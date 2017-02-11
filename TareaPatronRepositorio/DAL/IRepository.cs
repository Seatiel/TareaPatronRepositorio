using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TareaPatronRepositorio.DAL
{
    /// Sera de un tipo Generico TEntity para que acepte cualquier entidad 
    /// Tambien Implementamos IDisposable para poder destruirla
    /// where TEntity:class, finalmente TEntity sera una clase que puede ser null , osea que sea un tipo referencia a final de cuentas.

    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Guardar(TEntity laEntidad);

        bool Modificar(TEntity laEntidad);

        bool Eliminar(TEntity laEntidad);

        /// La expession sera un delegado que es una funcion que permitira buscar por la condicion que definamos
        TEntity Buscar(Expression<Func<TEntity, bool>> criterioBusqueda);

        List<TEntity> Lista(Expression<Func<TEntity, bool>> criterioBusqueda);
    }
}
