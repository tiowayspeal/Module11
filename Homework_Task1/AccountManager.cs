using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Task1
{
    internal class AccountManager
    {
        /// <summary>
        /// Одноразовый метод задать логин пароль для админа.
        /// </summary>
        public void SetAdminLogPass()
        {
            Dictionary<string, string> logPassPairs = new Dictionary<string, string>();
            logPassPairs.Add("admin", "admin");

            string json = JsonConvert.SerializeObject(logPassPairs);

            File.WriteAllText("_logpass.json", json);
        }

        /// <summary>
        /// Проверяел связку логин пароль на существование в файле _logpass.json
        /// </summary>
        /// <param name="_login"></param>
        /// <param name="_password"></param>
        /// <returns></returns>
        public bool CheckLoginPassword(string _login, string _password)
        {
            Dictionary<string, string> logPassPairs = new Dictionary<string, string>();

            string json = File.ReadAllText("_logpass.json");

            logPassPairs = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);


            if(logPassPairs != null && logPassPairs.ContainsKey(_login) && logPassPairs[_login] == _password)
                return true;

            return false;
        }

    }
}
