using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ProyTE.DATA
{
    //Union de las tarjetas con los usuarios
    public class TbUsuario_Tarjeta
    {
        [AutoIncrement]
        public int Id_Usuario_Tarjeta { get; set; }

        public int Id_Usuario { get; set; }

        public int Id_Tarjeta { get; set; }

    }

}
