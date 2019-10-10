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
        private string _Name, _Email, _Date, _Description;
        private int _TypeDoc, _TypeP, _DocId, _Percentage, _Mobile1, _Mobile2, _ID, _Monto;
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

        [HttpGet]
        public IActionResult ResultSearch(List<Movement> listMovement)
        {
            return View(listMovement);
        }

        [HttpGet]
        public IActionResult AddObjetiveAccount()
        {
            return View();
        }


        [HttpGet]
        public IActionResult SearchMovement()
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
                        return RedirectToAction("Beneficiaries", "Transaction");
                    }

                    if (sumaP() + _Percentage < 100)
                    {
                        Console.WriteLine("Entre a Warning");
                        objBeneficiarie.AddBeneficiarie(beneficiarie);
                        ModelState.AddModelError("Error",
                            "La suma de los porcentajes de los 3 usuarios no suma 100.");
                        return RedirectToAction("Beneficiaries", "Transaction");
                    }

                    ModelState.AddModelError("Error", "La suma de los 3 es mayor a 100");
                    return View("AddBeneficiaries");
                }

                ModelState.AddModelError("Error", "Ya existen 3 usuarios");
                return RedirectToAction("Beneficiaries", "Transaction");
            }

            return View("AddBeneficiaries");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SearchMovement(IFormCollection formCollection)
        {
            _Description = Convert.ToString(formCollection["descripcion"]);
            Console.WriteLine(_Description);
            List<Movement> listMovement = new List<Movement>();
            listMovement = objMovement.GetAllMovementsQuery(_Description).ToList();
            Console.WriteLine(listMovement);
            return View("ResultSearch", listMovement);
        }


        public IActionResult AddObjetiveAccount(IFormCollection formCollection)
        {
            if (ModelState.IsValid)
            {
                _Monto = Convert.ToInt32(formCollection["montoAhorro"]);
                _Description = Convert.ToString(formCollection["descripcion"]);
                _Date = Convert.ToString(formCollection["fechaFinal"]);
                ObjetiveAccount objetiveAccount = new ObjetiveAccount();
                objetiveAccount.montoAhorro = _Monto;
                objetiveAccount.descripcion = _Description;
                objetiveAccount.fechaFinal = _Date;
                objObjetive.AddObjetiveAccount(objetiveAccount);
                Console.WriteLine("Lo hice");


            }

            return View("AddObjetiveAccount");
        }
        
        public IActionResult UpdateObjetiveAccount(IFormCollection formCollection)
        {
            if (ModelState.IsValid)
            {
                _ID = Convert.ToInt32(formCollection["ID"]);
                _Monto = Convert.ToInt32(formCollection["montoAhorro"]);
                _Description = Convert.ToString(formCollection["descripcion"]);
                _Date = Convert.ToString(formCollection["fechaFinal"]);
                ObjetiveAccount objetiveAccount = new ObjetiveAccount();
                objetiveAccount.ID = _ID;
                objetiveAccount.montoAhorro = _Monto;
                objetiveAccount.descripcion = _Description;
                objetiveAccount.fechaFinal = _Date;
                objObjetive.UpdateCuentaObjetivo(objetiveAccount);
                Console.WriteLine("Lo hice");


            }

            return View("UpdateObjetiveAccount");
        }
        
        [HttpGet]
        public IActionResult UpdateObjetiveAccount()
        {
            return View();
        }

        [
            HttpGet]
        public IActionResult UpdateBeneficiarie()
        {
            return View();
        }
        
        
        [HttpGet]
        public IActionResult DeleteObjetiveAccount()
        {
            return View();
        }
        
        
        public IActionResult DeleteObjetiveAccount(IFormCollection formCollection)
        {
            _ID = Convert.ToInt32(formCollection["ID"]);
            ObjetiveAccount objetiveAccount = new ObjetiveAccount();
            objObjetive.DeleteCuentaObjetivo(_ID);
            return RedirectToAction("ObjetiveAccount", "Transaction");
        }

        [HttpPost]
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
                    return RedirectToAction("Beneficiaries", "Transaction");
                }

                if (sumaP() - findById(_ID) + _Percentage < 100)
                {
                    objBeneficiarie.UpdateBeneficiaries(beneficiarie);
                    ModelState.AddModelError("Error",
                        "La suma de los porcentajes de los 3 usuarios no suma 100.");
                    return RedirectToAction("Beneficiaries", "Transaction");
                }

                ModelState.AddModelError("Error", "La suma de los actualizados es mayor a 100");
                return View("UpdateBeneficiarie");
            }

            ModelState.AddModelError("Error", "Datos Incorrectos. Intente de Nuevo");
            return View("UpdateBeneficiarie");
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
        [HttpPost]
        public IActionResult DeleteObjective(IFormCollection formCollection)
        {
            _ID = Convert.ToInt32(formCollection["ID"]);
            if (ModelState.IsValid)
            {
                objObjetive.DeleteCuentaObjetivo(_ID);
                return RedirectToAction("ObjetiveAccount");
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
            listMovement = objMovement.GetAllMovements().ToList();
            return View(listMovement);
        }

        public IActionResult ObjetiveAccount()
        {
            List<ObjetiveAccount> listObjetiveAccounts = new List<ObjetiveAccount>();
            Console.WriteLine(VariablesLocales.idCuentaActual);
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