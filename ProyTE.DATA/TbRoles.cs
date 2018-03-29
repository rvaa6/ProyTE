using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ProyTE.DATA
{
    //roles disponibles para los usuarios
    public class TbRoles
    {
        [AutoIncrement]
        public int Id_Rol { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public bool Estado { get; set; }

    }

}
