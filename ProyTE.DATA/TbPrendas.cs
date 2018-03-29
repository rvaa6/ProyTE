using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ProyTE.DATA
{
    //Categorizacion de las prendas por precio
    public class TbPrendas
    {
        [AutoIncrement]
        public int Id_Prenda { get; set; }

        public int Id_Categoria { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

    }

}
