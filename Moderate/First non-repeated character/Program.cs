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
        using (StreamReader reader = File.OpenText("C:\\Users\\Tomas Alfonso\\Desktop\\texto.txt"))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                var norep = line.GroupBy(g => g).Where(h => h.Count() == 1).Select(h => h.Key).First();

                Debug.WriteLine(norep);
                
            }
    }
}