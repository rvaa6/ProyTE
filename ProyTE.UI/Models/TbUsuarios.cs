using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //los usuarios del sistema, admin/clientes/empleados
    public class TbUsuarios
    {
        
        public int Id_Usuario { get; set; }

        public int Id_Rol { get; set; }

        [Required(ErrorMessage = "Cedula requerida")]
        [StringLength(20, ErrorMessage = "Maximo 20 caracteres")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Nombre requerido")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Primer Apellido requerido")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Apellido_1 { get; set; }

        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Apellido_2 { get; set; }

        [Required(ErrorMessage = "Teléfono requerido")]
        [Range(10000000, 99999999, ErrorMessage = "Número no valido")]
        public int Telefono_1 { get; set; }

        [Range(10000000, 99999999, ErrorMessage = "Número no valido")]
        public int? Telefono_2 { get; set; }

        [Required(ErrorMessage = "Correo requerido")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        [EmailAddress(ErrorMessage = "Correo no valido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Nombre de usuario requerido")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Contraseña requerida")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Contrasenna { get; set; }

        [StringLength(80, ErrorMessage = "Maximo 80 caracteres")]
        [FileExtensions]
        public string Foto { get; set; }
    }
}