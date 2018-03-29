using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.BLL.Interfaces
{
    public interface IHistorial_Medidas
    {
        // Select *
        List<TbHistorial_Medidas> ListarHistorial_Medidas();
        // Select por PK
        TbHistorial_Medidas BuscarHistorial_Medida(int idHistorial_Medida);
        // Insert
        void InsertarHistorial_Medida(TbHistorial_Medidas historial_medida);
        // Update
        void ActualizarHistorial_Medidas(TbHistorial_Medidas historial_medida);
        // Delete
        void EliminarHistorial_Medida(int idHistorial_Medida);
    }
}
