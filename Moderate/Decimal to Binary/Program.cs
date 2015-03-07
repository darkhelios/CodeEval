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
        using (StreamReader reader = File.OpenText("C:\\Users\\Tomas Alfonso\\Desktop\\texto.txt"))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;

            int num = Int32.Parse(line);

            string binario = Convert.ToString(num, 2);
            Console.WriteLine(binario);

        }
    }
}