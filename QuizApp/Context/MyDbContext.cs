using Microsoft.EntityFrameworkCore;
using QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Context
{
    public class MyDbContext : DbContext
    {

        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        //Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle
        public virtual DbSet<Quiz> Quizzes { get; set; }
        public virtual DbSet<QuizCategory> QuizCategories { get; set; }
        public virtual DbSet<QuizQuestion> QuizQuestions { get; set; }
        public virtual DbSet<QuizResponse> QuizResponses { get; set; }
        public virtual DbSet<QuizTest> QuizTests { get; set; }
        public virtual DbSet<User> Users { get; set; }


        string connection = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = bddwpf20; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }
    }
}
