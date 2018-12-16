using Projet_Cinema_Client.ServRefAddress;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Projet_Cinema_Client
{
    /// <summary>
    /// Logique d'interaction pour UCAddress_Edit.xaml
    /// </summary>
    public partial class UCAddress_Edit : UserControl
    {
        public UCAddress_Edit()
        {
            InitializeComponent();
            RemplirCombo();
        }
        public void RemplirCombo()
        {
            try
            {
                AddressServiceClient asc = new AddressServiceClient();
                cbListeAdr.ItemsSource = asc.get_list_address().ToList();
                cbListeAdr.DisplayMemberPath = "AddressName";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbListeAdr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
