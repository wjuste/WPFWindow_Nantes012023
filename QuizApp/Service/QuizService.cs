using QuizApp.Models;
using QuizApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Service
{
    public class QuizService : IQuizService
    {
        private IQuizRepository repository;

        public QuizService(IQuizRepository repository)
        {
            this.repository = repository;
        }

        public int CountQuestions(int quizId)
        {
            return repository.CountQuestions(quizId);  
        }

        public QuizQuestion FindQuestion(int quizId, int numOrder)
        {
            return repository.FindQuestion(quizId, numOrder); 
        }

        public Quiz FindQuizById(int quizId)
        {
            return repository.FindQuizById(quizId);
        }

        public List<Quiz> FindQuizzes()
        {
            return repository.FindQuizzes();
        }

        public QuizResponse FindResponseById(int responseId)
        {
            return repository.FindResponseById(responseId);
        }

        public List<QuizResponse> FindResponses(int questionId)
        {
            return repository.FindResponses(questionId);    
        }
    }
}
