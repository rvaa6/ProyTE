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
    public class PrendaController : Controller
    {
        IPrendas pren;

        public PrendaController()
        {
            pren = new MPrendas();
        }

        // GET: Prenda
        public ActionResult Index()
        {
            var lista = pren.ListarPrendas();
            var prendas = Mapper.Map<List<Models.TbPrendas>>(lista);
            return View(prendas);
        }

        //vista insert
        public ActionResult Create()
        {
            return View();
        }

        //insert
        [HttpPost]
        public ActionResult Create(Models.TbPrendas prenda)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbPrendas>(prenda);
                pren.InsertarPrenda(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            var prenda = pren.BuscarPrenda(id);
            var mostrar = Mapper.Map<Models.TbPrendas>(prenda);
            return View(mostrar);
        }

        //vista update
        public ActionResult Edit(int id)
        {
            var prenda = pren.BuscarPrenda(id);
            var mostrar = Mapper.Map<Models.TbPrendas>(prenda);
            return View(mostrar);
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbPrendas prenda)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbPrendas>(prenda);
                pren.ActualizarPrenda(modificar);
                return RedirectToAction("Index");
            }
            return View(prenda);
        }

        //delete
        public ActionResult Delete(int id)
        {
            pren.EliminarPrenda(id);
            return RedirectToAction("Index");
        }
    }
}