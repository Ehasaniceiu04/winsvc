using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryLineDataPull
{
    public class DataPullManager
    {
        private StoryLineAppSettings _storyLineAppSettings;
        private LogWriter _logWriter;
        public DataPullManager()
        {
            _storyLineAppSettings = new StoryLineAppSettings();
            _logWriter = new LogWriter();
        }
        public void Log(string message)
        {
            using(var streamWriter=new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\log.txt", true))
            {
                streamWriter.WriteLine(DateTime.Now.ToString() + " " + message);
                streamWriter.Flush();
            }
        }
        public bool IsDataAlreadyPulled()
        {
            return true;
        }
        public void WriteToCSV()
        {
            if(IsDataAlreadyPulled())
            {
                _logWriter.Write("Data already pulled");
            }

        }
    }
}
