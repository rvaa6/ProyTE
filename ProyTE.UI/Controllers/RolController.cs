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
    public class RolController : Controller
    {
        IRoles ro;

        public RolController()
        {
            ro = new MRoles();
        }

        // GET: Rol
        public ActionResult Index()
        {
            var lista = ro.ListarRoles();
            var roles= Mapper.Map<List<Models.TbRoles>>(lista);
            return View(roles);
        }

        //vista insert
        public ActionResult Create()
        {
            return View();
        }

        //insert
        [HttpPost]
        public ActionResult Create(Models.TbRoles rol)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbRoles>(rol);
                ro.InsertarRol(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            var rol = ro.BuscarRol(id);
            var mostrar = Mapper.Map<Models.TbRoles>(rol);
            return View(mostrar);
        }

        //vista update
        public ActionResult Edit(int id)
        {
            var rol = ro.BuscarRol(id);
            var mostrar = Mapper.Map<Models.TbRoles>(rol);
            return View(mostrar);
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbRoles rol)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbRoles>(rol);
                ro.ActualizarRol(modificar);
                return RedirectToAction("Index");
            }
            return View(rol);
        }

        //delete
        public ActionResult Delete(int id)
        {
            ro.EliminarRol(id);
            return RedirectToAction("Index");
        }
    }
}