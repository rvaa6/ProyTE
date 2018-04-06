using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyTE.UI.Models;
using ProyTE.DATA;
using ProyTE.BLL.Interfaces;
using ProyTE.BLL.Metodos;
using AutoMapper;

namespace ProyTE.UI.Controllers
{
    public class ProductoController : Controller
    {
        IProductos prod;

        public ProductoController()
        {
            prod = new MProductos();
        }

        // GET: Producto
        public ActionResult Index()
        {
            var lista = prod.ListarProductos();
            var productos = Mapper.Map<List<Models.TbProductos>>(lista);
            return View(productos);
        }

        //vista insert
        public ActionResult Create()
        {
            return View();
        }

        //insert
        [HttpPost]
        public ActionResult Create(Models.TbProductos producto)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbProductos>(producto);
                prod.InsertarProducto(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            var producto = prod.BuscarProducto(id);
            var mostrar = Mapper.Map<Models.TbProductos>(producto);
            return View(mostrar);
        }

        //vista update
        public ActionResult Edit(int id)
        {
            var producto = prod.BuscarProducto(id);
            var mostrar = Mapper.Map<Models.TbProductos>(producto);
            return View(mostrar);
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbProductos producto)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbProductos>(producto);
                prod.ActualizarProducto(modificar);
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        //delete
        public ActionResult Delete(int id)
        {
            prod.EliminarProducto(id);
            return RedirectToAction("Index");
        }
    }
}