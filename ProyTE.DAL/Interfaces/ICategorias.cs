using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;

namespace ProyTE.DAL.Interfaces
{
    public interface ICategorias
    {
        // Select *
        List<TbCategorias> ListarCategorias();
        // Select por PK
        TbCategorias BuscarCategoria(int idCategoria);
        // Insert
        void InsertarCategoria(TbCategorias categoria);
        // Update
        void ActualizarCategoria(TbCategorias categoria);
        // Delete
        void EliminarCategoria(int idCategoria);
    }
}
