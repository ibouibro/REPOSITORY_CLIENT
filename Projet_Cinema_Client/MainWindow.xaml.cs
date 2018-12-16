using Projet_Cinema_Client.UC.UCCity;
using Projet_Cinema_Client.UC.UCCountry;
using Projet_Cinema_Client.UC.UCCustomer;
using Projet_Cinema_Client.UC.UCFilm;
using Projet_Cinema_Client.UC.UCInventory;
using Projet_Cinema_Client.UC.UCRental;
using Projet_Cinema_Client.UC.UCStaff;
using Projet_Cinema_Client.UC.UCStore;
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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //public UCCity uchome = new UCHome();
        public UCCountry uccount = new UCCountry();
        public UCCity uccity = new UCCity();
        public UCStore ucstore = new UCStore();
        public UCStaff ucstaff = new UCStaff();
        public UCAddress ucaddr = new UCAddress();
        public UCFilm ucfilm = new UCFilm();
        public UCCustomer uccustom = new UCCustomer();
        public UCRental ucrental = new UCRental();
        public UCInventory ucinv = new UCInventory();
        
        private void btAddr_Selected(object sender, RoutedEventArgs e)
        {
            gridCentre.Children.Remove(uccount);
            gridCentre.Children.Remove(uccity);
            gridCentre.Children.Remove(ucstore);
            gridCentre.Children.Remove(ucstaff);
            //gridCentre.Children.Remove(ucaddr);
            gridCentre.Children.Remove(ucfilm);
            gridCentre.Children.Remove(uccustom);
            gridCentre.Children.Remove(ucrental);
            gridCentre.Children.Remove(ucinv);
            
            gridCentre.Children.Add(ucaddr);
            SectionTB.Text = "Address";

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btCity_Selected(object sender, RoutedEventArgs e)
        {
            gridCentre.Children.Remove(uccount);
            gridCentre.Children.Remove(ucstore);
            gridCentre.Children.Remove(ucstaff);
            gridCentre.Children.Remove(ucaddr);
            gridCentre.Children.Remove(ucfilm);
            gridCentre.Children.Remove(uccustom);
            gridCentre.Children.Remove(ucrental);
            gridCentre.Children.Remove(ucinv);
            SectionTB.Text = "Cities";
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void btCountry_Selected(object sender, RoutedEventArgs e)
        {
            gridCentre.Children.Add(uccount);
            gridCentre.Children.Remove(uccity);
            gridCentre.Children.Remove(ucstore);
            gridCentre.Children.Remove(ucstaff);
            gridCentre.Children.Remove(ucaddr);
            gridCentre.Children.Remove(ucfilm);
            gridCentre.Children.Remove(uccustom);
            gridCentre.Children.Remove(ucrental);
            gridCentre.Children.Remove(ucinv);

            SectionTB.Text = "Countries";
        }

        private void btStore_Selected(object sender, RoutedEventArgs e)
        {
            gridCentre.Children.Remove(uccount);
            gridCentre.Children.Remove(uccity);
            gridCentre.Children.Add(ucstore);
            gridCentre.Children.Remove(ucstaff);
            gridCentre.Children.Remove(ucaddr);
            gridCentre.Children.Remove(ucfilm);
            gridCentre.Children.Remove(uccustom);
            gridCentre.Children.Remove(ucrental);
            gridCentre.Children.Remove(ucinv);

            SectionTB.Text = "Stores";
        }

        private void btStaff_Selected(object sender, RoutedEventArgs e)
        {
            gridCentre.Children.Remove(uccount);
            gridCentre.Children.Remove(uccity);
            gridCentre.Children.Remove(ucstore);
            gridCentre.Children.Add(ucstaff);
            gridCentre.Children.Remove(ucaddr);
            gridCentre.Children.Remove(ucfilm);
            gridCentre.Children.Remove(uccustom);
            gridCentre.Children.Remove(ucrental);
            gridCentre.Children.Remove(ucinv);

            SectionTB.Text = "Staffs";
        }

        private void btFilm_Selected(object sender, RoutedEventArgs e)
        {
            gridCentre.Children.Remove(uccount);
            gridCentre.Children.Remove(uccity);
            gridCentre.Children.Remove(ucstore);
            gridCentre.Children.Remove(ucstaff);
            gridCentre.Children.Remove(ucaddr);
            gridCentre.Children.Add(ucfilm);
            gridCentre.Children.Remove(uccustom);
            gridCentre.Children.Remove(ucrental);
            gridCentre.Children.Remove(ucinv);

            SectionTB.Text = "Films";
        }

        private void btCustomer_Selected(object sender, RoutedEventArgs e)
        {
            gridCentre.Children.Remove(uccount);
            gridCentre.Children.Remove(uccity);
            gridCentre.Children.Remove(ucstore);
            gridCentre.Children.Remove(ucstaff);
            gridCentre.Children.Remove(ucaddr);
            gridCentre.Children.Remove(ucfilm);
            gridCentre.Children.Add(uccustom);
            gridCentre.Children.Remove(ucrental);
            gridCentre.Children.Remove(ucinv);

            SectionTB.Text = "Customers";
        }

        private void btRental_Selected(object sender, RoutedEventArgs e)
        {
            gridCentre.Children.Remove(uccount);
            gridCentre.Children.Remove(uccity);
            gridCentre.Children.Remove(ucstore);
            gridCentre.Children.Remove(ucstaff);
            gridCentre.Children.Remove(ucaddr);
            gridCentre.Children.Remove(ucfilm);
            gridCentre.Children.Remove(uccustom);
            gridCentre.Children.Add(ucrental);
            gridCentre.Children.Remove(ucinv);

            SectionTB.Text = "Rentals";
        }

        private void btInventory_Selected(object sender, RoutedEventArgs e)
        {
            gridCentre.Children.Remove(uccount);
            gridCentre.Children.Remove(uccity);
            gridCentre.Children.Remove(ucstore);
            gridCentre.Children.Remove(ucstaff);
            gridCentre.Children.Remove(ucaddr);
            gridCentre.Children.Remove(ucfilm);
            gridCentre.Children.Remove(uccustom);
            gridCentre.Children.Remove(ucrental);
            gridCentre.Children.Add(ucinv);

            SectionTB.Text = "Inventory";
        }
    }
}
