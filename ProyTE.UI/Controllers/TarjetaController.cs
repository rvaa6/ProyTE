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
    public class TarjetaController : Controller
    {
        ITarjetas tar;

        public TarjetaController()
        {
            tar = new MTarjetas();
        }

        // GET: Tarjeta
        public ActionResult Index()
        {
            var lista = tar.ListarTarjetas();
            var tarjetas = Mapper.Map<List<Models.TbTarjetas>>(lista);
            return View(tarjetas);
        }

        //vista insert
        public ActionResult Create()
        {
            return View();
        }

        //insert
        [HttpPost]
        public ActionResult Create(Models.TbTarjetas tarjeta)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbTarjetas>(tarjeta);
                tar.InsertarTarjeta(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            var tarjeta = tar.BuscarTarjeta(id);
            var mostrar = Mapper.Map<Models.TbTarjetas>(tarjeta);
            return View(mostrar);
        }

        //vista update
        public ActionResult Edit(int id)
        {
            var tarjeta = tar.BuscarTarjeta(id);
            var mostrar = Mapper.Map<Models.TbTarjetas>(tarjeta);
            return View(mostrar);
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbTarjetas tarjeta)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbTarjetas>(tarjeta);
                tar.ActualizarTarjeta(modificar);
                return RedirectToAction("Index");
            }
            return View(tarjeta);
        }

        //delete
        public ActionResult Delete(int id)
        {
            tar.EliminarTarjeta(id);
            return RedirectToAction("Index");
        }
    }
}