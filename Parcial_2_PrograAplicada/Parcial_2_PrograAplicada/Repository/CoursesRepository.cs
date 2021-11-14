using Parcial_2_PrograAplicada.Models;
using Parcial_2_PrograAplicada.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_2_PrograAplicada.Repository
{
    public class CoursesRepository : ICourses
    {

         EscuelaDeConexionespalEntities bd = new EscuelaDeConexionespalEntities();

        public void Create(Courses p)
        {
            bd.Courses.Add(p);
            bd.SaveChanges();
        }

        public ICollection<Courses> ListDataCourses()
        {

            var ListDataCourses = bd.Courses.ToList();

            return ListDataCourses;

        }



    }
}