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
    public class Tipo_TarjetaController : Controller
    {
        ITipo_Tarjetas tiptar;

        public Tipo_TarjetaController()
        {
            tiptar = new MTipo_Tarjetas();
        }

        // GET: Tipo_Tarjeta
        public ActionResult Index()
        {
            var lista = tiptar.ListarTipo_Tarjetas();
            var tipoTarjetas = Mapper.Map<List<Models.TbTipo_Tarjetas>>(lista);
            return View(tipoTarjetas);
        }

        //vista insert
        public ActionResult Create()
        {
            return View();
        }

        //insert
        [HttpPost]
        public ActionResult Create(Models.TbTipo_Tarjetas tipoTarjeta)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbTipo_Tarjetas>(tipoTarjeta);
                tiptar.InsertarTipo_Tarjeta(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            var tipoTarjeta = tiptar.BuscarTipo_Tarjeta(id);
            var mostrar = Mapper.Map<Models.TbTipo_Tarjetas>(tipoTarjeta);
            return View(mostrar);
        }

        //vista update
        public ActionResult Edit(int id)
        {
            var tipoTarjeta = tiptar.BuscarTipo_Tarjeta(id);
            var mostrar = Mapper.Map<Models.TbTipo_Tarjetas>(tipoTarjeta);
            return View(mostrar);
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbTipo_Tarjetas tipoTarjeta)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbTipo_Tarjetas>(tipoTarjeta);
                tiptar.ActualizarTipo_Tarjeta(modificar);
                return RedirectToAction("Index");
            }
            return View(tipoTarjeta);
        }

        //delete
        public ActionResult Delete(int id)
        {
            tiptar.EliminarTipo_Tarjeta(id);
            return RedirectToAction("Index");
        }
    }
}