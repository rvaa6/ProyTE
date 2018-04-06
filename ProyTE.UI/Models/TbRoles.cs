using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //roles disponibles para los usuarios
    public class TbRoles
    {
        public int Id_Rol { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public bool Estado { get; set; }
    }
}