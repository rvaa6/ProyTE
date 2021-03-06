﻿using System;
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
    public class Historial_MedidaController : Controller
    {
        IHistorial_Medidas hist;

        public Historial_MedidaController()
        {
            hist = new MHistorial_Medidas();
        }

        // GET: Historial_Medidas
        public ActionResult Index()
        {
            var lista = hist.ListarHistorial_Medidas();
            var historialm = Mapper.Map<List<Models.TbHistorial_Medidas>>(lista);
            return View(historialm);
        }

        //vista insert
        public ActionResult Create()
        {
            return View();
        }

        //insert
        [HttpPost]
        public ActionResult Create(Models.TbHistorial_Medidas historialm)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbHistorial_Medidas>(historialm);
                hist.InsertarHistorial_Medida(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            var historialm = hist.BuscarHistorial_Medida(id);
            var mostrar = Mapper.Map<Models.TbHistorial_Medidas>(historialm);
            return View(mostrar);
        }

        //vista update
        public ActionResult Edit(int id)
        {
            var historialm = hist.BuscarHistorial_Medida(id);
            var mostrar = Mapper.Map<Models.TbHistorial_Medidas>(historialm);
            return View(mostrar);
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbHistorial_Medidas historialm)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbHistorial_Medidas>(historialm);
                hist.ActualizarHistorial_Medidas(modificar);
                return RedirectToAction("Index");
            }
            return View(historialm);
        }

        //delete
        public ActionResult Delete(int id)
        {
            hist.EliminarHistorial_Medida(id);
            return RedirectToAction("Index");
        }
    }
}