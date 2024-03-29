﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TermProject.Models
{
    public class ForumPost
    {
        
        private List<Response> resp = new List<Response>();
        [Key]
        public int PostID { get; set; }
        [Required(ErrorMessage = "Please input some text for your story")]
        public string Title{ get; set; }
        [Required(ErrorMessage = "Please input some text for your story")]
        public string Text { get; set; }
        public List<Response> Responses { get { return resp; } }

    }
}
