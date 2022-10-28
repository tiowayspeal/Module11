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
            Logger.Initialize();
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


            List<string>? logPas = JsonConvert.DeserializeObject<List<string>>(json);
            bool msgBoxWrongPair = true;
            if (logPas != null)
                foreach (string line in logPas)
                {
                    if (line == logPasCur)
                    {
                        loginTextBox.Text = "";
                        passwordTextBox.Password = "";
                        ConsultantWindow consultantWindow = new();
                        this.Hide();
                        consultantWindow.Owner = this;
                        consultantWindow.Show();
                        msgBoxWrongPair = false;
                    }
                }
            else
            {
                MessageBox.Show("Ошибка чтения.");
                return;
            }
            if(msgBoxWrongPair)
                MessageBox.Show("Неверный логин или пароль.");
        }

        /// <summary>
        /// Реализация клика на кнопку логина как админа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagerEntryBtn_Click(object sender, RoutedEventArgs e)
        {
            //Check login pass rights 
            string logPasCur = loginTextBox.Text + "|" + passwordTextBox.Password + "|" + 0;

            string json = File.ReadAllText("_logpass.json");

            List<string>? logPas = JsonConvert.DeserializeObject<List<string>>(json);

            bool msgBoxWrongPair = true;
            if(logPas != null)
                foreach (string line in logPas)
                {
                    if (line == logPasCur)
                    {
                        loginTextBox.Text = "";
                        passwordTextBox.Password = "";
                        ManagerWindow managerWindow = new();
                        this.Hide();
                        managerWindow.Owner = this;
                        managerWindow.Show();
                        msgBoxWrongPair = false;
                    }

                }
            else
            {
                MessageBox.Show("Ошибка чтения.");
                return;
            }
            if (msgBoxWrongPair)
                MessageBox.Show("Неверный логин или пароль.");
        }
        /// <summary>
        /// Метод только для демонстрации, проверяет наличие файла с паролями. Создает файл если отсутствует.
        /// </summary>
        private static void CheckOrCreateLogPassFile()
        {
            if (File.Exists("_logpass.json"))
                return;

            List<string> logpass = new();
            logpass.Add("manager|manager|0");
            logpass.Add("manager|manager|1");
            logpass.Add("consultant|consultant|1");
            string json = JsonConvert.SerializeObject(logpass);

            File.WriteAllText("_logpass.json", json);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
