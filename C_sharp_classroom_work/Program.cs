using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_sharp_classroom_work
{
    internal class Program
    {
        delegate void myDel(string text);
        static string LoadFromFile(string _path)
        {           
            StreamReader sr = new StreamReader(_path);
            string result = sr.ReadToEnd();
            sr.Close();
            return result;
        }
        static void Main(string[] args)
        {
            string user, path = "text.txt";
            
             if(args.Length > 0)
             {
                user = args[0];
                Console.WriteLine($"Файл {path} содержит:\n{LoadFromFile(path)}\n");
               
               
                MatchCollection name = Regex.Matches(LoadFromFile(path), user);
                MatchCollection matches = Regex.Matches(LoadFromFile(path), @"(\d{1,})");
               
                foreach (Match num in name) { 
                    Console.WriteLine(num);
                    foreach (var item in matches)
                    {                        
                        Console.WriteLine(item);
                    }                   
                }              
            }
             else
                 Console.WriteLine("Нет аргументов командной строки");

                      

            

           

            
            

        }
    }
}
