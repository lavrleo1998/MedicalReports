using System;
using System.Collections.Generic;
using Independentsoft.Office.Odf;
using Independentsoft.Office.Odf.Styles;

namespace ODF
{
    public class Class1
    {
       public static void SaveODF(string organ, List<string> paramTempl)
        {
            TextDocument doc = new TextDocument("output1.odt");

            Font arial = new Font();
            arial.Name = "Arial";
            arial.Family = "Arial";
            arial.GenericFontFamily = GenericFontFamily.Swiss;
            arial.Pitch = FontPitch.Variable;

            doc.Fonts.Add(arial);

            ParagraphStyle style1 = new ParagraphStyle("P100");
            style1.TextProperties.Font = "Arial";
            style1.TextProperties.FontSize = new Size(14, Unit.Point);
            style1.TextProperties.FontWeight = FontWeight.Bold;

            doc.AutomaticStyles.Styles.Add(style1);



            

            Paragraph organPrint = new Paragraph();
            organPrint.Add(organ);
            organPrint.Style = "P100";
            doc.Body.Add(organPrint);

            foreach (var item in paramTempl)
            {
                Paragraph paramTemplPrint = new Paragraph();
                paramTemplPrint.Add(item);
                paramTemplPrint.Style = "P70";
                doc.Body.Add(paramTemplPrint);
            }
                        
            doc.Save("output1.odt", true);
            
        }
    }
}
