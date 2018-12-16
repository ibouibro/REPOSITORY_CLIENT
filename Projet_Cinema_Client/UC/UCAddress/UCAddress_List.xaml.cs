using Projet_Cinema_Client.ServRefAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Projet_Cinema_Client
{
    /// <summary>
    /// Logique d'interaction pour UCAddress_List.xaml
    /// </summary>
    public partial class UCAddress_List : UserControl
    {
        public UCAddress_List()
        {
            InitializeComponent();
            RemplirDataGrid();
        }
        public void RemplirDataGrid()
        {
            try
            {
                AddressServiceClient asc = new AddressServiceClient();
                List<Address> listAdr = asc.get_list_address().ToList();
                dg.ItemsSource = listAdr;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
