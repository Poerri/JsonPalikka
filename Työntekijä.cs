using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonPalikka
{
    class Työntekijä
    {
        public string Etunimet { get; set; }
        public string Sukunimi { get; set; }
        public  int Henkilönumero { get; set; }
        public int Palkka { get; set; }
        public string Ammattinimike { get; set; }


        public void jsonittaja(Työntekijä x)
        {

            string luettuJson = File.ReadAllText("D:\\temp\\duunaritesti2.json");

            List<Työntekijä> duunarit = JsonConvert.DeserializeObject<List<Työntekijä>>(luettuJson);

            duunarit.Add(x);

            string luokkaJsoniksi = JsonConvert.SerializeObject(duunarit);

            System.IO.File.WriteAllText(@"d:\temp\duunaritesti2.json", luokkaJsoniksi);

        }




    }


}
