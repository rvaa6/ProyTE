using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.DAL.Interfaces;
using System.Data;
using ServiceStack.OrmLite;

namespace ProyTE.DAL.Metodos
{
    public class MProductos : MBase, IProductos
    {
        public void ActualizarProducto(TbProductos producto)
        {
            _db.Update(producto);
        }

        public TbProductos BuscarProducto(int idProducto)
        {
            return _db.Select<TbProductos>(x => x.Id_Producto == idProducto).FirstOrDefault();
        }

        public void EliminarProducto(int idProducto)
        {
            _db.Delete<TbProductos>(x => x.Id_Producto == idProducto);
        }

        public void InsertarProducto(TbProductos producto)
        {
            _db.Insert(producto);
        }

        public List<TbProductos> ListarProductos()
        {
            return _db.Select<TbProductos>();
        }

        public List<ViewProducto> ListarVProductos()
        {
            return _db.SqlList<ViewProducto>("EXEC sp_VerProductos");
        }
    }
}
