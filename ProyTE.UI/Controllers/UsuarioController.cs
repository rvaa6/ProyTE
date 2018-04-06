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
            var listaUsuarios = usua.ListarUsuarios();
            var usuarios = Mapper.Map<List<Models.TbUsuarios>>(listaUsuarios);
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
                var usuarioInsertar = Mapper.Map<DATA.TbUsuarios>(usuario);
                usua.InsertarUsuario(usuarioInsertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        //select por id
        public ActionResult Details(int id)
        {
            var usuario = usua.BuscarUsuario(id);
            var usuarioMostrar = Mapper.Map<Models.TbUsuarios>(usuario);
            return View(usuarioMostrar);
        }

        //vista update
        public ActionResult Edit(int id)
        {
            var usuario = usua.BuscarUsuario(id);
            var usuarioMostrar = Mapper.Map<Models.TbUsuarios>(usuario);
            return View(usuarioMostrar);
        }

        //update
        [HttpPost]
        public ActionResult Edit(Models.TbUsuarios usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioModificar = Mapper.Map<DATA.TbUsuarios>(usuario);
                usua.ActualizarUsuario(usuarioModificar);
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
 