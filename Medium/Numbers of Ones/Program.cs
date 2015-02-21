using System;
using System.Collections.Generic;
using System.Diagnostics;
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

                Debug.WriteLine(NumBits(Int32.Parse(line)));

            }
    }

    static int NumBits(int n)
    {
        int cont = 0;
        while (n != 0)
        {
            cont++;
            n &= (n - 1);
        }
        return cont;
    }

}