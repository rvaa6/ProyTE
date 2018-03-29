using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.BLL.Interfaces
{
    public interface IUsuarios
    {
        // Select *
        List<TbUsuarios> ListarUsuarios();
        // Select por PK
        TbUsuarios BuscarUsuario(int idUsuario);
        // Insert
        void InsertarUsuario(TbUsuarios usuario);
        // Update
        void ActualizarUsuario(TbUsuarios usuario);
        // Delete
        void EliminarUsuario(int idUsuario);
    }
}
