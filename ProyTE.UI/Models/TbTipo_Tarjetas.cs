using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //mastercard/visa/etc.
    public class TbTipo_Tarjetas
    {
        public int Id_TipoTarjeta { get; set; }

        [Required(ErrorMessage = "Descripción requerida")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Descripcion { get; set; }
    }
}