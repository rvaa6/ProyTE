using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //Union de Alquiler y Productos
    public class TbAlquiler_Producto
    {
        public int Id_Alquiler_Producto { get; set; }

        public int Id_Alquiler { get; set; }

        public int Id_Producto { get; set; }
    }
}