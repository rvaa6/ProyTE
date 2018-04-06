using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //Union de las tarjetas con los usuarios
    public class TbUsuario_Tarjeta
    {
        public int Id_Usuario_Tarjeta { get; set; }

        public int Id_Usuario { get; set; }

        public int Id_Tarjeta { get; set; }
    }
}