using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace Homework_Task1
{
    /// <summary>
    /// Логика взаимодействия для ConsultantWindow.xaml
    /// </summary>
    public partial class ConsultantWindow : Window
    {
        ObservableCollection<Client> clientsOC;
        ConsultantUser consultantUser;
        public ConsultantWindow()
        {
            InitializeComponent();
            Client.CreateRandomClients(5, true);
            consultantUser = new ConsultantUser();
            clientsOC = new ObservableCollection<Client>(consultantUser.Clients);
            listBoxClients.ItemsSource = clientsOC;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Owner.Close();
        }

        private void ChangePhoneNumber_Click(object sender, RoutedEventArgs e)
        {
            if(ChangeNumberTextBox.Text != null && ChangeNumberTextBox.Text.Length > 0 && listBoxClients.SelectedItem != null)
                (listBoxClients.SelectedItem as Client).PhoneNumber = ChangeNumberTextBox.Text;
            listBoxClients.Items.Refresh();
            listBoxClients.SelectedItem = null;
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            consultantUser.Clients = new List<Client>(clientsOC);
        }
    }
}
