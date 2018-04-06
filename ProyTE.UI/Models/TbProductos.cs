using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //Productos con todas sus caracteristicas
    public class TbProductos
    {
        public int Id_Producto { get; set; }

        public int Id_Prenda { get; set; }

        [Required(ErrorMessage = "Talla requerida")]
        [StringLength(10, ErrorMessage = "Maximo 10 caracteres")]
        public string Talla { get; set; }

        [Required(ErrorMessage = "Tela requerida")]
        [StringLength(25, ErrorMessage = "Maximo 25 caracteres")]
        public string Tela { get; set; }

        [Required(ErrorMessage = "Color requerido")]
        [StringLength(25, ErrorMessage = "Maximo 25 caracteres")]
        public string Color { get; set; }

        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Descripcion { get; set; }

        [StringLength(80, ErrorMessage = "Maximo 80 caracteres")]
        [FileExtensions]
        public string Foto { get; set; }
    }
}