using System.IO;

namespace Storage
{
    public static class ConectionStringKOSTIL
    {
        public static string NewConectionString()
        {
            string path = @"ConnectionString.txt";
            string conectionString = "";

            using (StreamReader sr = new StreamReader(path))
            {
                conectionString = sr.ReadToEnd();
            }
            return conectionString;
        }
    }
}
