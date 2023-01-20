using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class QuizQuestion
    {
        public int? Id { get; set; }
        public string QstText { get; set; }
        public bool MultipleChoice { get; set; }
        public int NumOrder { get; set; }

        //ManyToOne
        //Many QuizQuestion to One Quiz
        [ForeignKey("QuizId")]
        public Quiz Quiz { get; set; }

        public int? QuizId { get; set; }
    }
}
