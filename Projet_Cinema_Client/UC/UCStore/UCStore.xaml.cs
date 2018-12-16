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

namespace Projet_Cinema_Client.UC.UCStore
{
    /// <summary>
    /// Logique d'interaction pour UCStore.xaml
    /// </summary>
    public partial class UCStore : UserControl
    {
        public UCStore()
        {
            InitializeComponent();
        }
        private void btEdit_Selected(object sender, RoutedEventArgs e)
        {
            gridStore.Children.Add(new UCStore_Edit());
        }


        private void btList_Selected_1(object sender, RoutedEventArgs e)
        {
            gridStore.Children.Add(new UCStore_List());
        }

        private void btAdd_Selected_1(object sender, RoutedEventArgs e)
        {
            gridStore.Children.Add(new UCStore_Add());
        }
    }
}