using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class FileOperations
    {

        public void CreateFile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");

            using StreamWriter str = fi.CreateText();
            Console.WriteLine("File has been Created");

            str.WriteLine("Rose");
            str.WriteLine("Jasmine");
            Console.WriteLine("written"); 
        }

        public void  WriteData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\Files.sample2.txt", FileMode.CreateNew, FileAccess.Write);
            StreamWriter sw=new StreamWriter(fs);
            Console.WriteLine("Enter the text which you want to write to the file");
            string? str=Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();

        }
    }
}
