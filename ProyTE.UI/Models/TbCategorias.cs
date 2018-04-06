using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //Categorias de las prendas Bebe, Niño, Adulto, Talla Grande
    public class TbCategorias
    {
        public int Id_Categoria { get; set; }

        public string TipoCategoria { get; set; }
    }
}