using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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

                string[] letras1 = line.Split('|');

                string[] a = letras1[0].Split(' ');
                string[] b = letras1[1].Split(' ');
                string res = "";


                string[] dos = new string[letras1.Length];

                for (int i = 0; i < a.Length - 1; i++)
                {
                    int numa = Int32.Parse(a[i]);
                    int numb = Int32.Parse(b[i + 1]);

                    res += (numa * numb) + " ";

                }

                Console.WriteLine(res.Trim());

            }
    }
}