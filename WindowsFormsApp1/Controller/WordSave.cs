using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WindowsFormsApp1
{
    public class WordSave
    {
        public static void WriteFile(string text)
        {
            string path = @"C:\SomeDir5";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            
            // запись в файл
            using (FileStream fstream = new FileStream($"{path}\\note.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
            
        }
    }
}
