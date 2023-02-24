using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Model
{
    public class SalvareCSV : Salvare
    {
        private static string FILENAME = "carti_filtrate.csv";
        public override void SalvareCartiFiltrate(List<Carte> lista)
        {

            string path = getPath(FILENAME);

            StringBuilder csvcontent = new StringBuilder();

            bool header = false;
            if (File.Exists(path))
                File.Delete(path);
            foreach (Carte carte in lista)
            {
                uint cod_carte = carte.AccesCodCarte();
                string domeniu = carte.AccesDomeniu();
                string editura = carte.AccesEditura();
                string autor = carte.AccesAutor();
                string titlu = carte.AccesTitlu();
                string disponibilitate = carte.AccesDisponibilitate();
                uint pret = carte.AccesPret();


                string csv;
                string[] car_csv = { cod_carte.ToString(), domeniu, editura, autor, titlu, disponibilitate, pret.ToString() };

                if (header == false)
                {
                    csvcontent.AppendLine("COD, domeniu, editura, autor, titlu, disponibilitate, pret");
                    header = true;
                }
                csv = string.Join(",", car_csv);
                csvcontent.AppendLine(csv);
            }
            File.AppendAllText(path, csvcontent.ToString());

        }
    }
}
