using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MHistorial_Medidas : MBase, IHistorial_Medidas
    {
        public void ActualizarHistorial_Medidas(TbHistorial_Medidas historial_medida)
        {
            histMed.ActualizarHistorial_Medidas(historial_medida);
        }

        public TbHistorial_Medidas BuscarHistorial_Medida(int idHistorial_Medida)
        {
            return histMed.BuscarHistorial_Medida(idHistorial_Medida);
        }

        public void EliminarHistorial_Medida(int idHistorial_Medida)
        {
            histMed.EliminarHistorial_Medida(idHistorial_Medida);
        }

        public void InsertarHistorial_Medida(TbHistorial_Medidas historial_medida)
        {
            histMed.InsertarHistorial_Medida(historial_medida);
        }

        public List<TbHistorial_Medidas> ListarHistorial_Medidas()
        {
            return histMed.ListarHistorial_Medidas();
        }
    }
}
