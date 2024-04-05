using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWeb1._0.Models

{ 
    [Table("Categorias")]
    public class Categorias
    {
        [Key]
        public int CategoriasId { get; set; }

        [MaxLength(50)]
        public string Codigo { get; set; }

        [MaxLength(50)]
        public string Descripcion { get; set; }

        [MaxLength(50)]
        public bool Estado { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}