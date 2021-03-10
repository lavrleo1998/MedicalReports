using System;
using Independentsoft.Office.Odf;

namespace ODF
{
    public class Class1
    {
       public static void SaveODF()
        {
            TextDocument doc = new TextDocument();

            Paragraph p1 = new Paragraph();
            p1.Add("Hello World");

            doc.Body.Add(p1);

            doc.Save("output.odt", true);
        }
    }
}
