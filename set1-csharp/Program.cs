using set1_csharp.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";
            HashSet<ClientLog> log = new HashSet<ClientLog>();  
            using(StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();
                    log.Add(new ClientLog(line));
                    
                }
            }
            foreach(ClientLog clientLog in log)
            {
                Console.WriteLine(clientLog);
            }
            Console.WriteLine(log.Count());
            Console.ReadKey();


        }
    }
}
