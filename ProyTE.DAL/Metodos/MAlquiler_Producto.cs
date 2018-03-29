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
    public class MAlquiler_Producto : MBase, IAlquiler_Producto
    {
        public void ActualizarAlquiler_Producto(TbAlquiler_Producto alquilerProducto)
        {
            _db.Update(alquilerProducto);
        }

        public TbAlquiler_Producto BuscarAlquiler_Producto(int idAlquiler_Producto)
        {
            return _db.Select<TbAlquiler_Producto>(x => x.Id_Alquiler_Producto == idAlquiler_Producto)
                .FirstOrDefault();
        }

        public void EliminarAlquiler_Producto(int idAlquiler_Producto)
        {
            _db.Delete<TbAlquiler_Producto>(x => x.Id_Alquiler_Producto == idAlquiler_Producto);
        }

        public void InsertarAlquiler_Producto(TbAlquiler_Producto alquilerProducto)
        {
            _db.Insert(alquilerProducto);
        }

        public List<TbAlquiler_Producto> ListarAlquiler_Producto()
        {
            return _db.Select<TbAlquiler_Producto>();
        }
    }
}
