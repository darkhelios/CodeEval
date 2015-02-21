using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                char[] c = line.ToCharArray();

                bool control = false;

                foreach (char caracter in c)
                {
                    if (char.IsLower(caracter) == control)
                    {
                        Console.Write(char.ToUpper(caracter));
                        control = false;
                    }
                    else
                    {
                        Console.Write(char.ToLower(caracter));
                        control = true;
                    }

                }

                Console.WriteLine("");
            }
    }
}