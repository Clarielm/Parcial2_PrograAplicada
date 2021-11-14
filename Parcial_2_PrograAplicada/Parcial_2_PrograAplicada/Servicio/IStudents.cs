using Parcial_2_PrograAplicada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_2_PrograAplicada.Servicio
{
    interface IStudents
    {

        void Create(Students p);


        ICollection<Students> ListDataStudents();


    }
}