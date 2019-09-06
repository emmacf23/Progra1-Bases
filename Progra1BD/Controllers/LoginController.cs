﻿using System;
 using System.Collections.Generic;
 using Progra1BD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
 using System.Linq;
 using Microsoft.AspNetCore.Http;
 using Microsoft.EntityFrameworkCore.Metadata.Internal;

 namespace Progra1BD.Controllers
 {
     public class LoginController : Controller
    {
        UserDataAcess_Layer objUser = new UserDataAcess_Layer();
        AccountDataAccess_Layer objAccount = new AccountDataAccess_Layer();
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(IFormCollection formCollection)
        {
            string _user = Convert.ToString(formCollection["inputUser"]);
            string _password = Convert.ToString(formCollection["inputPassword"]);
            List<User> Users = new List<User>();
            Users = objUser.GetAllUsers().ToList();
            foreach (var user in Users)
            {
                if (user.Username ==_user && user.Password ==_password)
                {
                    VariablesLocales.idClienteActual = user.ID;
                    return new RedirectToActionResult("SelectAccount", "Login",new {user = _user});
                }
            }
            return new RedirectToActionResult("AddBeneficiaries", "Transaction", new {mensaje = _user}); 
        }

        public IActionResult SelectAccount()
        {
            List<Account> listAccount = new List<Account>();
            listAccount = objAccount.GetAllAccounts(VariablesLocales.idClienteActual).ToList();
            return View(listAccount);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Register()
        {
            return View();
        }
    }
}
