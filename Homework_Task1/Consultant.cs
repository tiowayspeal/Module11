using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Task1
{
    internal class Consultant
    {
        List<Client> clients;

        public Consultant() 
        {
            clients = new List<Client>();
            clients = LoadClientsJson();
        }

        /// <summary>
        /// Загружает данные клиентов из Json файла
        /// </summary>
        /// <returns>Возвращает коллекцию типа Client</returns>
        List<Client> LoadClientsJson()
        {
            string json = File.ReadAllText("_clients.json");

            
            clients = JsonConvert.DeserializeObject<List<Client>>(json);

            return new List<Client>();
        }
        
        /// <summary>
        /// Сохраняет данные клиентов в Json
        /// </summary>
        public void SaveClientsJson()
        {
            string json = JsonConvert.SerializeObject(clients);

            File.WriteAllText("_clients.json", json);
        }

        /// <summary>
        /// Изменить номер телефона клиента
        /// </summary>
        /// <param name="id">id клиента в списке clients</param>
        /// <param name="_firstName"></param>
        public void ChangeClientPhoneNumber(int id, string _phoneNumber)
        {
            if (_phoneNumber != null && _phoneNumber != "")
                clients[id].PhoneNumber = _phoneNumber;
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
