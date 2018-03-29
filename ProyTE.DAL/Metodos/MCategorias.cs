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
    public class MCategorias : MBase, ICategorias
    {
        public void ActualizarCategoria(TbCategorias categoria)
        {
            _db.Update(categoria);
        }

        public TbCategorias BuscarCategoria(int idCategoria)
        {
            return _db.Select<TbCategorias>(x => x.Id_Categoria == idCategoria).FirstOrDefault();
        }

        public void EliminarCategoria(int idCategoria)
        {
            _db.Delete<TbCategorias>(x => x.Id_Categoria == idCategoria);
        }

        public void InsertarCategoria(TbCategorias categoria)
        {
            _db.Insert(categoria);
        }

        public List<TbCategorias> ListarCategorias()
        {
            return _db.Select<TbCategorias>();
        }
    }
}
