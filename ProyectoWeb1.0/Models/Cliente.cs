using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoWeb1._0.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        //subida de archivo
        //mas

        [MaxLength(15)]
        public string Codigo { get; set; }

        [MaxLength(50)]
        public string Nombres { get; set; }

        [MaxLength(50)]
        public string Apellidos { get; set; }

        public int GrupoDescuentoId { get; set; }

        public int CondicionPagoId { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}