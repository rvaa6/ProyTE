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

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido_1 { get; set; }

        public string Apellido_2 { get; set; }

        public int Telefono_1 { get; set; }

        public int? Telefono_2 { get; set; }

        public string Correo { get; set; }

        public string NombreUsuario { get; set; }

        public string Contrasenna { get; set; }

        public string Foto { get; set; }
    }
}