using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MProductos : MBase, IProductos
    {
        public void ActualizarProducto(TbProductos producto)
        {
            produc.ActualizarProducto(producto);
        }

        public TbProductos BuscarProducto(int idProducto)
        {
            return produc.BuscarProducto(idProducto);
        }

        public void EliminarProducto(int idProducto)
        {
            produc.EliminarProducto(idProducto);
        }

        public void InsertarProducto(TbProductos producto)
        {
            produc.InsertarProducto(producto);
        }

        public List<TbProductos> ListarProductos()
        {
            return produc.ListarProductos();
        }

        public List<ViewProducto> ListarVProductos()
        {
            return produc.ListarVProductos();
        }
    }
}
