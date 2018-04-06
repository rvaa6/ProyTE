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

        [Required(ErrorMessage = "Medida requerida")]
        [StringLength(80, ErrorMessage = "Maximo 80 caracteres")]
        public string Medida { get; set; }

        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Descripcion { get; set; }
    }
}