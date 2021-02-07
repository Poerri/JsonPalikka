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
            if (valinta == 2)
                Luokittaja();
            if (valinta == 3)
                Listoittaja();
            if (valinta == 4)
                Listahimmeli();

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

        public static void Luokittaja()
        {
            Console.Clear();
            Console.WriteLine("Jsonista luokaksi");

            string tiedostosta = File.ReadAllText("D:\\temp\\duunaritesti2.json");

            //List<Työntekijä> mestarit = JsonConvert.DeserializeObject<List<Työntekijä>>(tiedostosta);

            //Console.WriteLine(mestarit);
            Console.WriteLine(tiedostosta);






            Console.ReadKey();
        }

        public static void Listoittaja()
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

            Työntekijä duunari2 = new Työntekijä();

            Console.WriteLine("Anna etunimet: ");
            duunari2.Etunimet = Console.ReadLine();

            Console.Write("Anna sukunimi: ");
            duunari2.Sukunimi = Console.ReadLine();

            Console.Write("Anna henkilönumero: ");
            duunari2.Henkilönumero = int.Parse(Console.ReadLine());

            Console.Write("Syötä palkka: ");
            duunari2.Palkka = int.Parse(Console.ReadLine());

            Console.Write("Anna ammattinimike: ");
            duunari2.Ammattinimike = Console.ReadLine();


            List<Työntekijä> duunarit = new List<Työntekijä>();
            duunarit.Add(duunari);
            duunarit.Add(duunari2);

            string jsonni = JsonConvert.SerializeObject(duunarit);

            using (StreamWriter tiedosto = new StreamWriter("D:\\temp\\listajson.json"))
            {
                tiedosto.WriteLine(jsonni);
            }



            Console.ReadLine();
        }

        public static void Listahimmeli()
        {
            Console.Clear();
            Console.WriteLine("Luetaan jsonista");

            string luettuJson = File.ReadAllText("D:\\temp\\listajson.json");

            List<Työntekijä> duunarit = JsonConvert.DeserializeObject<List<Työntekijä>>(luettuJson);

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

            duunarit.Add(duunari);

            string luokkaJsoniksi = JsonConvert.SerializeObject(duunarit);

            using(StreamWriter tiedosto = new StreamWriter("d:\\temp\\listajson.json"))
            {
                tiedosto.WriteLine(luokkaJsoniksi);
            }



            Console.ReadLine();
        }
 

    }



}
