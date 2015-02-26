using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = "A quick brown fox jumps over the lazy dog";

            List<char> list = new List<char>();
            string nada = "";
            char[] ch = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v','w','x','y' ,'z'}; 
            
            char[] arr = line.ToLower().ToCharArray();
            
           

            for (int i = 0; i < arr.Length; i++)
            {
                if (!list.Contains(arr[i]))
                {
                    list.Add(arr[i]);
                    
                }
            }
            
            for (int i = 0; i < ch.Length; i++)
            {
                if (!list.Contains(ch[i]))
                {
                    nada = nada + Convert.ToString(ch[i]);
                }
            }

            if (nada.Length == 0)
            {
                Console.WriteLine("NULL");
            }
            else 
            {
                Console.WriteLine(nada);
            }

            Console.ReadKey();
        }
    }
}
