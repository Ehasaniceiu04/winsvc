using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryLineDataPull
{
    public class LogWriter
    {
        public StoryLineAppSettings _storyLineAppSettings;
        public LogWriter()
        {
            _storyLineAppSettings = new StoryLineAppSettings();
        }
        public void Write(string message)
        {
            using (var streamWriter = new StreamWriter(_storyLineAppSettings.LogFilePath + "\\storylinelog.txt", true))
            {
                streamWriter.WriteLine(DateTime.Now.ToString() + " " + message);
                streamWriter.Flush();
            }
        }

    }
}
