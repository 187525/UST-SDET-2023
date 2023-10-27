﻿using System;
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

        public void WriteData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\sample2.txt", FileMode.CreateNew, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text which you want to write to the file");
            string? str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();

        }
        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();

            }


        }
        public void CopyMoveFile()
        {

            FileInfo fil = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            FileInfo fi2 = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\sample2.txt");
            fil.CopyTo("C:\\Users\\Administrator\\Desktop\\Files\\Temp1\\Sample.txt");
            fi2.MoveTo("C:\\Users\\Administrator\\Desktop\\Files\\Temp2\\sample2.txt");
        }


        public void DeleteFile()
        {
            FileInfo fi1 = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Temp1\\sample.txt");
            fi1.Delete();

        }

        public void FileProperties()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\sample.txt");
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastWriteTime);
            Console.WriteLine(fi.Length.ToString() );
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.Exists);

        }
    }
    

    
}
