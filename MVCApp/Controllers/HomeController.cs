using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using DataLibrary.BusinessLogic;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ListaZamowien()
        {
            ViewBag.Message = "Lista zamówień";

            var data = EmployeeProcessor.LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var row in data)
            {
                employees.Add(new EmployeeModel
                {
                    rodzaj_tran = row.rodzaj_tran,
                    sposob_zapl = row.sposob_zapl,
                    numer_pojazd = row.numer_pojazd
                });
            }

            return View(employees);
        }

        public ActionResult ListaOgloszen()
        {
            ViewBag.Message = "Lista ogłoszeń";

            var data = EmployeeProcessor.LoadPojazdy();
            List<PojazdModel> employees = new List<PojazdModel>();

            foreach(var row in data)
            {
                employees.Add(new PojazdModel
                {
                    marka = row.marka,
                    model = row.model,
                    rok_prod = row.rok_prod,
                    nr_rej = row.nr_rej,
                    przebieg = row.przebieg,
                    rodzaj_pal = row.rodzaj_pal,
                    kolor = row.kolor,
                    rodzaj_pojazd = row.rodzaj_pojazd,
                    numer_pojazd = row.numer_pojazd
                });
            }

            return View(employees);
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Wyslij zgłoszenie";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = EmployeeProcessor.CreateEmployee(model.rodzaj_tran,
                    model.sposob_zapl,
                    model.numer_pojazd);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult SignUpKlient()
        {
            ViewBag.Message = "Wyslij zgłoszenie";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUpKlient(KlientModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = EmployeeProcessor.CreateKlient(model.imie,
                    model.nazwisko,
                    model.pesel,
                    model.kod_pocztowy,
                    model.miasto,
                    model.ulica,
                    model.nr_domu,
                    model.nr_lokalu,
                    model.r_dokument,
                    model.nr_dokument,
                    model.nip,
                    model.telefon,
                    model.email);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult SignUpPojazd()
        {
            ViewBag.Message = "Dodaj ogłoszenie";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUpPojazd(PojazdModel model2)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = EmployeeProcessor.CreatePojazd(model2.marka,
                    model2.model,
                    model2.rok_prod,
                    model2.nr_rej,
                    model2.przebieg,
                    model2.rodzaj_pal,
                    model2.kolor,
                    model2.rodzaj_pojazd,
                    model2.numer_pojazd);
                return RedirectToAction("Index");
            }

            return View();
        }
    }

}