using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Task1
{
    internal class ManagerUser : IUser, IManager
    {
        List<Client> clients;
        public ManagerUser()
        {
            clients = new List<Client>();
            clients = LoadClientsJson();
        }

        ///// <summary>
        ///// Загружает данные клиентов из Json файла
        ///// </summary>
        ///// <returns>Возвращает коллекцию типа Client</returns>
        //List<Client> LoadClientsJson()
        //{
        //    string json = File.ReadAllText("_clients.json");


        //    clients = JsonConvert.DeserializeObject<List<Client>>(json);

        //    return new List<Client>();
        //}

        ///// <summary>
        ///// Сохраняет данные клиентов в Json
        ///// </summary>
        //public void SaveClientsJson()
        //{
        //    string json = JsonConvert.SerializeObject(clients);

        //    File.WriteAllText("_clients.json", json);
        //}

        ///// <summary>
        ///// Изменить номер телефона клиента
        ///// </summary>
        ///// <param name="id">id клиента в списке clients</param>
        ///// <param name="_firstName"></param>
        //public void ChangeClientPhoneNumber(int id, string _phoneNumber)
        //{
        //    if ( id >= 0 && id < clients.Count && _phoneNumber != null && _phoneNumber != "")
        //        clients[id].PhoneNumber = _phoneNumber;
        //}

        #region Commented Methods

        /// <summary>
        /// Загружает данные клиентов из Json файла
        /// </summary>
        /// <returns>Возвращает коллекцию типа Client</returns>
        public List<Client> LoadClientsJson()
        {
            string json = File.ReadAllText("_clients.json");

            var returnData = JsonConvert.DeserializeObject<List<Client>>(json);

            if (returnData != null)
            {
                Logger.Log(this, "Data Loaded", "_clients.json");
                return returnData;
            }
            else
                return new();

            //return JsonConvert.DeserializeObject<List<Client>>(json);
        }

        /// <summary>
        /// Сохраняет данные клиентов в Json
        /// </summary>
        public void SaveClientsJson()
        {
            string json = JsonConvert.SerializeObject(clients);

            File.WriteAllText("_clients.json", json);

            Logger.Log(this, "Changes Saved", "_clients.json");
        }

        /// <summary>
        /// Изменить имя клиента
        /// </summary>
        /// <param name="id">id клиента в списке clients</param>
        /// <param name="_firstName"></param>
        public void ChangeClientFirstName(int id, string _firstName)
        {
            if (id >= 0 && id < Clients.Count && _firstName != null && _firstName.Length < 30
                && _firstName.Length > 0)
            Clients[id].FirstName = _firstName;
            Logger.Log(this, "Redacted", "FirstName");
        }

        /// <summary>
        /// Изменить фамилию клиента
        /// </summary>
        /// <param name="id">id клиента в списке clients</param>
        /// <param name="_firstName"></param>
        public void ChangeClientSecondName(int id, string _secondName)
        {
            if (id >= 0 && id < Clients.Count && _secondName != null && _secondName.Length < 30
                && _secondName.Length > 0)
            Clients[id].SecondName = _secondName;
            Logger.Log(this, "Redacted", "SecondName");
        }

        /// <summary>
        /// Изменить отчество клиента
        /// </summary>
        /// <param name="id">id клиента в списке clients</param>
        /// <param name="_firstName"></param>
        public void ChangeClientLastName(int id, string _lastName)
        {
            if (id >= 0 && id < Clients.Count && _lastName != null && _lastName.Length < 30
                && _lastName.Length > 0)
            Clients[id].LastName = _lastName;
            Logger.Log(this, "Redacted", "LastName");
        }

        /// <summary>
        /// Изменить номер телефона клиента
        /// </summary>
        /// <param name="id">id клиента в списке clients</param>
        /// <param name="_firstName"></param>
        public void ChangeClientPhoneNumber(int id, string _phoneNumber)
        {
            if (id >= 0 && id < clients.Count && _phoneNumber != null 
                && _phoneNumber.Length == 11)
                clients[id].PhoneNumber = _phoneNumber;
            Logger.Log(this, "Redacted", "PhoneNumber");
        }

        /// <summary>
        /// Изменить номер паспорта клиента
        /// </summary>
        /// <param name="id">id клиента в списке clients</param>
        /// <param name="_firstName"></param>
        public void ChangeClientPassportNumber(int id, string _passportNumber)
        {
            if(id >= 0 && id< Clients.Count && _passportNumber != null 
                && _passportNumber.Length == 10)
                Clients[id].PassportNumber = _passportNumber;
            Logger.Log(this, "Redacted", "PassportNumber");
        }

        /// <summary>
        /// Добавить нового клиента
        /// </summary>
        /// <param name="_firstName"></param>
        /// <param name="_secondName"></param>
        /// <param name="_lastName"></param>
        /// <param name="_passportNumber"></param>
        public void AddClient(string _firstName, string _secondName, string _lastName, 
            string _phoneNumber, string _passportNumber)
        {
            Clients.Add(new Client(_secondName, _firstName, _lastName, 
                _phoneNumber, _passportNumber));
            Logger.Log(this, "New Client Added", "Client");
        }
        public List<Client> Clients
        {
            get { return clients; }
            set { clients = value; }
        }
        #endregion
    }
}
