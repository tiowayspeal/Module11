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
        readonly ObservableCollection<Client> clientsOC;
        readonly ConsultantUser consultantUser;
        public ConsultantWindow()
        {
            InitializeComponent();
            consultantUser = new ConsultantUser();
            clientsOC = new ObservableCollection<Client>(consultantUser.Clients);
            listBoxClients.ItemsSource = clientsOC;
            Logger.Log(consultantUser, "Consultant Logged", "");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Owner.Close();
        }

        private void ChangePhoneNumber_Click(object sender, RoutedEventArgs e)
        {
            if(ChangeNumberTextBox.Text != null && ChangeNumberTextBox.Text.Length == 11 
                && listBoxClients.SelectedItem != null)
            consultantUser.ChangeClientPhoneNumber(listBoxClients.SelectedIndex, ChangeNumberTextBox.Text);
            listBoxClients.Items.Refresh();
            listBoxClients.SelectedItem = null;
            SaveChangesButtonText.TextDecorations = TextDecorations.Underline;
        }


        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?", "", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                return;
            }
            consultantUser.Clients = new List<Client>(clientsOC);
            consultantUser.SaveClientsJson();
            SaveChangesButtonText.TextDecorations = null;
        }
    }
}
