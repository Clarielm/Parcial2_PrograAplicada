using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial_2_PrograAplicada.Models.ViewModels
{
    public class StudentsViewModel
    {

        public int StudentId { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Es requerido ingresar este campo")]
        public String LastName { get; set; }

        [Display(Name = "FirstMidName")]
        [Required(ErrorMessage = "Es requerido ingresar este campo")]
        public String FirstMidName { get; set; }

        [Display(Name = "EnrrollmentsDate")]
        [Required(ErrorMessage = "Es requerido ingresar este campo")]
        public DateTime EnrrollmentsDate { get; set; }
        
        
        
        
        //public ICollection<Erollements> Erollements { get; set; }
    }
}