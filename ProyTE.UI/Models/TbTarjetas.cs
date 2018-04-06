using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //tarjetas de los usuarios para los alquileres
    public class TbTarjetas
    {
        public int Id_Tarjeta { get; set; }

        public int Id_TipoTarjeta { get; set; }

        public string NombreTarjeta { get; set; }

        public decimal NumTarjeta { get; set; }

        public DateTime FechaVencimiento { get; set; }
    }
}