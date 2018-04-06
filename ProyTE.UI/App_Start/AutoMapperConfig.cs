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
                cfg.CreateMap<UI.Models.TbAlquiler_Producto, DATA.TbAlquiler_Producto>();
                cfg.CreateMap<DATA.TbAlquiler_Producto, UI.Models.TbAlquiler_Producto>();

                cfg.CreateMap<UI.Models.TbAlquileres, DATA.TbAlquileres>();
                cfg.CreateMap<DATA.TbAlquileres, UI.Models.TbAlquileres>();

                cfg.CreateMap<UI.Models.TbCategorias, DATA.TbCategorias>();
                cfg.CreateMap<DATA.TbCategorias, UI.Models.TbCategorias>();

                cfg.CreateMap<UI.Models.TbHistorial_Medidas, DATA.TbHistorial_Medidas>();
                cfg.CreateMap<DATA.TbHistorial_Medidas, UI.Models.TbHistorial_Medidas>();

                cfg.CreateMap<UI.Models.TbPermisos, DATA.TbPermisos>();
                cfg.CreateMap<DATA.TbPermisos, UI.Models.TbPermisos>();

                cfg.CreateMap<UI.Models.TbPrendas, DATA.TbPrendas>();
                cfg.CreateMap<DATA.TbPrendas, UI.Models.TbPrendas>();

                cfg.CreateMap<UI.Models.TbProductos, DATA.TbProductos>();
                cfg.CreateMap<DATA.TbProductos, UI.Models.TbProductos>();

                cfg.CreateMap<UI.Models.TbRol_Permiso, DATA.TbRol_Permiso>();
                cfg.CreateMap<DATA.TbRol_Permiso, UI.Models.TbRol_Permiso>();

                cfg.CreateMap<UI.Models.TbRoles, DATA.TbRoles>();
                cfg.CreateMap<DATA.TbRoles, UI.Models.TbRoles>();

                cfg.CreateMap<UI.Models.TbTarjetas, DATA.TbTarjetas>();
                cfg.CreateMap<DATA.TbTarjetas, UI.Models.TbTarjetas>();

                cfg.CreateMap<UI.Models.TbTipo_Tarjetas, DATA.TbTipo_Tarjetas>();
                cfg.CreateMap<DATA.TbTipo_Tarjetas, UI.Models.TbTipo_Tarjetas>();

                cfg.CreateMap<UI.Models.TbUsuario_Tarjeta, DATA.TbUsuario_Tarjeta>();
                cfg.CreateMap<DATA.TbUsuario_Tarjeta, UI.Models.TbUsuario_Tarjeta>();

                cfg.CreateMap<UI.Models.TbUsuarios, DATA.TbUsuarios>();
                cfg.CreateMap<DATA.TbUsuarios, UI.Models.TbUsuarios>();

                cfg.CreateMap<UI.Models.ViewProducto, DATA.ViewProducto>();
                cfg.CreateMap<DATA.ViewProducto, UI.Models.ViewProducto>();
            });
        }
    }
}