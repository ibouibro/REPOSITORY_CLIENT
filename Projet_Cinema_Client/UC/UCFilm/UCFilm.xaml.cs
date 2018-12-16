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

namespace Projet_Cinema_Client.UC.UCFilm
{
    /// <summary>
    /// Logique d'interaction pour UCFilm.xaml
    /// </summary>
    public partial class UCFilm : UserControl
    {
        public UCFilm()
        {
            InitializeComponent();
        }
        private void btEdit_Selected(object sender, RoutedEventArgs e)
        {
            gridFilm.Children.Add(new UCFilm_Edit());
        }


        private void btList_Selected_1(object sender, RoutedEventArgs e)
        {
            gridFilm.Children.Add(new UCFilm_List());
        }

        private void btAdd_Selected_1(object sender, RoutedEventArgs e)
        {
            gridFilm.Children.Add(new UCFilm_Add());
        }
    }
}
