using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TareaPatronRepositorio.Entidades
{
    public class Peliculas
    {
        [Key]
        public int PeliculaId { get; set; }
        public string Estreno { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int CategoriaId { get; set; }

        public Peliculas()
        {

        }

        public Peliculas(int peliculaId, string estreno, string descripcion, DateTime fecha, int categoriaId)
        {
            this.PeliculaId = peliculaId;
            this.Estreno = estreno;
            this.Descripcion = descripcion;
            this.Fecha = fecha;
            this.CategoriaId = categoriaId;
        }

    }
}
