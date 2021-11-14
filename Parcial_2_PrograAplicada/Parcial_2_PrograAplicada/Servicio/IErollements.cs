using Parcial_2_PrograAplicada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_2_PrograAplicada.Servicio
{
    interface IErollements
    {

        void Create(Erollements p);


        ICollection<Erollements> ListDataErollements();

    }
}