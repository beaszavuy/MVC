

namespace Lib.Model
{

    public class Utilizator
    {
        private uint legitimatie;
        private string nume;
        private string cont;
        private string parola;
        private string rol;

        public Utilizator()
        {
            this.legitimatie = 0;
            this.nume = "";
            this.cont = "";
            this.parola = "";
            this.rol = "";
        }

        public Utilizator(uint legitimatie, string nume, string cont, string parola, string rol)
        {
            this.legitimatie = legitimatie;
            this.nume = nume;
            this.cont = cont;
            this.parola = parola;
            this.rol = rol;
        }

        public uint AccesLegitimatie()
        {
            return this.legitimatie;
        }

        public string AccesNume()
        {
            return this.nume;
        }

        public string AccesCont()
        {
            return this.cont;
        }

        public string AccesParola()
        {
            return this.parola;
        }

        public string AccesRol()
        {
            return this.rol;
        }

        public void ActualizareLegitimatie(uint legitimatie)
        {
            this.legitimatie = legitimatie;
        }

        public void ActualizareNume(string nume)
        {
            this.nume = nume;
        }

        public void ActualizareCont(string cont)
        {
            this.cont = cont;
        }

        public void ActualizareParola(string parola)
        {
            this.parola = parola;
        }

        public void ActualizareRol(string rol)
        {
            this.rol = rol;
        }

        public override string ToString()
        {
            string s = this.legitimatie + ";" + this.nume + ";" + this.cont + ";" + this.parola + ";" + this.rol;
            return s;
        }
    }
}
