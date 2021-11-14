using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial_2_PrograAplicada.Models.ViewModels
{
    public class ErollementsViewModel
    {

        public int ErollementID { get; set; }

        [Display(Name = "CourseID")]
        [Required(ErrorMessage = "Es requerido ingresar este campo")]
        public int CourseID { get; set; }

        [Display(Name = "StudentID")]
        [Required(ErrorMessage = "Es requerido ingresar este campo")]
        public int StudentID { get; set; }

        [Display(Name = "Grade")]
        [Required(ErrorMessage = "Es requerido ingresar este campo")]
        public int Grade { get; set; }
       
    }
}