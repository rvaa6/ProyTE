using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //Tabla intermedia entre los roles y los permisos
    public class TbRol_Permiso
    {
        public int Id_Rol_Permiso { get; set; }

        public int Id_Rol { get; set; }

        public int Id_Permiso { get; set; }
    }
}