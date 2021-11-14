using Parcial_2_PrograAplicada.Models;
using Parcial_2_PrograAplicada.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_2_PrograAplicada.Repository
{
    public class ErollementsRepository : IErollements
    {

        EscuelaDeConexionespalEntities bd = new EscuelaDeConexionespalEntities();

        public void Create(Erollements p)
        {
            bd.Erollements.Add(p);
            bd.SaveChanges();
        }

        public ICollection<Erollements> ListDataErollements()
        {

            var ListDataErollements = bd.Erollements.ToList();

            return ListDataErollements;

        }

    }
}