using System;
using System.IO;
namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText("C:\\Users\\Tomas Alfonso\\Desktop\\texto.txt"))
                while (!reader.EndOfStream)
                {

                    string line = reader.ReadLine();

                    Boolean right = true;
                    Boolean left = false;
                    Boolean up = false;
                    Boolean down = false;
                    string[,] arreglo;

                    int xx = 0, yy = 0;

                    int i = 0;

                    string[] a = line.Split(';');

                    yy = int.Parse(a[0]);
                    xx = int.Parse(a[1]);

                    arreglo = null;
                    arreglo = new string[xx, yy];

                    Boolean[,] rev = new Boolean[xx, yy];
                    string[] numeros = a[2].Split(' ');

                    for (int h = 0; h < yy; h++)
                    {
                        for (int j = 0; j < xx; j++)
                        {
                            arreglo[j, h] = numeros[i];
                            rev[j, h] = false;
                            i++;
                        }
                    }

                    i = 0;
                    int x = 0, y = 0;

                    do
                    {
                        Console.Write(arreglo[x, y] + " ");
                        rev[x, y] = true;
                        
                        i++;
                        if (i == xx * yy)
                        {
                            break;
                        }
                        if (right)
                        {
                            if (((x + 1) == xx) || rev[x + 1, y])
                            {
                                right = false;
                                down = true;
                                y++;
                                continue;
                            }
                            else
                            {
                                x++;
                                continue;
                            }
                        }
                        if (down)
                        {
                            if (((y + 1) == xx) || rev[x, y + 1])
                            {
                                down = false;
                                left = true;
                                x--;
                                continue;
                            }
                            else
                            {
                                y++;
                                continue;
                            }
                        }
                        if (left)
                        {
                            if (((x) == 0) || rev[x - 1, y])
                            {
                                left = false;
                                up = true;
                                y--;
                                continue;
                            }
                            else
                            {
                                x--;
                                continue;
                            }
                        }
                        if (up)
                        {
                            if (rev[x, y - 1])
                            {
                                right = true;
                                up = false;
                                x++;
                                continue;
                            }
                            else
                            {
                                y--;
                                continue;
                            }
                        }
                    } while (true);

                    Console.WriteLine();
                    Console.ReadKey();
                }
        }
    }
}