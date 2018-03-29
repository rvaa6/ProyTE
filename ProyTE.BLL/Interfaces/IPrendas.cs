using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.BLL.Interfaces
{
    public interface IPrendas
    {
        // Select *
        List<TbPrendas> ListarPrendas();
        // Select por PK
        TbPrendas BuscarPrenda(int idPrenda);
        // Insert
        void InsertarPrenda(TbPrendas prenda);
        // Update
        void ActualizarPrenda(TbPrendas prenda);
        // Delete
        void EliminarPrenda(int idPrenda);
    }
}
