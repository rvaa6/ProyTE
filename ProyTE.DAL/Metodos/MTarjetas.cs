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
    public class MTarjetas : MBase, ITarjetas
    {
        public void ActualizarTarjeta(TbTarjetas tarjeta)
        {
            _db.Update(tarjeta);
        }

        public TbTarjetas BuscarTarjeta(int idTarjeta)
        {
            return _db.Select<TbTarjetas>(x => x.Id_Tarjeta == idTarjeta).FirstOrDefault();
        }

        public void EliminarTarjeta(int idTarjeta)
        {
            _db.Delete<TbTarjetas>(x => x.Id_Tarjeta == idTarjeta);
        }

        public void InsertarTarjeta(TbTarjetas tarjeta)
        {
            _db.Insert(tarjeta);
        }

        public List<TbTarjetas> ListarTarjetas()
        {
            return _db.Select<TbTarjetas>();
        }
    }
}
