using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //categorizacion por precio 
    public class TbPrendas
    {
        public int Id_Prenda { get; set; }

        public int Id_Categoria { get; set; }

        [Required(ErrorMessage = "Nombre de prenda requerido")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Nombre { get; set; }

        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Precio requerido")]
        [Range(5000, 500000, ErrorMessage = "El Precio debe ser entre 5000 - 500000")]
        public decimal Precio { get; set; }
    }
}