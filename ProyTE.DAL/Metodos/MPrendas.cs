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
    public class MPrendas : MBase, IPrendas
    {
        public void ActualizarPrenda(TbPrendas prenda)
        {
            _db.Update(prenda);
        }

        public TbPrendas BuscarPrenda(int idPrenda)
        {
            return _db.Select<TbPrendas>(x => x.Id_Prenda == idPrenda).FirstOrDefault();
        }

        public void EliminarPrenda(int idPrenda)
        {
            _db.Delete<TbPrendas>(x => x.Id_Prenda == idPrenda);
        }

        public void InsertarPrenda(TbPrendas prenda)
        {
            _db.Insert(prenda);
        }

        public List<TbPrendas> ListarPrendas()
        {
            return _db.Select<TbPrendas>();
        }
    }
}
