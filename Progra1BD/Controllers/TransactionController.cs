﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Progra1BD.Controllers
{
    public class TransactionController : Controller
    {

        public IActionResult Beneficiaries()
        {
            return View();
        }
        public IActionResult AddBeneficiaries()
        {
            return View();
        }
    }
}