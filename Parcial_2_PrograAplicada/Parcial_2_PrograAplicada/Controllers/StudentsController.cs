using Parcial_2_PrograAplicada.Models;
using Parcial_2_PrograAplicada.Models.ViewModels;
using Parcial_2_PrograAplicada.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial_2_PrograAplicada.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult VistaStudents()
        {
            using (EscuelaDeConexionespalEntities bd = new EscuelaDeConexionespalEntities())
            {

                var Listado = bd.Students.ToList();

                return View(Listado);
            }
        }

        public ActionResult VistaStudentsEdit()
        {
            return View();
        }

        public ActionResult IndexV(StudentsViewModel tran)
        {


            if (!ModelState.IsValid)
            {

                return View("VistaStudentsEdit", tran);

            }
            else
            {
                return Redirect("/Students/Resultado");
            }

        }

        public ActionResult Resultado(String LastName, String FisrtMidName, String EnrrollmentsDate)
        {
            ViewBag.LastName = LastName;
            ViewBag.FisrtMidName = FisrtMidName;
            ViewBag.EnrrollmentsDate = EnrrollmentsDate;

            StudentsRepository perRepo = new StudentsRepository();
            var List = perRepo.ListDataStudents();
            using (EscuelaDeConexionespalEntities bd = new EscuelaDeConexionespalEntities())
            {
                StudentsRepository ero = new StudentsRepository();
                Students cur = new Students();
                cur.LastName = LastName;
                cur.FirstMidName = FisrtMidName;
                cur.EnrrollmentsDate =DateTime.Parse(EnrrollmentsDate);
                ero.Create(cur);

            }


            return View(List);
        }

        public ActionResult Eliminar()
        {

            return Redirect("");
        }
    }

    
}