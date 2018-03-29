using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.DAL.Interfaces
{
    public interface ITarjetas
    {
        // Select *
        List<TbTarjetas> ListarTarjetas();
        // Select por PK
        TbTarjetas BuscarTarjeta(int idTarjeta);
        // Insert
        void InsertarTarjeta(TbTarjetas tarjeta);
        // Update
        void ActualizarTarjeta(TbTarjetas tarjeta);
        // Delete
        void EliminarTarjeta(int idTarjeta);
    }
}
