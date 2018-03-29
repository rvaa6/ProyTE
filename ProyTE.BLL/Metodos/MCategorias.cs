using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MCategorias : MBase, ICategorias
    {
        public void ActualizarCategoria(TbCategorias categoria)
        {
            cat.ActualizarCategoria(categoria);
        }

        public TbCategorias BuscarCategoria(int idCategoria)
        {
            return cat.BuscarCategoria(idCategoria);
        }

        public void EliminarCategoria(int idCategoria)
        {
            cat.EliminarCategoria(idCategoria);
        }

        public void InsertarCategoria(TbCategorias categoria)
        {
            cat.InsertarCategoria(categoria);
        }

        public List<TbCategorias> ListarCategorias()
        {
            return cat.ListarCategorias();
        }
    }
}
