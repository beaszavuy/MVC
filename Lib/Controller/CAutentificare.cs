using Lib.Model;
using Lib.Model.Persistenta;
using Lib.View;
using System;
using System.Windows.Forms;

namespace Lib.Controller
{

    public class CAutentificare
    {
        private AutentificareV autentificareV;
        private UtilizatorPersistenta utilizatorPersistenta;

        public CAutentificare()
        {
            this.autentificareV = new AutentificareV();
            this.utilizatorPersistenta = new UtilizatorPersistenta();
            this.gestionareEvenimente();
        }

        public AutentificareV AccesAutentificareView()
        {
            return this.autentificareV;
        }

        private void gestionareEvenimente()
        {
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            this.autentificareV.AccesBtnAutentificare().Click += new EventHandler(autentificare);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        }

        private void autentificare(object sender, EventArgs e)
        {
            string user = this.autentificareV.AccesUserView().Text;
            string parola = this.autentificareV.AccesParolaView().Text;

            if (user == "" || parola == "")
            {
                MessageBox.Show("Introduceti toate datele de logare!!");
            }
            else
            {
                Utilizator utilizator = this.utilizatorPersistenta.CautareUtilizator(user, parola);

                if (utilizator == null)
                {
                    MessageBox.Show("Nu exista utilizator cu datele specificate!");
                    this.autentificareV.AccesUserView().Text = "";
                    this.autentificareV.AccesParolaView().Text = "";
                }
                else
                {
                    this.autentificareV.Hide();
                    string rol = utilizator.AccesRol();
                    if (rol == "ADMINISTRATOR")
                    {
                        CAdministrator adminC = new CAdministrator();
                        adminC.AccesAdministratorV().Show();
                    }
                    else
                    {
                        CAngajat angajatC = new CAngajat();
                        angajatC.AccesAngajatV().Show();

                    }
                }
            }

        }

    }
}
