using Parcial_2_PrograAplicada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_2_PrograAplicada.Servicio
{
    interface ICourses
    {

        void Create(Courses p);


        ICollection<Courses> ListDataCourses();

    }
}