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

namespace Projet_Cinema_Client.UC.UCRental
{
    /// <summary>
    /// Logique d'interaction pour UCRental.xaml
    /// </summary>
    public partial class UCRental : UserControl
    {
        public UCRental()
        {
            InitializeComponent();
        }
        private void btEdit_Selected(object sender, RoutedEventArgs e)
        {
            gridCity.Children.Add(new UCCity_Edit());
        }


        private void btList_Selected_1(object sender, RoutedEventArgs e)
        {
            gridCity.Children.Add(new UCCity_List());
        }

        private void btAdd_Selected_1(object sender, RoutedEventArgs e)
        {
            gridCity.Children.Add(new UCCity_Add());
        }
    }
}