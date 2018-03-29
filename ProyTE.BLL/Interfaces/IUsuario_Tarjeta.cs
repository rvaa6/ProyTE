using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.BLL.Interfaces
{
    public interface IUsuario_Tarjeta
    {
        // Select *
        List<TbUsuario_Tarjeta> ListarUsuario_Tarjetas();
        // Select por PK
        TbUsuario_Tarjeta BuscarUsuario_Tarjeta(int idUsuario_Tarjeta);
        // Insert
        void InsertarUsuario_Tarjeta(TbUsuario_Tarjeta usuarioTarjeta);
        // Update
        void ActualizarUsuario_Tarjeta(TbUsuario_Tarjeta usuarioTarjeta);
        // Delete
        void EliminarUsuario_Tarjeta(int idUsuario_Tarjeta);
    }
}
