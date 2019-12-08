using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }
        public string Class { get; set; }
        [Required(ErrorMessage = "Please input the name of the animal")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please input some text for the description")]
        public string Description { get; set; }
        public string Diet { get; set; }

    }
}
