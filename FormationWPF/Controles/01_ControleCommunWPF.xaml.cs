﻿using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace FormationWPF.Controles
{
    /// <summary>
    /// Logique d'interaction pour _01_ControleCommunWPF.xaml
    /// </summary>
    public partial class _01_ControleCommunWPF : Window
    {
        public _01_ControleCommunWPF()
        {
            InitializeComponent();
        }

        private void cmEffacer_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            checkBox1.Content = "You agree !";
        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string item = (string)(combo1.SelectedItem as ComboBoxItem).Content;

            string item = (string)(combo1.Items[combo1.SelectedIndex] as ComboBoxItem).Content;

            MessageBox.Show(item);
       
        }

        private void AddToListBox_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox2.Text))
            {
                listBox1.Items.Add(textBox2.Text);
                textBox2.Text = string.Empty;  //vide le textbox
            }   else
            {
                MessageBox.Show("Veuillez entrer un formation");
            }
        }

        /*
         * Erreur rencontrée " System.InvalidOperationException " :  
         * On ne peut pas supprimer la liste des éléments de la ListBox (listBox1.SelectedItems)  tout en le parcourant simultanément 
         * 
         * Solution :
         * Copier les valeurs de listBox1.SelectedItems dans un objet ArrayList au debut du  foreach 
         * Ainsi on peut itérer et supprimer sans avoir cette erreur    ==> System.InvalidOperationException 
         */
        private void btnSupp_Click(object sender, RoutedEventArgs e)
        {
            //IList selectedItems =  listBox1.SelectedItems;

            IList selectedItems = new ArrayList(listBox1.SelectedItems);

            foreach (var item in selectedItems)
            {
                listBox1.Items.Remove(item);
            }
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label2.Content = slider1.Value.ToString();

        }
    }
}
