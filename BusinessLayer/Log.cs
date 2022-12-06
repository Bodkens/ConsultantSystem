using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessLayer
{


    public class LogList
    {
        public List<Log> logs { get; set; }

        public LogList(List<Log> logs)
        {
            this.logs = logs;
        }
    }


    public class Log
    {
        public static string logPath = @"F:\VP\ConsultantSystem\logs.json";
        public string Login { get; set; }
        public DateTime Date { get; set; }
        public string Action { get; set; }

        public Log(string login, string action)
        {
            Login = login;
            Date = DateTime.Now;
            Action = action;
        }
        //Logging to JSON File
        public void WriteLog()
        {
            
            LogList? list = JsonSerializer.Deserialize<LogList>(File.ReadAllText(Log.logPath));
            
            list?.logs.Add(this);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            if (list != null)
            {
                File.WriteAllText(Log.logPath, JsonSerializer.Serialize(list, options));
            }

        }
    }
}
