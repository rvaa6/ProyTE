using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.DAL.Interfaces
{
    public interface IAlquileres
    {
        // Select *
        List<TbAlquileres> ListarAlquileres();
        // Select por PK
        TbAlquileres BuscarAlquiler(int idAlquiler);
        // Insert
        void InsertarAlquiler(TbAlquileres alquiler);
        // Update
        void ActualizarAlquiler(TbAlquileres alquiler);
        // Delete
        void EliminarAlquiler(int idAlquiler);
    }
}
