using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;

namespace ProyTE.BLL.Metodos
{
    public class MPrendas : MBase, IPrendas
    {
        public void ActualizarPrenda(TbPrendas prenda)
        {
            prend.ActualizarPrenda(prenda);
        }

        public TbPrendas BuscarPrenda(int idPrenda)
        {
            return prend.BuscarPrenda(idPrenda);
        }

        public void EliminarPrenda(int idPrenda)
        {
            prend.EliminarPrenda(idPrenda);
        }

        public void InsertarPrenda(TbPrendas prenda)
        {
            prend.InsertarPrenda(prenda);
        }

        public List<TbPrendas> ListarPrendas()
        {
            return prend.ListarPrendas();
        }
    }
}
