using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Tidostotehtäviä
{
    public class Tidostotehtäviä
    {
        


        static void Main(string[] args)
        {

            string tiedosto = @"C:\Users\tommy\tekstii.txt";
            using (FileStream uusi = File.Create(tiedosto))


                Console.WriteLine("Tarkistetaan : anna tiedoston nimi: ");
            Console.ReadLine();

            if (File.Exists(tiedosto))
            {
                Console.WriteLine("tiedosto on olemassa");
            }
            else
            {
                Console.WriteLine("Tiedosta ei löydy");
            }
            using (StreamWriter writer = new StreamWriter(tiedosto))
            {
                writer.WriteLine("Hello world");
                writer.WriteLine("uusi rivi tässä");
                
            }
             


            Console.WriteLine("luetaan tiedosto taulukoksi");
            Console.WriteLine(File.ReadAllText(@"C:\Users\tommy\tekstii.txt"));
            Console.ReadLine();
            
            Console.WriteLine("Luetaan tiedoto merkkijonoksi");
            Console.WriteLine((@"C:\Users\tommy\tekstii.txt"));
            Console.ReadLine();
           
            Console.WriteLine("Luetaan tiedosto listaksi");
            Console.WriteLine(File.ReadAllText(@"C:\Users\tommy\tekstii.txt"));
            Console.ReadLine();


            string readText = File.ReadAllText(tiedosto);
            Console.WriteLine(readText);

            char pilkku;
            int pilkulla = 0;
            StreamReader lukee;
            lukee = new StreamReader(@"C:\Users\tommy\tekstii.txt");
            do 
            {
                pilkku = (char)lukee.Read();
                Console.Write(" , ");
                 Console.Write(pilkku);


                pilkulla++;
            } while (!lukee.EndOfStream);
            lukee.Close();










        }

    }
}
    





        