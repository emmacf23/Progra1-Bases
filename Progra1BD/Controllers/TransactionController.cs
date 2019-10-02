using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Progra1BD.Models;

namespace Progra1BD.Controllers
{
    public class TransactionController : Controller
    {
        string _Name, _Email, _Date;
        private int _TypeDoc, _TypeP, _DocId, _Percentage, _Mobile1, _Mobile2, _ID;
        List<Beneficiarie> listBeneficiaries = new List<Beneficiarie>();
        BeneficiarieDataAcessLayer objBeneficiarie = new BeneficiarieDataAcessLayer();
        StateAccountDataAccess_Layer objState = new StateAccountDataAccess_Layer();
        MovementAccountDataAccess_Layer objMovement = new MovementAccountDataAccess_Layer();
        ObjetiveAccountAccountDataAccess_Layer objObjetive = new ObjetiveAccountAccountDataAccess_Layer();

        public IActionResult Beneficiaries()
        {
            listBeneficiaries = new List<Beneficiarie>();
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
            if (ModelState.IsValid)
            {    
                _Name = Convert.ToString(formCollection["Name"]);
                _Email = Convert.ToString(formCollection["Email"]);
                _TypeDoc = Convert.ToInt32(formCollection["TypeDocID"]);
                _TypeP = Convert.ToInt32(formCollection["TipoParentesco"]);
                _DocId = Convert.ToInt32(formCollection["DocID"]);
                _Percentage = Convert.ToInt32(formCollection["Porcentaje"]);
                _Mobile1 = Convert.ToInt32(formCollection["Mobile1"]);
                _Mobile2 = Convert.ToInt32(formCollection["Mobile2"]);
                _Date = Convert.ToString(formCollection["Date"]);
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
                listBeneficiaries = objBeneficiarie.GetAllBeneficiaries().ToList();
                if (listBeneficiaries.Count < 3)
                {
                    if (sumaP() + _Percentage == 100)
                    {
                        Console.WriteLine("Entre a Sucess");
                        objBeneficiarie.AddBeneficiarie(beneficiarie);
                        Console.WriteLine("Lo hice");
                        //ModelState.AddModelError("Success", "Usuario" + _Name + " Añadido con exito.");
                        return RedirectToAction("Beneficiaries","Transaction");
                    }

                    if (sumaP() + _Percentage < 100)
                    {
                        Console.WriteLine("Entre a Warning");
                        objBeneficiarie.AddBeneficiarie(beneficiarie);
                        ModelState.AddModelError("Error",
                            "La suma de los porcentajes de los 3 usuarios no suma 100.");
                        return RedirectToAction("Beneficiaries","Transaction");
                    }

                    ModelState.AddModelError("Error", "La suma de los 3 es mayor a 100");
                    return View("AddBeneficiaries");
                }

                ModelState.AddModelError("Error", "Ya existen 3 usuarios");
                return RedirectToAction("Beneficiaries","Transaction");
            }
            return View("AddBeneficiaries");
        }


        public IActionResult AddObjetiveAccount()
        {
            return View();
        }

        [
            HttpGet]
        public IActionResult UpdateBeneficiarie()
        {
            return View();
        }

        [
            HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateBeneficiaries(IFormCollection formCollection)
        {
            _Name = Convert.ToString(formCollection["Name"]);
            _ID = Convert.ToInt32(formCollection["ID"]);
            _Email = Convert.ToString(formCollection["Email"]);
            _TypeDoc = Convert.ToInt32(formCollection["TypeDocID"]);
            _TypeP = Convert.ToInt32(formCollection["TipoParentesco"]);
            _DocId = Convert.ToInt32(formCollection["DocID"]);
            _Percentage = Convert.ToInt32(formCollection["Porcentaje"]);
            _Mobile1 = Convert.ToInt32(formCollection["Mobile1"]);
            _Mobile2 = Convert.ToInt32(formCollection["Mobile2"]);
            _Date = Convert.ToString(formCollection["Date"]);
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
                if (sumaP() - findById(_ID) + _Percentage == 100)
                {
                    objBeneficiarie.UpdateBeneficiaries(beneficiarie);
                    ModelState.AddModelError("Error", "Usuario" + _Name + " Actualizado con exito.");
                    return RedirectToAction("Beneficiaries","Transaction");
                }
                
                if (sumaP() - findById(_ID) + _Percentage < 100)
                {
                    objBeneficiarie.UpdateBeneficiaries(beneficiarie);
                    ModelState.AddModelError("Error",
                        "La suma de los porcentajes de los 3 usuarios no suma 100.");
                    return RedirectToAction("Beneficiaries","Transaction");
                }

                ModelState.AddModelError("Error", "La suma de los actualizados es mayor a 100");
                return View("UpdateBeneficiarie");
            }

            ModelState.AddModelError("Error", "Datos Incorrectos. Intente de Nuevo");
            return View("UpdateBeneficiarie");
        }

        [
            HttpGet]
        public IActionResult DeleteBeneficiarie()
        {
            return View();
        }

        [
            HttpPost]
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
            return View(listStateAccount);
        }
        
        public IActionResult Movements(int id)
        {
            VariablesLocales.idEstadoCuentaActual = id;
            List<Movement> listMovement = new List<Movement>();
            listMovement = objMovement.GetAllMovements(VariablesLocales.idEstadoCuentaActual).ToList();
            return View(listMovement);
        }
        
        public IActionResult ObjetiveAccount()
        {
            List<ObjetiveAccount> listObjetiveAccounts = new List<ObjetiveAccount>();
            listObjetiveAccounts = objObjetive.GetAllObjetiveAccounts(VariablesLocales.idCuentaActual).ToList();
            return View(listObjetiveAccounts);
        }

        public int sumaP()
        {
            int sumPorcentajes = 0;
            listBeneficiaries = objBeneficiarie.GetAllBeneficiaries().ToList();
            foreach (Beneficiarie b in listBeneficiaries)
            {
                sumPorcentajes = sumPorcentajes + b.Porcentaje;
            }

            return sumPorcentajes;
        }
        
        public int findById(int id)
        {
            foreach (Beneficiarie b in listBeneficiaries)
            {
                if (b.ID == id)
                {
                    return b.Porcentaje;
                }
            }

            return 0;
        }
    }
}