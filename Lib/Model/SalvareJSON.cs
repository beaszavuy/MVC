using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lib.Model
{
    public class SalvareJSON : Salvare
    {
        private static string FILENAME = "carti_filtrate.json";


        public override void SalvareCartiFiltrate(List<Carte> lista)
        {
            string path = getPath(FILENAME);

            StringBuilder csvcontent = new StringBuilder();

            string result = JsonConvert.SerializeObject(lista);

            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(result.ToString());
                tw.Close();
            }
        }
    }
}
