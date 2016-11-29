using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITC110Assignment9
{
    class ReadFile
    {
        private StreamReader reader;
        private string filePath = null;

        public ReadFile(string path)
        {
            filePath = path;
        }
        public string GetFile()
        {
            string line = null;
            try
            {
                reader = new StreamReader(filePath);
                line = reader.ReadToEnd();
            }
            catch(FileNotFoundException e)
            {
                throw e;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return line;
        }

    }
}
