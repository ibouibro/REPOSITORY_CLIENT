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

namespace Projet_Cinema_Client
{
    /// <summary>
    /// Logique d'interaction pour UCAddress.xaml
    /// </summary>
    public partial class UCAddress : UserControl
    {
        public UCAddress()
        {
            InitializeComponent();
        }

        private void btAdd_Selected(object sender, RoutedEventArgs e)
        {
           
            GridAddress.Children.Add(new UCAddress_Add());
        }

        private void btEdit_Selected(object sender, RoutedEventArgs e)
        {
            GridAddress.Children.Add(new UCAddress_Edit());
        }

        private void btDel_Selected(object sender, RoutedEventArgs e)
        {
            GridAddress.Children.Add(new UCAddress_Remove());
        }

        private void btList_Selected(object sender, RoutedEventArgs e)
        {
            GridAddress.Children.Add(new UCAddress_List());
        }
    }
}
