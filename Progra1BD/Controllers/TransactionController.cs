using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Progra1BD.Models;

 namespace Progra1BD.Controllers
{
    public class TransactionController : Controller
    {
        string _Name, _Email, _Date, _TypeDoc, _TypeP;
        private int _DocId, _Percentage, _Mobile1, _Mobile2,_ID;

        BeneficiarieDataAcessLayer objBeneficiarie = new BeneficiarieDataAcessLayer();
        StateAccountDataAccess_Layer objState = new StateAccountDataAccess_Layer();
        public IActionResult Beneficiaries()
        {
            List<Beneficiarie> listBeneficiaries = new List<Beneficiarie>();
            listBeneficiaries = objBeneficiarie.GetAllBeneficiaries().ToList();
            return View(listBeneficiaries);
        }

        [HttpGet]
        public IActionResult AddBeneficiaries()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBeneficiaries(IFormCollection formCollection)
        {
            _Name = Convert.ToString(formCollection["Name"]);
            _Email = Convert.ToString(formCollection["Email"]);
            _TypeDoc = Convert.ToString(formCollection["TypeDocID"]);
            _TypeP = Convert.ToString(formCollection["TipoParentesco"]);
            _DocId = Convert.ToInt32(formCollection["DocID"]);
            _Percentage = Convert.ToInt32(formCollection["Porcentaje"]);
            _Mobile1 = Convert.ToInt32(formCollection["Mobile1"]);
            _Mobile2= Convert.ToInt32(formCollection["Mobile2"]);
            _Date= Convert.ToString(formCollection["Date"]);
            Console.WriteLine("Nombre:" + _Name + " Email: " + _Email + " Tipo Doc: " + _TypeDoc + " Doc ID:" + _DocId + " Tipo Parentesco: " + _TypeP + " Porcentaje: " + _Percentage + " Telefono 1: " +_Mobile1 + " Celular 2: " +_Mobile2 +" Fecha:" + _Date);
            Beneficiarie beneficiarie = new Beneficiarie();
            beneficiarie.Name = _Name;
            beneficiarie.Email = _Email;
            beneficiarie.TypeDocID = _TypeDoc;
            beneficiarie.DocID = _DocId;
            beneficiarie.TipoParentesco = _TypeP;
            beneficiarie.Porcentaje = _Percentage;
            beneficiarie.Mobile1 = _Mobile1;
            beneficiarie.Mobile2 = _Mobile2;
            beneficiarie.Date = _Date;
            if (ModelState.IsValid)
            {
                beneficiarie.numeroCuenta = VariablesLocales.idCuentaActual;
                objBeneficiarie.AddBeneficiarie(beneficiarie);
                return RedirectToAction("Beneficiaries");
            }
            
            
            return Content("<script language='javascript' type='text/javascript'>alert('No se pudo meter el mama huevos');</script>");
            
        }
        public IActionResult NewSavings()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdateBeneficiarie()
        {
            return  View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateBeneficiaries(IFormCollection formCollection)
        {
            _Name = Convert.ToString(formCollection["Name"]);
            _ID = Convert.ToInt32(formCollection["ID"]);
            _Email = Convert.ToString(formCollection["Email"]);
            _TypeDoc = Convert.ToString(formCollection["TypeDocID"]);
            _TypeP = Convert.ToString(formCollection["TipoParentesco"]);
            _DocId = Convert.ToInt32(formCollection["DocID"]);
            _Percentage = Convert.ToInt32(formCollection["Porcentaje"]);
            _Mobile1 = Convert.ToInt32(formCollection["Mobile1"]);
            _Mobile2= Convert.ToInt32(formCollection["Mobile2"]);
            _Date= Convert.ToString(formCollection["Date"]);
            Console.WriteLine("Nombre:" + _Name + " Email: " + _Email + " Tipo Doc: " + _TypeDoc + " Doc ID:" + _DocId + " Tipo Parentesco: " + _TypeP + " Porcentaje: " + _Percentage + " Telefono 1: " +_Mobile1 + " Celular 2: " +_Mobile2 +" Fecha:" + _Date);
            Beneficiarie beneficiarie = new Beneficiarie();
            beneficiarie.Name = _Name;
            beneficiarie.Email = _Email;
            beneficiarie.TypeDocID = _TypeDoc;
            beneficiarie.DocID = _DocId;
            beneficiarie.TipoParentesco = _TypeP;
            beneficiarie.Porcentaje = _Percentage;
            beneficiarie.Mobile1 = _Mobile1;
            beneficiarie.Mobile2 = _Mobile2;
            beneficiarie.Date = _Date;
            beneficiarie.ID = _ID;
            if (ModelState.IsValid)
            {
                objBeneficiarie.UpdateBeneficiaries(beneficiarie);
                return RedirectToAction("Beneficiaries");
            }
            return new RedirectToActionResult("Index", "Home",new {user = beneficiarie.numeroCuenta});
        }

        [HttpGet]
        public IActionResult DeleteBeneficiarie()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult DeleteBeneficiarie(IFormCollection formCollection)
        {
            _ID = Convert.ToInt32(formCollection["ID"]);
            if (ModelState.IsValid)
            {
                objBeneficiarie.DeleteBeneficiarie(_ID);
                return RedirectToAction("Beneficiaries");
            }
            return new RedirectToActionResult("Index", "Home", _ID);
            
        }

        public IActionResult StateAccount()
        {
            List<StateAccount> listStateAccount = new List<StateAccount>();
            listStateAccount = objState.GetAllStateAccounts(VariablesLocales.idCuentaActual).ToList();
            return  View(listStateAccount);
        }
    }
}
