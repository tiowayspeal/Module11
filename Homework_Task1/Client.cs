using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        public string SecondName 
        { 
            get { return secondName; }
            set
            {
                string tempValue = value;
                if (tempValue != null && tempValue != "")
                    phoneNumber = tempValue;
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
