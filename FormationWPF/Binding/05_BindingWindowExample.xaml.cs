using FormationWPF.Context;
using FormationWPF.Models;
using FormationWPF.Repository;
using FormationWPF.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FormationWPF.Binding
{
    /// <summary>
    /// Logique d'interaction pour _05_BindingWindowExample.xaml
    /// </summary>
    public partial class _05_BindingWindowExample : Window
    {
        private IMyEventService eventService;
        private MyEventDbContext db;

        public ObservableCollection<MyEvent> EvtLst { get; set; }

        public _05_BindingWindowExample()
        {

            db = new MyEventDbContext();
            eventService = new MyEventService(new MyEventRepository(db));
            List<MyEvent> listEvents = eventService.FindAll(); //Recupère la liste des evenements

            EvtLst = new ObservableCollection<MyEvent>(listEvents);


            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            MyEvent evt = new MyEvent { Title = "event10", Description = "blabla", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(5) };

            eventService.SaveOrUpdate(evt);

            EvtLst.Add(evt);
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void BtnSaveOrUpdate_Click(object sender, RoutedEventArgs e)
        {
            MyEvent evtSel = null;

            if(lstView.SelectedItem != null)
            {
                evtSel = lstView.SelectedItem as MyEvent; 
                evtSel.Title = TBoxTitle2.Text;
                lstView.SelectedIndex = -1;
            } else
            {
                evtSel = new MyEvent { Title = "event2500", Description = "bla", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(10) };
                EvtLst.Add(evtSel);
            }

            eventService.SaveOrUpdate(evtSel);
  

        }
    }
}
