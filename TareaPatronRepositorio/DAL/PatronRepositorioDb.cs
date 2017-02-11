using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TareaPatronRepositorio.Entidades;

namespace TareaPatronRepositorio.DAL
{
    public class PatronRepositorioDb : DbContext
    {
        public PatronRepositorioDb() : base("ConStr")
        {

        }

        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Peliculas> Pelicula { get; set; }
        public DbSet<Categorias> Categoria { get; set; }
    }
}
