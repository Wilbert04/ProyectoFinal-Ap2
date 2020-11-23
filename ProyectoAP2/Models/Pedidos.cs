using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAP2.Models
{
    public class Pedidos
    {
        [Key]
        [Required(ErrorMessage = "El campo ID no puede estar vació.")]
        [Range(0, 1000000, ErrorMessage = "El campo ID no puede ser menor que 1 o mayor que 1000000.")]
        public int PedidoId { get; set; }

        [Required(ErrorMessage = "El campo  no puede estar vació.")]
        public int ArticuloId { get; set; }

        [Required(ErrorMessage = "El campo  no puede estar vació.")]
        public int ProveedorId { get; set; }

        [Required(ErrorMessage = "El campo  no puede estar vació.")]
        public string Nota { get; set; }

        [Range(0, 100000000, ErrorMessage = "El campo Subtotal no puede ser menor que cero")]
        [Required(ErrorMessage = "El campo Subtotal no debe estar vació")]
        public decimal Subtotal { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime Fecha { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime FechaEntrega { get; set; }


        [ForeignKey("PedidoId")]
        public virtual List<PedidoDetalle> Pedido_Detalle { get; set; } = new List<PedidoDetalle>();

        public Pedidos()
        {
            PedidoId = 0;
            ArticuloId = 0;
            ProveedorId = 0;
            Subtotal = 0;
            Nota = string.Empty;
            Fecha = DateTime.Now;
            FechaEntrega = DateTime.Now.AddDays(15);
            Pedido_Detalle = new List<PedidoDetalle>();


        }
    }
}
