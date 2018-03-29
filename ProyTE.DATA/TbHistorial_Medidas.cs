using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ProyTE.DATA
{
    //historial de las medidas del usuario 
    public class TbHistorial_Medidas
    {
        [AutoIncrement]
        public int Id_HistorialMedidas { get; set; }

        public int Id_Usuario { get; set; }

        public string Medida { get; set; }

        public string Descripcion { get; set; }

    }

}
