using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ProyTE.DATA
{
    //Intermedia de Alquileres y Productos
    public class TbAlquiler_Producto
    {
        //Prueba
        [AutoIncrement]
        public int Id_Alquiler_Producto { get; set; }

        public int Id_Alquiler { get; set; }

        public int Id_Producto { get; set; }

    }

}
