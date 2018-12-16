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

namespace Projet_Cinema_Client.UC.UCCountry
{
    /// <summary>
    /// Logique d'interaction pour UCCountry.xaml
    /// </summary>
    public partial class UCCountry : UserControl
    {
        public UCCountry()
        {
            InitializeComponent();
        }

        private void btEdit_Selected(object sender, RoutedEventArgs e)
        {
            gridCity.Children.Add(new UCCountry_Edit());
        }


        private void btList_Selected(object sender, RoutedEventArgs e)
        {
            gridCity.Children.Add(new UCCountry_List());
        }

        private void btAdd_Selected(object sender, RoutedEventArgs e)
        {
            gridCity.Children.Add(new UCCountry_Add());
        }
    }
}
