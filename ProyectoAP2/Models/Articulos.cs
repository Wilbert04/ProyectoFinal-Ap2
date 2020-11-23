using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAP2.Models
{
    public class Articulos
    {
        [Key]

        public int ArticuloId { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        public string Descripcion { get; set; }

        [Required]
        [Range(minimum: 1, maximum: 999999999999, ErrorMessage = "Debe seleccionar un proveedor.")]
        public int ProveedorId { get; set; }

        [Required(ErrorMessage = "Debe elegir una categoria")]
        public string Categoria { get; set; }

        public int Existencia { get; set; }

        [Required(ErrorMessage = "El Costo es obligatorio.")]
        [Range(minimum: 1, maximum: 999999999999, ErrorMessage = "El Costo esta fuera del rango")]
        public decimal Costo { get; set; }

        [Required]
        [Range(minimum: 1, maximum: 999999999999, ErrorMessage = "El Precio esta fuera del rango.")]
        public decimal Precio { get; set; }

        [Required]
        [Range(minimum: 1, maximum: 100, ErrorMessage = "El porciento de ganancia debe ser mayor al 1%   y/o   menor al 100%")]
        public decimal Ganancias { get; set; }
        public DateTime Fecha { get; set; }

        public Articulos()
        {
            ArticuloId = 0;
            ProveedorId = 0;

            Categoria = string.Empty;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0;
            Precio = 0;
            Ganancias = 0;
            Fecha = DateTime.Now;
        }
    }
}
