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



                foreach (char caracter in c)
                {
                    if (char.IsLower(caracter))
                    {
                        Console.Write(char.ToUpper(caracter));

                    }
                    else
                    {
                        Console.Write(char.ToLower(caracter));
                    }

                }

                Console.WriteLine("");

            }
    }
}