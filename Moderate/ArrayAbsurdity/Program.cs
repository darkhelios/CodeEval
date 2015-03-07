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

                string[] letras = line.Split(';');
                string[] a = letras[1].Split(',');
                string[] b = a.Distinct().ToArray();


                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            Console.WriteLine(a[j]);
                        }
                    }

                }
            }
    }
}