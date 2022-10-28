using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Task1
{
    internal class ConsultantUser : IUser
    {
        List<Client> clients;


        public ConsultantUser() 
        {
            clients = new List<Client>();
            clients = LoadClientsJson();
        }

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

        public List<Client> Clients
        {
            get { return clients; }
            set { clients = value; }
        }
        #region Commented Methods
        ///// <summary>
        ///// Изменить имя клиента
        ///// </summary>
        ///// <param name="id">id клиента в списке clients</param>
        ///// <param name="_firstName"></param>
        //public void ChangeClientFirstName(int id, string _firstName)
        //{
        //    if (!isAdmin)
        //        return;
        //    clients[id].FirstName = _firstName;
        //}

        ///// <summary>
        ///// Изменить фамилию клиента
        ///// </summary>
        ///// <param name="id">id клиента в списке clients</param>
        ///// <param name="_firstName"></param>
        //public void ChangeClientSecondName(int id, string _secondName)
        //{
        //    if (!isAdmin)
        //        return;
        //    clients[id].SecondName = _secondName;
        //}

        ///// <summary>
        ///// Изменить отчество клиента
        ///// </summary>
        ///// <param name="id">id клиента в списке clients</param>
        ///// <param name="_firstName"></param>
        //public void ChangeClientLastName(int id, string _lastName)
        //{
        //    if (!isAdmin)
        //        return;
        //    clients[id].LastName = _lastName;
        //}


        ///// <summary>
        ///// Изменить номер паспорта клиента
        ///// </summary>
        ///// <param name="id">id клиента в списке clients</param>
        ///// <param name="_firstName"></param>
        //public void ChangeClientPassportNumber(int id, string _passportNumber)
        //{
        //   if (!isAdmin)
        //        return;
        //    clients[id].PassportNumber = _passportNumber;
        //}
        #endregion
    }
}
