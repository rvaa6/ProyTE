using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ProyTE.DATA
{
    //Productos con todas sus caracteristicas
    public class TbProductos
    {
        [AutoIncrement]
        public int Id_Producto { get; set; }

        public int Id_Prenda { get; set; }

        public string Talla { get; set; }

        public string Tela { get; set; }

        public string Color { get; set; }

        public string Descripcion { get; set; }

        public string Foto { get; set; }

    }

}
