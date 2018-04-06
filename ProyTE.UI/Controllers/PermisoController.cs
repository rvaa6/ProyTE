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
    public class PermisoController : Controller
    {
        IPermisos perm;

        public PermisoController()
        {
            perm = new MPermisos();
        }

        // GET: Permiso
        public ActionResult Index()
        {
            var lista = perm.ListarPermisos();
            var permisos = Mapper.Map<List<Models.TbPermisos>>(lista);
            return View(permisos);
        }

        //vista insert
        public ActionResult Create()
        {
            return View();
        }

        //insert
        [HttpPost]
        public ActionResult Create(Models.TbPermisos permiso)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbPermisos>(permiso);
                perm.InsertarPermiso(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            var permiso = perm.BuscarPermiso(id);
            var mostrar = Mapper.Map<Models.TbPermisos>(permiso);
            return View(mostrar);
        }

        //vista update
        public ActionResult Edit(int id)
        {
            var permiso = perm.BuscarPermiso(id);
            var mostrar = Mapper.Map<Models.TbPermisos>(permiso);
            return View(mostrar);
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbPermisos permiso)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbPermisos>(permiso);
                perm.ActualizarPermiso(modificar);
                return RedirectToAction("Index");
            }
            return View(permiso);
        }

        //delete
        public ActionResult Delete(int id)
        {
            perm.EliminarPermiso(id);
            return RedirectToAction("Index");
        }
    }
}