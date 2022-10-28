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
using System.Windows.Shapes;

namespace Homework_Task1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddNewClientWindow.xaml
    /// </summary>
    public partial class AddNewClientWindow : Window
    {
        //readonly ManagerUser managerUser;
        bool countChanged;
        readonly List<Client> clients;
        internal AddNewClientWindow()
        {
            clients = new();
            countChanged = false;
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Owner.Show();
        }

        public bool IsCountChaged()
        {
            return countChanged;
        }
        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> clientDataList = new();

            if(FirstNameTextBox.Text != null && FirstNameTextBox.Text.Length > 0 
                && FirstNameTextBox.Text.Length < 30)
                clientDataList.Add(FirstNameTextBox.Text);

            if (SecondNameTextBox.Text != null && SecondNameTextBox.Text.Length > 0 
                && SecondNameTextBox.Text.Length < 30)
                clientDataList.Add(SecondNameTextBox.Text);

            if (LastNameTextBox.Text != null && LastNameTextBox.Text.Length > 0 
                && LastNameTextBox.Text.Length < 30)
                clientDataList.Add(LastNameTextBox.Text);

            if (PhoneNumberTextBox.Text != null && PhoneNumberTextBox.Text.Length == 11
                && PhoneNumberTextBox.Text.All(Char.IsDigit))
                clientDataList.Add(PhoneNumberTextBox.Text);
            if (PassportNumberTextBox.Text != null && PassportNumberTextBox.Text.Length == 10
                && PassportNumberTextBox.Text.All(Char.IsDigit))
                clientDataList.Add(PassportNumberTextBox.Text);

            if (!clientDataList.All(string.IsNullOrEmpty) && clientDataList.Count != 5)
            {
                MessageBox.Show("Некорректные данные.");
                clientDataList.Clear();
                return;
            }
            var countCheck = clients.Count;
            clients.Add(new Client(clientDataList[0], clientDataList[1], clientDataList[2], clientDataList[3], clientDataList[4]));
            if (clients.Count == countCheck + 1)
            {
                MessageBox.Show("Клиент добавлен.");
                countChanged = true;
                ((ManagerWindow)Owner).AddClient(clients);
                this.Close();
                
            }
        }
    }
}
