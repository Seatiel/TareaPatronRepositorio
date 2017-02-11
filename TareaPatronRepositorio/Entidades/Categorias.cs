using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TareaPatronRepositorio.Entidades
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Categoria { get; set; }

        public Categorias()
        {

        }
        public Categorias(string categoria)
        {
            this.Categoria = categoria;
        }

        public Categorias(int categoriaId, string categoria)
        {
            this.CategoriaId = categoriaId;
            this.Categoria = categoria;
        }
    }
}
