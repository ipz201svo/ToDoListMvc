using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListMvc.Models
{
    public class Goal
    {

        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public bool Done { get; set; }
    }
}
