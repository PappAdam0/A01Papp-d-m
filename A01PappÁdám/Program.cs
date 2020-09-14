using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A01PappÁdám
{
    class Program
    {
        public static int[] tomb = new int[1000];
         static void Beolvasas()
        {
            StreamReader olvas = new StreamReader("adatok.dat");
            

            while (!olvas.EndOfStream)
            {
                
                for (int i = 0; i < tomb.Length; i++)
                {
                    tomb[i] = int.Parse(olvas.ReadLine())*2;
                    
                }
                
                
            }
            olvas.Close();
        }
         static int Maximumertek()
        {
            int max = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (max < tomb[i])
                {
                    max = tomb[i];
                    
                }
            }
            return max;
            
        }
        static int Egyediek()
        {
            
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 5 == 0 && tomb[i] % 7 == 0)
                {
                    db++;
                }
            }
            return db;

            StreamWriter iro = new StreamWriter("egyediek.txt");
            for (int i = 0; i < tomb.Length; i++)
            {
                iro.WriteLine(tomb[db]);
            }
            iro.Close();

            
        }
        static void Main(string[] args)
        {
            Beolvasas();
            Console.WriteLine("A maximum: {0}", Maximumertek());
            Console.WriteLine("5 és 7 oszthatóak száma: {0}", Egyediek()); 
            Console.ReadKey();
        }

        
    }
}
