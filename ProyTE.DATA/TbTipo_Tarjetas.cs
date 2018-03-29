using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ProyTE.DATA
{
    //mastercard/visa/etc.
    public class TbTipo_Tarjetas
    {
        [AutoIncrement]
        public int Id_TipoTarjeta { get; set; }

        public string Descripcion { get; set; }

    }
}
