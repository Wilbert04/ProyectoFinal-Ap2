using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAP2.Models
{
    public class Proveedores
    {
        [Key]
        [Required(ErrorMessage = "El campo ID no puede estar vació.")]
        [Range(0, 1000000, ErrorMessage = "El campo ID no puede ser menor que 1 o mayor que 1000000.")]
        public int ProveedorId { get; set; }

        [Required(ErrorMessage = "El campo nombre no puede estar vació.")]
        [MinLength(3, ErrorMessage = "El campo lo minimo debe terner 3 caracteres.")]
        [MaxLength(40, ErrorMessage = "El nombre es muy largo.")]
        [RegularExpression(@"\S(.*)\S", ErrorMessage = "Debe ser un texto.")]


        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar su telefono")]

        [Phone(ErrorMessage = "Debes de ingresar tu número telefonico.")]
        [MaxLength(10, ErrorMessage = "El campo telefono no tiene más de diez dígitos.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe ingresar su email")]
        [EmailAddress(ErrorMessage = "Debe ingresar un Email valido.")]

        public string Email { get; set; }

        [Required(ErrorMessage = "El campo Dirección no debe de estar vació.")]
        [MinLength(10, ErrorMessage = "La dirección es muy corta.")]
        [MaxLength(100, ErrorMessage = "La dirección debe contener menos de 40 caracteres.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Debe ingresar su RNC")]

        public string RNC { get; set; }

        public int CantidadPedidos { get; set; }
        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime Fecha { get; set; }

        public Proveedores()
        {
            ProveedorId = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
            Direccion = string.Empty;
            RNC = string.Empty;
            CantidadPedidos = 0;
            Fecha = DateTime.Now;
        }
    }
}
