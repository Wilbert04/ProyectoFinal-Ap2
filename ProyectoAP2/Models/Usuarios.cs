using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAP2.Models
{
    public class Usuarios
    {
        [Key]
        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        [Range(0, 1000000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Debe ingresar su nombre")]
        [MinLength(2, ErrorMessage = "El Nombre  muy corto")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar su apellido")]
        [MinLength(2, ErrorMessage = "Apellido muy corto")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Debe ingresar su email")]
        [EmailAddress(ErrorMessage = "Debe ingresar un Email valido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe ingresar su nombre se usuario")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Debe elegir un nivel de usuario.")]
        public string NivelUsuario { get; set; }

        [Required(ErrorMessage = "Debe ingresar una contraseña")]
        [MinLength(5, ErrorMessage = "La contraseña debe contener al menos 8 caracteres.")]
        public string Contrasena { get; set; }

        [Required(ErrorMessage = "Debe ingresar una contraseña")]
        [MinLength(5, ErrorMessage = "La contraseña debe contener al menos 8 caracteres.")]
        public string ConfirmarContrasena { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío")]
        [DisplayFormat(DataFormatString = "{0:dd,mm, yyyy}")]
        public DateTime FechaIngreso { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Email = string.Empty;
            Usuario = string.Empty;
            NivelUsuario = string.Empty;
            Contrasena = string.Empty;
            ConfirmarContrasena = string.Empty;
            FechaIngreso = DateTime.Now;

        }
    }

}