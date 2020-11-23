using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAP2.Models
{
    public class PedidoDetalle
    {

        [Key]
        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        [Range(0, 100000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        [Range(0, 100000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int PedidoId { get; set; }

        public int ProveedorId { get; set; }

        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        [Range(0, 100000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int ArticuloId { get; set; }

        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo  no debe estar vació")]
        [Range(0, 100000000, ErrorMessage = "El campo Unidad no puede ser menor que cero")]
        public int Unidad { get; set; }

        [Required(ErrorMessage = "El campo  no debe estar vació")]
        [Range(0, 100000000, ErrorMessage = "El campo  no puede ser menor que cero")]
        public decimal Precio { get; set; }

        public PedidoDetalle()
        {
            Id = 0;
            PedidoId = 0;
            ProveedorId = 0;
            ArticuloId = 0;
            Descripcion = string.Empty;
            Unidad = 0;
            Precio = 0;

        }

    }
}
