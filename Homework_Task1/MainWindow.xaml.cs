using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;
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

namespace Homework_Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CheckOrCreateLogPassFile();
        }

        
        /// <summary>
        /// Реализация клика на кнопку логина как консультанта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultantEntryBtn_Click(object sender, RoutedEventArgs e)
        {
            //Check login pass rights 
            string logPasCur = loginTextBox.Text + "|" + passwordTextBox.Password + "|" + 1;

            string json = File.ReadAllText("_logpass.json");

            List<string> logPas = new List<string>();

            logPas = JsonConvert.DeserializeObject<List<string>>(json);
            bool msgBoxWrongPair = true;
            foreach (string line in logPas)
            {
                if (line == logPasCur)
                {
                    loginTextBox.Text = "";
                    passwordTextBox.Password = "";
                    ConsultantWindow consultantWindow = new ConsultantWindow();
                    this.Hide();
                    consultantWindow.Owner = this;
                    consultantWindow.Show();
                    msgBoxWrongPair = false;
                }
            }
            if(msgBoxWrongPair)
                MessageBox.Show("Неверный логин или пароль.");
        }

        /// <summary>
        /// Реализация клика на кнопку логина как админа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminEntryBtn_Click(object sender, RoutedEventArgs e)
        {
            //Check login pass rights 
            string logPasCur = loginTextBox.Text + "|" + passwordTextBox.Password + "|" + 0;

            string json = File.ReadAllText("_logpass.json");

            List<string> logPas = new List<string>();

            logPas = JsonConvert.DeserializeObject<List<string>>(json);

            bool msgBoxWrongPair = true;
            foreach (string line in logPas)
            {
                if (line == logPasCur)
                {
                    loginTextBox.Text = "";
                    passwordTextBox.Password = "";
                    AdminWindow adminWindow = new AdminWindow();
                    this.Hide();
                    adminWindow.Owner = this;
                    adminWindow.Show();
                    msgBoxWrongPair = false;
                }

            }
            if (msgBoxWrongPair)
                MessageBox.Show("Неверный логин или пароль.");
        }
        /// <summary>
        /// Метод только для демонстрации, проверяет наличие файла с паролями. Создает файл если отсутствует.
        /// </summary>
        private void CheckOrCreateLogPassFile()
        {
            if (File.Exists("_logpass.json"))
                return;

            List<string> logpass = new List<string>();
            logpass.Add("admin|admin|0");
            logpass.Add("admin|admin|1");
            logpass.Add("consultant|consultant|1");
            string json = JsonConvert.SerializeObject(logpass);

            File.WriteAllText("_logpass.json", json);
        }
    }
}
