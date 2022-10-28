using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Homework_Task1
{
    public class Client
    {
        string secondName;
        string firstName;
        string lastName;

        string phoneNumber;
        string passportNumber;

        public Client(string _secondName, string _firstName, string _lastName, string _phoneNumber, string _passportNumber)
        {
            secondName = _secondName;
            firstName = _firstName;
            lastName = _lastName;
            phoneNumber = _phoneNumber;
            passportNumber = _passportNumber;
        }

        /// <summary>
        /// Создает json файл с данными об N случайно сгенерированных клиентов, удаляет старые данные при истине второго параметра
        /// </summary>
        /// <param name="clientNumber">Количество клиентов</param>
        /// <param name="deleteOld">true - удалить старые данные в _clients.json</param>
        public static void CreateRandomClients(int clientNumber, bool deleteOld)
        {
            if(deleteOld)
            {
                File.WriteAllText("_clients.json", "");
            }
            List<Client> clients = new();

            for(int i = 0; i < clientNumber; i++)
            {
                clients.Add(new Client(GetRandomString(), //second
                                       GetRandomString(), //first
                                       GetRandomString(), //last names
                                       GetRandomStringNumber(5), //phone
                                       GetRandomStringNumber(5)));//passport numbers
            }
            string json = JsonConvert.SerializeObject(clients);

            File.WriteAllText("_clients.json", json);
        }
        /// <summary>
        /// Возвращает строку случайно сгенерированных чисел заданной длины от 0 до 9
        /// </summary>
        /// <param name="_length">Требуемая длина строки</param>
        /// <returns></returns>
        public static string GetRandomStringNumber(int _length)
        {
            StringBuilder str_build = new();
            Random random = new();

            str_build.Append(random.Next(1, 10));
            for (int i = 1; i < _length; i++)
            {
                str_build.Append(random.Next(10));
            }
            return str_build.ToString();
        }

        /// <summary>
        /// Возвращает строку случайно сгенерированных символов длиной в 5
        /// </summary>
        /// <returns></returns>
        public  static string GetRandomString()
        {
            int length = 5;
            StringBuilder str_build = new();
            Random random = new();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }
        public string SecondName 
        { 
            get { return secondName; }
            set
            {
                string tempValue = value;
                if (tempValue != null && tempValue != "")
                    secondName = tempValue;
            }
        }
        public string FirstName 
        {
            get { return firstName; }
            set
            {
                string tempValue = value;
                if (tempValue != null && tempValue != "")
                    firstName = tempValue;
            }
        }
        public string LastName 
        { 
            get { return lastName; }
            set
            {
                string tempValue = value;
                if (tempValue != null && tempValue != "")
                    lastName = tempValue;
            }
        }
        public string PhoneNumber 
        {  
            get { return phoneNumber; } 
            set 
            {
                string tempValue = value;
                if (tempValue != null && tempValue != "")
                    phoneNumber = tempValue;
            }   
        }
        public string PassportNumber 
        {  
            get { return passportNumber; }
            set
            {
                string tempValue = value;
                if (tempValue != null && tempValue != "")
                    passportNumber = tempValue;
            }
        }

    }
}
