using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace FightClub
{
    public class Logger
    {
        private List<String> logs;
        public event Action AddLog;
        public event Action ClearLog;
        public Logger() {
            logs = new List<String>();
        }
        public void Add(String log) {
            logs.Add(log);
            AddLog();
        }
        public void Clear() {
            logs.Clear();
            ClearLog();
        }
        public String LastLog() {
            return logs.Last();
        }
        public void WriteToFile(String path) {
            File.AppendAllLines(path,logs);
            File.AppendAllText(path,"\n");
        }

    }
}
