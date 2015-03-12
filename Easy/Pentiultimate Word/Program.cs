using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText("C:\\Users\\CsiPro\\Desktop\\texto.txt"))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;

            String[] words = line.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if(i==words.Length-2){
                    Console.WriteLine(words[i]);
                }
            }

            Console.ReadKey();

        }
    }
}