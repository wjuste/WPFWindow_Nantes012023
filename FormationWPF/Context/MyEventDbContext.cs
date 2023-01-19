using FormationWPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationWPF.Context
{
    public class MyEventDbContext : DbContext
    {

        public MyEventDbContext()
        {
        }

        public MyEventDbContext(DbContextOptions<MyEventDbContext> options) : base(options)
        {

        }
     
        //Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle
        public virtual DbSet<MyEvent> MyEvents { get; set; }

        string connection = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = bddwpf20; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }

    }
}
