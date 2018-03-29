using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.DAL.Interfaces
{
    public interface IRol_Permiso
    {
        // Select *
        List<TbRol_Permiso> ListarRol_Permisos();
        // Select por PK
        TbRol_Permiso BuscarRol_Permiso(int idRol_Permiso);
        // Insert
        void InsertarRol_Permiso(TbRol_Permiso rol_permiso);
        // Update
        void ActualizarRol_Permiso(TbRol_Permiso rol_permiso);
        // Delete
        void EliminarRol_Permiso(int idRol_Permiso);
    }
}
