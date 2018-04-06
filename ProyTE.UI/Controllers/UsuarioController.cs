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
    public class UsuarioController : Controller
    {
        IUsuarios usua;

        public UsuarioController()
        {
            usua = new MUsuarios();
        }

        // GET: Usuario
        public ActionResult Index()
        { 
            var lista = usua.ListarUsuarios();
            var usuarios = Mapper.Map<List<Models.TbUsuarios>>(lista);
            return View(usuarios);
        }

        //vista insert
        public ActionResult Create()
        {
            return View();
        }

        //insert
        [HttpPost]
        public ActionResult Create(Models.TbUsuarios usuario)
        {
            if (ModelState.IsValid)
            {
                var insertar = Mapper.Map<DATA.TbUsuarios>(usuario);
                usua.InsertarUsuario(insertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            var usuario = usua.BuscarUsuario(id);
            var mostrar = Mapper.Map<Models.TbUsuarios>(usuario);
            return View(mostrar);
        }

        //vista update
        public ActionResult Edit(int id)
        {
            var usuario = usua.BuscarUsuario(id);
            var mostrar = Mapper.Map<Models.TbUsuarios>(usuario);
            return View(mostrar);
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbUsuarios usuario)
        {
            if (ModelState.IsValid)
            {
                var modificar = Mapper.Map<DATA.TbUsuarios>(usuario);
                usua.ActualizarUsuario(modificar);
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        //delete
        public ActionResult Delete(int id)
        {
            usua.EliminarUsuario(id);
            return RedirectToAction("Index");
        }
         
    }
}
 