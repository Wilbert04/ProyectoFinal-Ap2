using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAP2.Models
{
    public class FacturaDetalle
    {
        [Key]

        public int Id { get; set; }
        public int FacturaId { get; set; }

        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        [Range(0, 100000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int ArticuloId { get; set; }

        [Required(ErrorMessage = "El campo nombre no puede estar vació.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo  no debe estar vació")]
        [Range(0, 100000000, ErrorMessage = "El campo Cantidad no puede ser menor que cero")]
        public int Cantidad { get; set; }

        public decimal Precio { get; set; }
        public decimal Importe { get; set; }


        public FacturaDetalle()
        {
            Id = 0;
            FacturaId = 0;
            ArticuloId = 0;
            Descripcion = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Importe = 0;
        }

    }
}
