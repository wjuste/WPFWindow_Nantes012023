using FormationWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationWPF.Repository
{
    public interface IMyEventRepository
    {

        //Recuperer la liste des évenements 
        List<MyEvent> FindAll();

        //Recuperer un evenement
        MyEvent FindById(int id);

        //Sauvegarder ou mettre à jour un evenement
        void SaveOrUpdate(MyEvent evt);

        //recuperer le nombre d'événement (int)
        int Count();    

        //Effacer  un evenement 
        void Delete(MyEvent evt);

        //Rechecher un evenement par  son titre ou sa description ou sa datedebut ou sa datefin
        List<MyEvent> Search(string searchStr);
    }
}
