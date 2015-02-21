using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

                var letras = line.ToArray();

                if (letras.Length <= 55)
                {
                    Console.WriteLine(string.Join("", letras));
                    
                }
                else
                {
                    string read = "... <Read More>";

                    string str = line.Substring(0, 40);
                    
                    if(str.Contains(" ")){
                        
                        str = line.Substring(0, str.LastIndexOf(' ')).Trim();

                    }

                    Console.WriteLine(str + read);
                }
            }
    }
}