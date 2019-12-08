using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class Response
    {
        [Key]
        public int ResponseID { get; set; }
        [Required(ErrorMessage = "Please input some text for your story")]
        public string Comment { get; set; }
    }
}
