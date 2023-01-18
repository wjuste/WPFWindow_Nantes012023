using FormationWPF.Binding;
using FormationWPF.Controles;
using FormationWPF.Fichier;
using FormationWPF.MiseEnForme;
using FormationWPF.MiseEnPage;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FormationWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object _01_WindowResurce;

        public MainWindow()
        {
            InitializeComponent();
        }

        /*
    * Les boites de dialiogue sont des fenêtres d'affichages
    * Elles peuvent s'afficher en mode  "Modal" ou "Non Modal"
    * Il existe deux méthodes permettant d'afficher une fenêtre soient en mode modal ou non modal: 
    *          - La méthode Show : permet d'afficher une fenêtre en mode "non modal "
    *                                             Cela signifie que vous pouvez basculer ou activer les autres fenêtre  de l'application 
    *                                              même lorsque la fenêtre actuelle est une fenêtre active
    *          - La méthode ShowDialog : Ouvre une fenêtre en tant que fenêtre "modale"
    *                                                      Cela signifie que lorsque la fenêtre est active, tous les autres fenêtre de l'application sont 
    *                                                      desactivées. On ne peut pas basculer vers d'autres fenêtres tant que la fenêtre actuelle 
    *                                                      n'est pas fermée.
    */

        private void miModal_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationWindow w = new NavigationWindow();
            w.ShowDialog();
        }

        private void miNonModal_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow w = new NavigationWindow();
            w.Show();
        }

        private void miBoiteSimple_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("WPF, controlesCommun'est facile");
        }


        private void miBoiteP_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult rs =     MessageBox.Show("Etes vous prêt à sauter ? ", "Titre", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(rs == MessageBoxResult.Yes)
            {
                MessageBox.Show("Vous n'auriez pas dû!!");
            } else
            {
                MessageBox.Show("Excellent décision!!");
            }
        }

    
        private void miQuitter_Click(object sender, RoutedEventArgs e)
        {
            // this.Close();
            Application.Current.Shutdown();
        }

        private void miAncrage_Click(object sender, RoutedEventArgs e)
        {
            _01_Ancrage ancrage = new _01_Ancrage();
            ancrage.ShowDialog();
        }

        private void miStackPanel_Click(object sender, RoutedEventArgs e)
        {
            _02_StackPanel sp = new _02_StackPanel();
            sp.ShowDialog();
        }

        private void miWrapanel_Click(object sender, RoutedEventArgs e)
        {
            _03_WrapPanel wp  = new _03_WrapPanel();
            wp.ShowDialog();
        }

        private void miDockPanel_Click(object sender, RoutedEventArgs e)
        {
            _05_DockPanel dp = new _05_DockPanel();
            dp.ShowDialog();
        }

        private void miGrid_Click(object sender, RoutedEventArgs e)
        {
            _04_Grid grid = new _04_Grid();
            grid.ShowDialog();
        }

        private void miCanvas_Click(object sender, RoutedEventArgs e)
        {
            _06_Canvas canvas = new _06_Canvas();    
            canvas.ShowDialog();
        }

        private void miControleCommun_Click(object sender, RoutedEventArgs e)
        {
            _01_ControleCommunWPF controlesCommun = new _01_ControleCommunWPF();
            controlesCommun.ShowDialog();
        }

        private void miOuvrir_Click(object sender, RoutedEventArgs e)
        {
            _01_OpenFileDialog  openFileDialog = new _01_OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void miEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            _02_SaveFileDialog saveFileDialog = new _02_SaveFileDialog();
            saveFileDialog.ShowDialog();
        }

        private void miMedia_Click(object sender, RoutedEventArgs e)
        {
            _02_Media media = new _02_Media();
            media.ShowDialog();
        }

        private void miBinding_Click(object sender, RoutedEventArgs e)
        {
            _01_Binding binding = new _01_Binding();
            binding.ShowDialog();
        }

        private void miUpdateSourceTrigger_Click(object sender, RoutedEventArgs e)
        {
            _02_UpdateSourceTrigger updateSourceTrigger = new _02_UpdateSourceTrigger();    
            updateSourceTrigger.ShowDialog();   
        }

        private void miValueConverter_Click(object sender, RoutedEventArgs e)
        {
            _03_ValueConverter converter = new _03_ValueConverter();
            converter.ShowDialog();
        }

        private void miRespondingToChange_Click(object sender, RoutedEventArgs e)
        {
            _04_RespondingTochange respondingTochange = new _04_RespondingTochange();
              respondingTochange.ShowDialog();
        }

        private void mRessources_Click(object sender, RoutedEventArgs e)
        {
            _01_WindowResource resource = new _01_WindowResource();
            resource.ShowDialog();  
        }

        private void mMiseEnformeApp_Click(object sender, RoutedEventArgs e)
        {
            _02_MiseEnFormeApp styleTemplate = new _02_MiseEnFormeApp();
            styleTemplate.ShowDialog();
        }
    }
}
