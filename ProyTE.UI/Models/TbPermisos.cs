using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //Permisos de los roles
    public class TbPermisos
    {
        public int Id_Permiso { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}