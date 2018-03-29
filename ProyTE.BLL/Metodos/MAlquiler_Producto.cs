using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MAlquiler_Producto : MBase, IAlquiler_Producto
    {
        public void ActualizarAlquiler_Producto(TbAlquiler_Producto alquilerProducto)
        {
            alqProd.ActualizarAlquiler_Producto(alquilerProducto);
        }

        public TbAlquiler_Producto BuscarAlquiler_Producto(int idAlquiler_Producto)
        {
            return alqProd.BuscarAlquiler_Producto(idAlquiler_Producto);
        }

        public void EliminarAlquiler_Producto(int idAlquiler_Producto)
        {
            alqProd.EliminarAlquiler_Producto(idAlquiler_Producto);
        }

        public void InsertarAlquiler_Producto(TbAlquiler_Producto alquilerProducto)
        {
            alqProd.InsertarAlquiler_Producto(alquilerProducto);
        }

        public List<TbAlquiler_Producto> ListarAlquiler_Producto()
        {
            return alqProd.ListarAlquiler_Producto();
        }
    }
}
