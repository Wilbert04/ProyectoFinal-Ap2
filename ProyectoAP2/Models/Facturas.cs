using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAP2.Models
{
    public class Facturas
    {

        [Key]
        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        [Range(0, 100000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int FacturaId { get; set; }

        [Required(ErrorMessage = "El campo no puede estar vacio")]
        public int VehiculoId { get; set; }

        [Required(ErrorMessage = "El campo no puede estar vacio")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El campo no puede estar vacio")]
        public int ArticuloId { get; set; }

        [Required(ErrorMessage = "El campo no puede estar vació.")]
        public string Servicios { get; set; }

        public bool FacturaCredito { get; set; }

        [Range(0, 100000000, ErrorMessage = "El campo Subtotal no puede ser menor que cero")]
        [Required(ErrorMessage = "El campo Subtotal no debe estar vació")]
        public decimal SubTotal { get; set; }

        [Required(ErrorMessage = "El campo no puede estar vació.")]
        public decimal Itbis { get; set; }

        [Range(0, 100000000, ErrorMessage = "El campo Subtotal no puede ser menor que cero")]
        [Required(ErrorMessage = "El campo Subtotal no debe estar vació")]
        public decimal Total { get; set; }

        public DateTime ProximoMantemiento { get; set; }
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime Fecha { get; set; }


        [ForeignKey("FacturaId")]
        public virtual List<FacturaDetalle> Factura_Detalle { get; set; }

        public Facturas()
        {
            FacturaId = 0;
            VehiculoId = 0;
            ClienteId = 0;
            ArticuloId = 0;
            Servicios = string.Empty;
            FacturaCredito = false;
            SubTotal = 0;
            Itbis = 0;
            Total = 0;
            ProximoMantemiento = DateTime.Now.AddMonths(3);
            Fecha = DateTime.Now;
            Factura_Detalle = new List<FacturaDetalle>();
        }
    }
}
