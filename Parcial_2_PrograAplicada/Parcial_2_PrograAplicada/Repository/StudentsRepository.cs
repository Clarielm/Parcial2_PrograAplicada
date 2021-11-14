using Parcial_2_PrograAplicada.Models;
using Parcial_2_PrograAplicada.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_2_PrograAplicada.Repository
{
    public class StudentsRepository : IStudents
    {

        EscuelaDeConexionespalEntities bd = new EscuelaDeConexionespalEntities();

        public void Create(Students p)
        {
            bd.Students.Add(p);
            bd.SaveChanges();
        }

        public ICollection<Students> ListDataStudents()
        {

            var ListDataStudents = bd.Students.ToList();

            return ListDataStudents;

        }

    }
}