using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MMS.Web.Models
{
    public class ReviewViewModel
    {
        // selectlist of students (id, name)       
        public SelectList Reviews { set; get; }

        // Collecting StudentId and Issue in Form
        [Required]
        [Display(Name = "Select Name")]
        public int MovieId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Comment { get; set; }
    }
}