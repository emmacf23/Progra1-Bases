﻿using System;
 using Progra1BD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
 using Microsoft.AspNetCore.Http;
 using Microsoft.EntityFrameworkCore.Metadata.Internal;

 namespace Progra1BD.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(IFormCollection formCollection)
        {
            string _user = formCollection["usuario"];
            string _password = formCollection["password"];
            return new RedirectToActionResult("Index","Home",new { mensaje = _user });
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
