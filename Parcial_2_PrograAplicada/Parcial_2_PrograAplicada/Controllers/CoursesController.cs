using Parcial_2_PrograAplicada.Models.ViewModels;
using Parcial_2_PrograAplicada.Repository;
using Parcial_2_PrograAplicada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial_2_PrograAplicada.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult VistaCourses()
        {
            using (EscuelaDeConexionespalEntities bd = new EscuelaDeConexionespalEntities())
            {

                var Listado = bd.Courses.ToList();

                return View(Listado);
            }


        }

        public ActionResult VistaCoursesEdit()
        {
            return View();
        }


        public ActionResult IndexV(CoursesViewModel tran)
        {
           

            if (!ModelState.IsValid)
            {

                return View("VistaCoursesEdit", tran);

            }
            else
            {
                    return Redirect("/Courses/Resultado");
            }

        }

        public ActionResult Resultado(String title, String credits)
        {
            ViewBag.edad = title;
            ViewBag.nombre = credits;            

            CoursesRepository perRepo = new CoursesRepository();
            var List = perRepo.ListDataCourses();
            using (EscuelaDeConexionespalEntities bd = new EscuelaDeConexionespalEntities())
            {
                CoursesRepository curso = new CoursesRepository();
                Courses cur = new Courses();
                cur.Title = title;
                cur.Credits = int.Parse(credits);                
                curso.Create(cur);

            }


            return View(List);
        }

        public ActionResult Eliminar()
        {

            return Redirect("");
        }

    }
}