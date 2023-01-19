using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationWPF.Models
{
    public class MyEvent
    {
        //{Id, Title, Description, StartDate, EndDate}
        //Installer :   EntityFramework core  - EntityFrameworkCore.SqlServer - EntityFrameworkCore.Tools
        //Utiliser une approche : Code First  
        //Chaine de connexion 
        //Context : Ajouter le (s) dbSet(s)
        //Migration :
                    //enable-migrations
                    //add-migration "Initial Model"
                    //updadate-database

        //Couche DAO

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
