using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ProyTE.DATA
{
    //Tabla intermedia entre los roles y los permisos
    public class TbRol_Permiso
    {
        [AutoIncrement]
        public int Id_Rol_Permiso { get; set; }

        public int Id_Rol { get; set; }

        public int Id_Permiso { get; set; }

    }
}
