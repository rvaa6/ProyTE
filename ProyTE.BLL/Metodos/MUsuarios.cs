using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MUsuarios : MBase, IUsuarios
    {
        public void ActualizarUsuario(TbUsuarios usuario)
        {
            usu.ActualizarUsuario(usuario);
        }

        public TbUsuarios BuscarUsuario(int idUsuario)
        {
            return usu.BuscarUsuario(idUsuario);
        }

        public void EliminarUsuario(int idUsuario)
        {
            usu.EliminarUsuario(idUsuario);
        }

        public void InsertarUsuario(TbUsuarios usuario)
        {
            usu.InsertarUsuario(usuario);
        }

        public List<TbUsuarios> ListarUsuarios()
        {
            return usu.ListarUsuarios();
        }
    }
}
