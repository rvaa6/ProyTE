using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyTE.DATA
{
    //vista completa de un producto
    public class ViewProducto
    {
        public int Id_Producto { get; set; }
        //TbPrendas
        public string NomPrenda { get; set; }

        public decimal PrecioPrenda { get; set; }
        //TbCategorias
        public string TipoCategoria { get; set; }
        //TbProductos
        public string Talla { get; set; }

        public string Tela { get; set; }

        public string Color { get; set; }

        public string Descripcion { get; set; }

        public string Foto { get; set; }
    }
}
