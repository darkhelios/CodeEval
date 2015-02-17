using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HappyNumbers { 
class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string hn = reader.ReadLine();
                if (null == hn)
                {
                    continue;
                }

                ArrayList array = new ArrayList();
                double res = 0;
                double numero = 0;

                do{

                    for (int i = 0; i < hn.Length; i++)
                    {

                        numero = Int32.Parse(hn[i].ToString());
                        res = res + (Math.Pow(numero,2));
                    }

                    if (res == 1) {

                        Console.WriteLine(1);
                        break;

                    } else {

                        if (!array.Contains(res)) {

                            array.Add(res);

                        } else {

                            Console.WriteLine(0);
                            break;
                        }
                    }

                    hn = res.ToString();
                    res = 0;

                } while (true);
            }

        Console.ReadKey();
    }
}
}