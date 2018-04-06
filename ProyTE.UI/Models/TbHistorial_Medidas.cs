using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //medida del usuario
    public class TbHistorial_Medidas
    {
        public int Id_HistorialMedidas { get; set; }

        public int Id_Usuario { get; set; }

        public string Medida { get; set; }

        public string Descripcion { get; set; }
    }
}