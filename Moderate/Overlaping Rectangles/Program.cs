using System;
using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText("C:\\Users\\Tomas Alfonso\\Desktop\\texto.txt"))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] numeros = line.Split(',');

                    valor a = new valor(int.Parse(numeros[0]), int.Parse(numeros[1]));
                    valor b = new valor(int.Parse(numeros[2]), int.Parse(numeros[3]));
                    valor c  = new valor(int.Parse(numeros[4]), int.Parse(numeros[5]));
                    valor d = new valor(int.Parse(numeros[6]), int.Parse(numeros[7]));

                    if (b.y <= c.y && a.y >= d.y && b.x >= c.x && a.x <= d.x)
                    {
                        Console.WriteLine("True");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("False");
                        Console.ReadKey();
                    }
                }
        }
    }
    class valor
    {
        public int x, y;
        public valor(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
