using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ProyTE.DATA
{
    //tarjetas de los usuarios para los alquileres
    public class TbTarjetas
    {
        [AutoIncrement]
        public int Id_Tarjeta { get; set; }

        public int Id_TipoTarjeta { get; set; }

        public string NombreTarjeta { get; set; }

        public decimal NumTarjeta { get; set; }

        public DateTime FechaVencimiento { get; set; }

    }
}
