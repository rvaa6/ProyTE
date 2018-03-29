using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MUsuario_Tarjeta : MBase, IUsuario_Tarjeta
    {
        public void ActualizarUsuario_Tarjeta(TbUsuario_Tarjeta usuarioTarjeta)
        {
            usuTarj.ActualizarUsuario_Tarjeta(usuarioTarjeta);
        }

        public TbUsuario_Tarjeta BuscarUsuario_Tarjeta(int idUsuario_Tarjeta)
        {
            return usuTarj.BuscarUsuario_Tarjeta(idUsuario_Tarjeta);
        }

        public void EliminarUsuario_Tarjeta(int idUsuario_Tarjeta)
        {
            usuTarj.EliminarUsuario_Tarjeta(idUsuario_Tarjeta);
        }

        public void InsertarUsuario_Tarjeta(TbUsuario_Tarjeta usuarioTarjeta)
        {
            usuTarj.InsertarUsuario_Tarjeta(usuarioTarjeta);
        }

        public List<TbUsuario_Tarjeta> ListarUsuario_Tarjetas()
        {
            return usuTarj.ListarUsuario_Tarjetas();
        }
    }
}
