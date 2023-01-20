﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public  class User
    {
        public int? Id { get; set; }   //int? : Ce champ peut accpeter des valeurs null
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        [NotMapped]
        public int TotalPoints { get; set; }
    }
}
