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
    public class Tipo_TarjetaController : Controller
    {
        // GET: Tipo_Tarjeta
        public ActionResult Index()
        {
            return View();
        }
    }
}