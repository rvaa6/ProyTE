using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.DAL.Interfaces
{
    public interface IPermisos
    {
        // Select *
        List<TbPermisos> ListarPermisos();
        // Select por PK
        TbPermisos BuscarPermiso(int idPermiso);
        // Insert
        void InsertarPermiso(TbPermisos permiso);
        // Update
        void ActualizarPermiso(TbPermisos permiso);
        // Delete
        void EliminarPermiso(int idPermiso);
    }
}
