using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPalikka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("json-palikka");
            Console.WriteLine("\n\n(1) Kirjoitetaan luokka jsoniksi " +
                "\n(2) luetaan json luokaksi\n(3) Listasta json " +
                "\n(4) Luetaan lista jsonista ja lisätään tietoja " +
                "\n(5) Lisätään yksittäinen henkilö listana jsoniin");
            var valinta = int.Parse(Console.ReadLine());

            if (valinta == 1)
                HenkilöLisuri();


        }

        public static void HenkilöLisuri()
        {

            Työntekijä duunari = new Työntekijä();

            Console.WriteLine("Anna etunimet: ");
            duunari.Etunimet = Console.ReadLine();

            Console.Write("Anna sukunimi: ");
            duunari.Sukunimi = Console.ReadLine();

            Console.Write("Anna henkilönumero: ");
            duunari.Henkilönumero = int.Parse(Console.ReadLine());

            Console.Write("Syötä palkka: ");
            duunari.Palkka = int.Parse(Console.ReadLine());

            Console.Write("Anna ammattinimike: ");
            duunari.Ammattinimike = Console.ReadLine();


            Console.WriteLine(duunari.Etunimet + " " +
                duunari.Sukunimi + " " +
                duunari.Henkilönumero + " " +
                duunari.Palkka + " " +
                duunari.Ammattinimike);

            Console.WriteLine("\n\nKirjoitetaan JSON...");
            Console.ReadKey();

            duunari.jsonittaja(duunari);

            /*
            string jsonni = JsonConvert.SerializeObject(duunari);

            using (StreamWriter tiedosto = new StreamWriter("d:\\temp\\duunaritesti.json", true))
            {
                tiedosto.WriteLine(jsonni);
            }
            */
            Console.WriteLine("All done!");
            Console.ReadKey();
        }

        
        }
 

    }



}
