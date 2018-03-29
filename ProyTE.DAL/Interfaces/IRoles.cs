using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.DAL.Interfaces
{
    public interface IRoles
    {
        // Select *
        List<TbRoles> ListarRoles();
        // Select por PK
        TbRoles BuscarRol(int idRol);
        // Insert
        void InsertarRol(TbRoles rol);
        // Update
        void ActualizarRol(TbRoles rol);
        // Delete
        void EliminarRol(int idRol);
    }
}
