﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


//1.Ajouter une alias WinForms pour eviter de prefixer par System.Windows.Forms
using WinForms = System.Windows.Forms;


namespace FormationWPF.Controles
{
    /// <summary>
    /// Logique d'interaction pour _02_Media.xaml
    /// </summary>
    public partial class _02_Media : Window
    {
        public _02_Media()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openPicture = new OpenFileDialog();

            openPicture.Filter = "Image(*.png,*.jpg) | *.png;*.jpg| Tous les fichiers(*.*) | *.*";

            openPicture.InitialDirectory = Environment.CurrentDirectory;

            DialogResult result = openPicture.ShowDialog();

            if(result == WinForms.DialogResult.Cancel)
            {
                return;
            }

            image1.Source = new BitmapImage(new Uri(openPicture.FileName));

        }

        private void loadMedia_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openPicture = new OpenFileDialog();

            openPicture.InitialDirectory = Environment.CurrentDirectory;

            DialogResult result = openPicture.ShowDialog();

            if (result == WinForms.DialogResult.Cancel)
            {
                return;
            }

            medialElement.Source = new Uri(openPicture.FileName);
           // medialElement.Play();
        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            if(medialElement.Source == null)
            {
                WinForms.MessageBox.Show("Vous devez selectionner un média");
            } else
            {
                medialElement.Play();
            }
        }

        private void buttonPause_Click(object sender, RoutedEventArgs e)
        {
            medialElement.Pause();
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            medialElement.Stop();
        }
    }
}
