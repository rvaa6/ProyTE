using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.BLL.Interfaces
{
    public interface IProductos
    {
        // Select *
        List<TbProductos> ListarProductos();
        // Select por PK
        TbProductos BuscarProducto(int idProducto);
        // Insert
        void InsertarProducto(TbProductos producto);
        // Update
        void ActualizarProducto(TbProductos producto);
        // Delete
        void EliminarProducto(int idProducto);
        //View de TBProductos-TbPrendas-TbCategorias
        List<ViewProducto> ListarVProductos();
    }
}
