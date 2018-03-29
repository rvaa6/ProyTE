using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MTipo_Tarjetas : MBase, ITipo_Tarjetas
    {
        public void ActualizarTipo_Tarjeta(TbTipo_Tarjetas tipoTarjeta)
        {
            tipTarj.ActualizarTipo_Tarjeta(tipoTarjeta);
        }

        public TbTipo_Tarjetas BuscarTipo_Tarjeta(int idTipo_Tarjeta)
        {
            return tipTarj.BuscarTipo_Tarjeta(idTipo_Tarjeta);
        }

        public void EliminarTipo_Tarjeta(int idTipo_Tarjeta)
        {
            tipTarj.EliminarTipo_Tarjeta(idTipo_Tarjeta);
        }

        public void InsertarTipo_Tarjeta(TbTipo_Tarjetas tipoTarjeta)
        {
            tipTarj.InsertarTipo_Tarjeta(tipoTarjeta);
        }

        public List<TbTipo_Tarjetas> ListarTipo_Tarjetas()
        {
            return tipTarj.ListarTipo_Tarjetas();
        }
    }
}
