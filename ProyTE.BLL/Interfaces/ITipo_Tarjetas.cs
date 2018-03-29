using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.BLL.Interfaces
{
    public interface ITipo_Tarjetas
    {
        // Select *
        List<TbTipo_Tarjetas> ListarTipo_Tarjetas();
        // Select por PK
        TbTipo_Tarjetas BuscarTipo_Tarjeta(int idTipo_Tarjeta);
        // Insert
        void InsertarTipo_Tarjeta(TbTipo_Tarjetas tipoTarjeta);
        // Update
        void ActualizarTipo_Tarjeta(TbTipo_Tarjetas tipoTarjeta);
        // Delete
        void EliminarTipo_Tarjeta(int idTipo_Tarjeta);
    }
}
