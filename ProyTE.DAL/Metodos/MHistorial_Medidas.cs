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
    public class MHistorial_Medidas : MBase, IHistorial_Medidas
    {
        public void ActualizarHistorial_Medidas(TbHistorial_Medidas historial_medida)
        {
            _db.Update(historial_medida);
        }

        public TbHistorial_Medidas BuscarHistorial_Medida(int idHistorial_Medida)
        {
            return _db.Select<TbHistorial_Medidas>(x => x.Id_HistorialMedidas == idHistorial_Medida).FirstOrDefault();
        }

        public void EliminarHistorial_Medida(int idHistorial_Medida)
        {
            _db.Delete<TbHistorial_Medidas>(x => x.Id_HistorialMedidas == idHistorial_Medida);
        }

        public void InsertarHistorial_Medida(TbHistorial_Medidas historial_medida)
        {
            _db.Insert(historial_medida);
        }

        public List<TbHistorial_Medidas> ListarHistorial_Medidas()
        {
            return _db.Select<TbHistorial_Medidas>();
        }
    }
}
