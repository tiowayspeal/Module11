using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Task1
{
    internal interface IManager
    {
        /// <summary>
        /// Изменить имя клиента
        /// </summary>
        /// <param name="id">id клиента в списке clients</param>
        /// <param name="_firstName"></param>
        public void ChangeClientFirstName(int id, string _firstName);

        /// <summary>
        /// Изменить фамилию клиента
        /// </summary>
        /// <param name="id">id клиента в списке clients</param>
        /// <param name="_firstName"></param>
        public void ChangeClientSecondName(int id, string _secondName);

        /// <summary>
        /// Изменить отчество клиента
        /// </summary>
        /// <param name="id">id клиента в списке clients</param>
        /// <param name="_firstName"></param>
        public void ChangeClientLastName(int id, string _lastName);

        /// <summary>
        /// Изменить номер паспорта клиента
        /// </summary>
        /// <param name="id">id клиента в списке clients</param>
        /// <param name="_firstName"></param>
        public void ChangeClientPassportNumber(int id, string _passportNumber);
        /// <summary>
        /// Добавить нового клиента
        /// </summary>
        /// <param name="_firstName"></param>
        /// <param name="_secondName"></param>
        /// <param name="_lastName"></param>
        /// <param name="_passportNumber"></param>
        public void AddClient(string _firstName, string _secondName, string _lastName, string _phoneNumber, string _passportNumber);
    
        /// <summary>
        /// Удалить клиента
        /// </summary>
        /// <param name="id">Индекс удаляемого клиента</param>
        public void DeleteClient(int id);
    }
}
