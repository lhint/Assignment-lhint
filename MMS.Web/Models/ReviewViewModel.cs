using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MMS.Web.Models
{
    public class ReviewViewModel
    {
        // selectlist of students (id, name)       
        public SelectList Movies { set; get; }

        // Collecting StudentId and Issue in Form
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public string Title { get; set; }
        public int MovieId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Comment { get; set; }
        [Required]
        [Range(0,10)]
        public int Rating {get; set;}
    }
}