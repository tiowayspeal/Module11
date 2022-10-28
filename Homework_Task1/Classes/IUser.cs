using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Task1
{
    internal interface IUser
    {
        List<Client> LoadClientsJson();
        void SaveClientsJson();
        void ChangeClientPhoneNumber(int id, string _phoneNumber);
    }
}
