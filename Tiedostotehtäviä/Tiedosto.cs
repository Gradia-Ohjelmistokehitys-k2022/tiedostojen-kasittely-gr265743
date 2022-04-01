using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Tidostotehtäviä
{
    public class Tiedosto
    {
        public static bool tiedostoOnluotu(string tiedosto)
        {
            return File.Exists(tiedosto);
        }

        public static List<string> Luelistaksi(string tiedosto)
        {
            string[] rivit = Luetaulukoiksi(tiedosto);
            List<string> taulukko = new List<string>();

            return taulukko;
        }

        public static string luejonoksi(string tiedosto)
        {
            string[] taulukko = Luetaulukoiksi(tiedosto);
            string returnn = "";
            foreach (string rivit in taulukko)
                returnn += taulukko;
            return returnn;
        }
        public static string[] Luetaulukoiksi(string tiedosto)
        {
            string[] kaikki;
            kaikki = File.ReadAllLines(tiedosto);
            return kaikki;
        }



        public static List<string> luelistaksi(string tiedosto)
        {
            string[] kaikki = Luetaulukoiksi(tiedosto);
            List<string> lista = new List<string>();

            return lista;
        }


    }
    }

