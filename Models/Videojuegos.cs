using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace semana4.Models
{
    [Table("t_producto")]
    public class Videojuegos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("categoria")]
        public string Categoria { get; set; }
        [Column("precio")]
        public string Precio {get; set;}
        [Column("descuento")]
        public string Descuento {get; set; }     
    }
}