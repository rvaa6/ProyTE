using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MAlquileres : MBase, IAlquileres
    {
        public void ActualizarAlquiler(TbAlquileres alquiler)
        {
            alqui.ActualizarAlquiler(alquiler);
        }

        public TbAlquileres BuscarAlquiler(int idAlquiler)
        {
            return alqui.BuscarAlquiler(idAlquiler);
        }

        public void EliminarAlquiler(int idAlquiler)
        {
            alqui.EliminarAlquiler(idAlquiler);
        }

        public void InsertarAlquiler(TbAlquileres alquiler)
        {
            alqui.InsertarAlquiler(alquiler);
        }

        public List<TbAlquileres> ListarAlquileres()
        {
            return alqui.ListarAlquileres();
        }
    }
}
