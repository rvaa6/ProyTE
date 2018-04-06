using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace ProyTE
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                // Aqui creo todos los mapeos
              //  cfg.CreateMap<Models.Producto, DATA.TbProductos>();
              //  cfg.CreateMap<DATA.TbProductos, Models.Producto>();
            });
        }
    }
}