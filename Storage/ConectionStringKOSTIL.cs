using System;
using System.IO;

namespace Storage
{
    public static class ConectionStringKOSTIL
    {
        /*
        public string ConectionString { get; set; }

        ConectionStringKOSTIL()
        {
            string path = @"ConnectionString.txt";
            string conectionString = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    conectionString = sr.ReadToEnd();
                }
            }
            catch
            {

                throw new Exception("НЕТ СТРОКИ ПОДКЛЮЧЕНИЯ К СЕРВЕРУ!");
            }

            this.ConectionString = conectionString;
        }
        */
        public static string NewConectionString()
        {

            string path = @"ConnectionString.txt";
            string conectionString = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    conectionString = sr.ReadToEnd();
                }
            }
            catch
            {

                throw new Exception("НЕТ СТРОКИ ПОДКЛЮЧЕНИЯ К СЕРВЕРУ!");
            }

            return conectionString;
        }
    }
}
