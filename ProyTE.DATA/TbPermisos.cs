using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ProyTE.DATA
{
    //Permisos que tiene los roles
    public class TbPermisos
    {
        [AutoIncrement]
        public int Id_Permiso { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

    }

}
