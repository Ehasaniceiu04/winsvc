using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryLineDataPull
{
    public class StoryLineAppSettings
    {
        private const string tpaanagerdb_connection_string_key = "TPAManagerConnectionString";
        private const string log_file_path_key = "LogFilePath";
        private const string data_file_path_key = "DataFilePath";

        public StoryLineAppSettings()
        {

        }
        //ConnectionString of TPA Manager Db
        public string TPAManagerDBConnectionString { get { return ConfigurationManager.ConnectionStrings[tpaanagerdb_connection_string_key].ConnectionString; } }
        //Parent directory of log file
        public string LogFilePath { get { return ConfigurationManager.AppSettings[log_file_path_key]; } }
        //  Parent Directory of data file
        public string DataFilePath { get { return ConfigurationManager.AppSettings[data_file_path_key]; } }
       

    }
}
