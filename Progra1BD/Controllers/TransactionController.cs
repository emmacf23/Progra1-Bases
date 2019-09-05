﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 using Progra1BD.Models;

 namespace Progra1BD.Controllers
{
    public class TransactionController : Controller
    {
        BeneficiarieDataAcessLayer objBeneficiarie = new BeneficiarieDataAcessLayer();
        
        public IActionResult Beneficiaries()
        {
            List<Beneficiarie> listBeneficiaries = new List<Beneficiarie>();
            listBeneficiaries = objBeneficiarie.GetAllBeneficiaries().ToList();
            return View(listBeneficiaries);
        }
        
        public IActionResult AddBeneficiaries()
        {
            return View();
        }
        
        public IActionResult NewSavings()
        {
            return View();
        }
        
    }
}