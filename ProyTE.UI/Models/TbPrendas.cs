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

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }
    }
}