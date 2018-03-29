using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace ProyTE.DATA
{
    //Las categorias de las prendas
    public class TbCategorias
    {
        [AutoIncrement]
        public int Id_Categoria { get; set; }

        public string TipoCategoria { get; set; }

    }
}
