using System;
using System.IO;
using System.Text;

namespace ReadWrite
{

    class WorkingWithTextFile
    {
        public static string str = ""; 

        public static void Write()
        {
            try
            {
                StreamWriter sw = new StreamWriter("E:\\Text.txt", true);
                sw.WriteLine(str);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void Read()
        {
            try
            {
                StreamReader sr = new StreamReader("E:\\Text.txt");
                str = sr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithTextFile.Write();
            WorkingWithTextFile.Read();
        }
    }
}
