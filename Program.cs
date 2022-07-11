using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Regex12
{
    class Program
    {
        static void Main(string[] args)
        {
             string poem = "";
             string path = @"C:/Users/Я - 6/Documents/Андрей Попов/Стих/Ну что с того....txt";
             using (StreamReader reader = new StreamReader(path))
             {
                 string text = reader.ReadToEnd();
                 poem = text;
             }
             Console.WriteLine(poem);
             Regex regex = new Regex(@"(\w*е\w*)", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(poem);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}
