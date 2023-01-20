using Microsoft.EntityFrameworkCore;
using QuizApp.Context;
using QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Repository
{
    public class QuizRepository : IQuizRepository
    {
        private MyDbContext db;

        public QuizRepository(MyDbContext db)
        {
            this.db = db;
        }

        public int CountQuestions(int quizId)
        {
           return db.QuizQuestions.Where(qst => qst.QuizId == quizId).Count();
        }

        public Quiz FindQuizById(int quizId)
        {
            return db.Quizzes.Find(quizId);
        }

        public QuizQuestion FindQuestion(int quizId, int numOrder)
        {
            return db.QuizQuestions.SingleOrDefault(qst => qst.QuizId == quizId && qst.NumOrder == numOrder);
        }

        /// <summary>
        /// Recuperer la liste des Quiz d'une Category
        /// Eager Loading (Chargement immédiat) : On charge les Quiz en incluant la Catégorie du Quiz 
        /// Utilisation de la méthode Include 
        /// Lazy Loading(Chargement paresseux) : On charge les Quiz, c'est après qu'on recupère la Categorie du Quiz 
        /// (ex : via une méthode getCategorie)
        /// </summary>
        /// <returns></returns>
        public List<Quiz> FindQuizzes()
        {
            return db.Quizzes.Include(quiz => quiz.Category).AsNoTracking().ToList();
        }

        public QuizResponse FindResponseById(int responseId)
        {
          return db.QuizResponses.Find(responseId);
        }

        public List<QuizResponse> FindResponses(int questionId)
        {
            return db.QuizResponses.AsNoTracking().Where(r => r.QuestionId == questionId).ToList();
        }
    }
}
