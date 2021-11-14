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
    public class ErollementsController : Controller
    {
        // GET: Erollements
        public ActionResult VistaErollements()
        {
            using (EscuelaDeConexionespalEntities bd = new EscuelaDeConexionespalEntities())
            {

                var Listado = bd.Erollements.ToList();

                return View(Listado);
            }
        }

        public ActionResult VistaErollementsEdit()
        {
            return View();
        }

        public ActionResult IndexV(ErollementsViewModel tran)
        {


            if (!ModelState.IsValid)
            {

                return View("VistaErollementsEdit", tran);

            }
            else
            {
                return Redirect("/Erollements/Resultado");
            }

        }

        public ActionResult Resultado(String CourseID, String StudentID, String Grade)
        {
            ViewBag.CourseID = CourseID;
            ViewBag.StudentID = StudentID;
            ViewBag.Grade = Grade;

            ErollementsRepository perRepo = new ErollementsRepository();
            var List = perRepo.ListDataErollements();


            using (EscuelaDeConexionespalEntities bd = new EscuelaDeConexionespalEntities())
                {
                    ErollementsRepository ero = new ErollementsRepository();
                    Erollements cur = new Erollements();
                    cur.StudentID = int.Parse(StudentID);
                    cur.CourseID = int.Parse(CourseID);
                    cur.Grade = int.Parse(Grade);
                    ero.Create(cur);

                }

                return View();
            

         
        }

        public ActionResult Eliminar()
        {

            return Redirect("");
        }
    }

    

}