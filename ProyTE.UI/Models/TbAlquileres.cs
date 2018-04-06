using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyTE.UI.Models
{
    //Facturas
    public class TbAlquileres
    {
        public int Id_Alquiler { get; set; }

        public int Id_Usuario { get; set; }

        [Required(ErrorMessage = "Estado requerido")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Entrega requerida")]
        public DateTime Entrega { get; set; }

        [Required(ErrorMessage = "Devolucion requerida")]
        public DateTime Devuelve { get; set; }

        [Required(ErrorMessage = "Precio requerido")]
        [Range(5000, 500000, ErrorMessage = "El Precio debe ser entre 5000 - 500000")]
        public decimal Precio { get; set; }

        [Range(5000, 500000, ErrorMessage = "La multa debe ser entre 5000 - 500000")]
        public decimal? Multa { get; set; }

        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Reparacion { get; set; }

        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Detalle { get; set; }

        [Required(ErrorMessage = "Fecha de alquiler requerida")]
        public DateTime FechaAlquiler { get; set; }
    }
}