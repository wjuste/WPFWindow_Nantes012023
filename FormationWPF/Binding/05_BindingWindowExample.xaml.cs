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
    }
}
