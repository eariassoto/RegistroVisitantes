﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RegistroVisitantes.Controllers
{
    public class Registro : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        
        // GET: /Registro/Reservas
        [HttpGet]
        public IActionResult Reservas()
        {
            return View();
        }

        // GET: /Registro/Visitantes
        [HttpGet]
        public IActionResult Visitantes()
        {
            return View();
        }
    }
}
