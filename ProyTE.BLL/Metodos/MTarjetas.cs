using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MTarjetas : MBase, ITarjetas
    {
        public void ActualizarTarjeta(TbTarjetas tarjeta)
        {
            tarj.ActualizarTarjeta(tarjeta);
        }

        public TbTarjetas BuscarTarjeta(int idTarjeta)
        {
            return tarj.BuscarTarjeta(idTarjeta);
        }

        public void EliminarTarjeta(int idTarjeta)
        {
            tarj.EliminarTarjeta(idTarjeta);
        }

        public void InsertarTarjeta(TbTarjetas tarjeta)
        {
            tarj.InsertarTarjeta(tarjeta);
        }

        public List<TbTarjetas> ListarTarjetas()
        {
            return tarj.ListarTarjetas();
        }
    }
}
