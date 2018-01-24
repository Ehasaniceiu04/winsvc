using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryLineDataPull
{
   public class CSVWriter:StreamWriter
    {
        public CSVWriter(Stream stream) : base(stream)
        {

        }
        public CSVWriter(string fileName):base(fileName)
        {

        }
        public void Write(SqlDataReader reader)
        {
            for(int i=0;i<reader.FieldCount;i++)
            {
               
            }
        }
    }
}
