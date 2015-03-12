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
        string c = "";

        using (StreamReader reader = File.OpenText("C:\\Users\\CsiPro\\Desktop\\texto.txt"))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                String[] word = line.Split(',');
                String a = word[0].Trim();
                String b = word[1].Trim();
                

                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        if(a[i]==b[j]){

                            if(c==""){
                                c = a.Replace(a[i].ToString(), "");
                            }
                            else
                            {
                                c=c.Replace(a[i].ToString(), "");
                            }
                        }
                    }
                }
                Console.WriteLine(c);
                Console.ReadKey();
                c = "";
            }
    }
}
