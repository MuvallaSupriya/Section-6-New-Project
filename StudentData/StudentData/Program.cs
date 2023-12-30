using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    public class Program
    {
        static void filess()
        {
            string path = "C:\\Users\\muval\\Documents\\Project 1.14(Section 6)\\Student Text File.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string[] line = sr.ReadToEnd().Split('\n');
                    foreach (string x in line)
                    {
                        Console.WriteLine(x);
                    }
                }
            }
            else
            {
                using (StreamWriter sr = new StreamWriter(path))
                {
                    sr.WriteLine("Student Roll.No  : 1");
                    sr.WriteLine("Student Name  : A.Anu");
                    sr.WriteLine("Student Address: Hyderabad");
                    sr.Close();
                }

                using (StreamReader sr2 = new StreamReader(path))
                {
                    String[] s2 = sr2.ReadToEnd().Split('\n');
                    foreach (String x in s2)
                    {
                        Console.WriteLine();
                    }
                    sr2.Close();
                }
            }
        }
        static void Main(string[] args)
        {
            filess();
        }
    }
}
