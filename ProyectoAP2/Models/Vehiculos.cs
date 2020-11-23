using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAP2.Models
{
    public class Vehiculos
    {
        [Key]
        [Required(ErrorMessage = "El campo ID no puede estar vació.")]
        [Range(0, 1000000, ErrorMessage = "El campo ID no puede ser menor que 1 o mayor que 1000000.")]
        public int VehiculoId { get; set; }
        [Required(ErrorMessage = "El campo  no puede estar vació. debe Agregar un cliente")]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "El campo no puede estar vació.")]
        public string TipoVehiculo { get; set; }

        [Required(ErrorMessage = "Debe ingresar una descripcion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Debe ingresar la placa")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Debe ingresar el año")]
        public int Año { get; set; }
        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime Fecha { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Clientes Clientes { get; set; }

        public Vehiculos()
        {
            VehiculoId = 0;
            ClienteId = 0;
            TipoVehiculo = string.Empty;
            Descripcion = string.Empty;
            Placa = string.Empty;
            Año = 0;
            Fecha = DateTime.Now;

        }
    }
}
