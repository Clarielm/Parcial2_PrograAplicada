using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial_2_PrograAplicada.Models.ViewModels
{
    public class CoursesViewModel
    {

        public int CourseId { get; set; }

        [Display(Name = "Tilte")]
        [Required(ErrorMessage = "Es requerido ingresar este campo")]        
        public String Title { get; set; }

        [Display(Name = "Credits")]
        [Required(ErrorMessage = "Es requerido ingresar este campo")]
        public int Credits { get; set; }
        //public ICollection<Erollements> Erollements { get; set; }

    }
}