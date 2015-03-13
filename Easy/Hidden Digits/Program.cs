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

                char[] c = line.ToCharArray();
                string result = "";

                for (int i = 0; i < c.Length; i++)
                {

                    try
                    {
                        if(Char.IsNumber(c[i])){

                            result += c[i];

                        }
                        else
                        {

                        switch (c[i].ToString())

                        {
                            case "a":
                                result += "0";
                                break;

                            case "b":
                                result += "1";
                                break;

                            case "c":
                                result += "2";
                                break;

                            case "d":
                                result += "3";
                                break;

                            case "e":
                                result += "4";
                                break;

                            case "f":
                                result += "5";
                                break;

                            case "g":
                                result += "6";
                                break;

                            case "h":
                                result += "7";
                                break;

                            case "i":
                                result += "8";
                                break;

                            case "j":
                                result += "9";
                                break;    
                           }
                        }
                    }
                    catch
                    {
                             
                    }
                }


                if (result == "")
                {
                    Console.Write("NONE");
                }
                else
                {
                    Console.Write(result);
                }
                    

                Console.ReadKey();
            }
    }
}