using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        readonly ObservableCollection<Client> clientsOC;
        readonly ManagerUser managerUser;
        readonly string[] clientDataFields;
        public ManagerWindow()
        {
            InitializeComponent();
            managerUser = new ManagerUser();
            listBoxClients.DataContext = managerUser;
            Client.CreateRandomClients(5, true);
            clientDataFields = new string[5];
            clientsOC = new ObservableCollection<Client>(managerUser.Clients);
            listBoxClients.ItemsSource = clientsOC;
            listItem.ItemsSource = clientDataFields;
            Logger.Log(managerUser, "Manager Logged", "");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Owner.Close();
        }

        private void ListBoxClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxClients.SelectedItem is Client tempClient)
            {
                clientDataFields[0] = tempClient.FirstName;
                clientDataFields[1] = tempClient.SecondName;
                clientDataFields[2] = tempClient.LastName;
                clientDataFields[3] = tempClient.PhoneNumber;
                clientDataFields[4] = tempClient.PassportNumber;
            }
            listItem.Items.Refresh();
        }

        private void ChangeParameter_Click(object sender, RoutedEventArgs e)
        {
            var item = listItem.SelectedItem as String;
            if(ChangeTextBox.Text != null && ChangeTextBox.Text.Length > 0 && ChangeTextBox.Text != item)
                switch(listItem.SelectedIndex)
                {
                    case 0:
                        managerUser.ChangeClientFirstName(listBoxClients.SelectedIndex, ChangeTextBox.Text);
                        break;
                    case 1:
                        managerUser.ChangeClientSecondName(listBoxClients.SelectedIndex, ChangeTextBox.Text);
                        break;
                    case 2:
                        managerUser.ChangeClientLastName(listBoxClients.SelectedIndex, ChangeTextBox.Text);
                        break;
                    case 3:
                        if(ChangeTextBox.Text.All(char.IsDigit) && ChangeTextBox.Text.Length == 11)
                            managerUser.ChangeClientPhoneNumber(listBoxClients.SelectedIndex, ChangeTextBox.Text);
                        break;
                    case 4:
                        if (ChangeTextBox.Text.All(char.IsDigit) && ChangeTextBox.Text.Length == 10)
                            managerUser.ChangeClientPassportNumber(listBoxClients.SelectedIndex, ChangeTextBox.Text);
                        break;
                    default:
                        //How???
                        return;
                }
            
            listBoxClients.Items.Refresh();
            ListBoxClients_SelectionChanged(this, null);
            SaveChangesButtonText.TextDecorations = TextDecorations.Underline;
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?", "", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                return; //do no stuff
            }
            managerUser.Clients = new List<Client>(clientsOC);
            managerUser.SaveClientsJson();
            SaveChangesButtonText.TextDecorations = null;
        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddNewClientWindow addNewClientWindow = new();

            this.Hide();
            addNewClientWindow.Owner = this;
            addNewClientWindow.Show();
            SaveChangesButtonText.TextDecorations = TextDecorations.Underline;
        }

        public void AddClient(List<Client> _clients)
        {
            foreach (Client client in _clients)
            {
                clientsOC.Add(client);
            }
        }
    }
}
