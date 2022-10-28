using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Task1
{
    internal class Logger
    {
        public static void Initialize()
        {
            if (File.Exists("_logs.json"))
                return;

            List<string> logs = new();
            string json = JsonConvert.SerializeObject(logs);

            File.WriteAllText("_logs.json", json);
        }
        public static void Log(IUser user, string action, string dataChangeType)
        {
            if (!File.Exists("_logs.json"))
                return;
            StringBuilder sb = new();
            if (user is ConsultantUser)
                sb.Append("Consultant");
            if (user is ManagerUser)
                sb.Append("Manager");
            sb.Append("/" + action);
            sb.Append("/" + DateTime.Now.ToString());
            sb.Append("/" + dataChangeType);
            string json = JsonConvert.SerializeObject(sb);
            File.WriteAllText("_logs.json", json);
        }
    }
}
