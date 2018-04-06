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
    public class AlquilerController : Controller
    {
        IAlquileres alq;

        public AlquilerController()
        {
            alq = new MAlquileres();
        }
        // GET: Alquiler
        public ActionResult Index()
        {
            var lista = alq.ListarAlquileres();
            var alquileres = Mapper.Map<List<Models.TbAlquileres>>(lista);
            return View(alquileres);
        }

        //vista insert
        public ActionResult Create()
        {
            return View();
        }

        //insert
        [HttpPost]
        public ActionResult Create(Models.TbAlquileres alquiler)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbAlquileres>(alquiler);
                alq.InsertarAlquiler(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            var alquiler = alq.BuscarAlquiler(id);
            var mostrar = Mapper.Map<Models.TbAlquileres>(alquiler);
            return View(mostrar);
        }

        //vista update
        public ActionResult Edit(int id)
        {
            var alquiler = alq.BuscarAlquiler(id);
            var mostrar = Mapper.Map<Models.TbAlquileres>(alquiler);
            return View(mostrar);
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbAlquileres alquiler)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbAlquileres>(alquiler);
                alq.ActualizarAlquiler(modificar);
                return RedirectToAction("Index");
            }
            return View(alquiler);
        }

        //delete
        public ActionResult Delete(int id)
        {
            alq.EliminarAlquiler(id);
            return RedirectToAction("Index");
        }
    }
}