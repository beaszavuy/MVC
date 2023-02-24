using System;
using Newtonsoft.Json;
namespace Lib.Model
{
    public class Carte
    {
        [JsonProperty] private uint cod_carte;
        [JsonProperty] private string domeniu;
        [JsonProperty] private string editura;
        [JsonProperty] private string autor;
        [JsonProperty] private string titlu;
        [JsonProperty] private string disponibilitate;
        [JsonProperty] private uint pret;
        public Carte()
        {
            this.cod_carte = 0;
            this.domeniu = "";
            this.editura = "";
            this.autor = "";
            this.titlu = "";
            this.disponibilitate = "";
            this.pret = 0;

        }





        public Carte(uint cod_carte, string domeniu, string editura, string autor, string titlu, string disponibilitate, uint pret)
        {
            this.cod_carte = cod_carte;
            this.domeniu = domeniu;
            this.editura = editura;
            this.autor = autor;
            this.titlu = titlu;
            this.disponibilitate = disponibilitate;
            this.pret = pret;
        }

        public Carte(Carte c)
        {
            this.cod_carte = c.cod_carte;
            this.domeniu = c.domeniu;
            this.editura = c.editura;
            this.autor = c.autor;
            this.titlu = c.titlu;
            this.disponibilitate = c.disponibilitate;
            this.pret = c.pret;
        }

        public uint AccesCodCarte()
        {
            return this.cod_carte;
        }
        public string AccesDomeniu()
        {
            return this.domeniu;
        }
        public string AccesEditura()
        {
            return this.editura;
        }
        public string AccesAutor()
        {
            return this.autor;
        }
        public string AccesTitlu()
        {
            return this.titlu;
        }
        public string AccesDisponibilitate()
        {
            return this.disponibilitate;
        }

        public uint AccesPret()
        {
            return this.pret;
        }

        public void ActualizareCodCarte(uint cod_carte)
        {
            this.cod_carte = cod_carte;
        }
        public void ActualizareDomeniu(string domeniu)
        {
            this.domeniu = domeniu;
        }
        public void ActualizareEditura(string editura)
        {
            this.editura = editura;
        }
        public void ActualizareAutor(string autor)
        {
            this.autor = autor;
        }
        public void ActualizareTitlu(string titlu)
        {
            this.titlu = titlu;
        }
        public void ActualizareDisponibilitate(string disponibilitate)
        {
            this.disponibilitate = disponibilitate;
        }

        public void ActualizarePret(uint pret)
        {
            this.pret = pret;
        }

        public override string ToString()
        {
            return cod_carte.ToString() + ";" + this.domeniu + ";" + this.editura + this.autor + ";" + this.titlu + ";" + this.disponibilitate + ";" + this.pret.ToString();

        }

    }
}
