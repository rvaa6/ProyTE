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
    public class MTipo_Tarjetas : MBase, ITipo_Tarjetas
    {
        public void ActualizarTipo_Tarjeta(TbTipo_Tarjetas tipoTarjeta)
        {
            _db.Update(tipoTarjeta);
        }

        public TbTipo_Tarjetas BuscarTipo_Tarjeta(int idTipo_Tarjeta)
        {
            return _db.Select<TbTipo_Tarjetas>(x => x.Id_TipoTarjeta == idTipo_Tarjeta).FirstOrDefault();
        }

        public void EliminarTipo_Tarjeta(int idTipo_Tarjeta)
        {
            _db.Delete<TbTipo_Tarjetas>(x => x.Id_TipoTarjeta == idTipo_Tarjeta);
        }

        public void InsertarTipo_Tarjeta(TbTipo_Tarjetas tipoTarjeta)
        {
            _db.Insert(tipoTarjeta);
        }

        public List<TbTipo_Tarjetas> ListarTipo_Tarjetas()
        {
            return _db.Select<TbTipo_Tarjetas>();
        }
    }
}
