using FormationWPF.Context;
using FormationWPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationWPF.Repository
{
    public class MyEventRepository : IMyEventRepository
    {
        ////LINQ: Langage Integrated Query: langage propre à microsoft - permet d'intéroger
        ////n'importe quelle source de données : base de données, fichier..............
        ////2 façons d'utiliser LINQ: Soit via la syntaxe SQL- soit via des appels successifs de méthodes
                ////1-Syntaxe SQL: convient aux dev sql
                ////2- Chainage des méthodes: convient aux dev
        private MyEventDbContext db; //null

        public MyEventRepository(MyEventDbContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            //Utilisation de la syntaxe SQL 
            //Initialistion 
            //Condition
            //Selection
            return (from evt in db.MyEvents select evt.Id).Count();
        }

        public void Delete(MyEvent evt)
        {
            //db.Entry(evt).State = EntityState.Deleted;
            db.MyEvents.Remove(evt);
            db.SaveChanges();
        }

        public List<MyEvent> FindAll()
        {
            return db.MyEvents.AsNoTracking().ToList();
        }

        public MyEvent FindById(int id)
        {
            return db.MyEvents.Find(id);
        }

        public void SaveOrUpdate(MyEvent evt)
        {
            if(evt.Id== 0) //Sauvegarde
            {
                db.MyEvents.Add(evt);  //evt : etat Added
            } else
            {
                //db.Entry(evt).State = EntityState.Modified;
                db.MyEvents.Update(evt);
            }

            db.SaveChanges();
        }

        public List<MyEvent> Search(string searchStr)
        {
            return db.MyEvents.AsNoTracking().Where(evt => evt.Title.Contains(searchStr)
            || evt.Description.Contains(searchStr)
            || evt.StartDate.ToString().Contains(searchStr)
            || evt.EndDate.ToString().Contains(searchStr)).ToList();
        }
    }
}
