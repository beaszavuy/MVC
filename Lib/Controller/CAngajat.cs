using Lib.Model;
using Lib.Model.Persistenta;
using Lib.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lib.Controller
{
    public class CAngajat
    {
        
            private AngajatV angajatV;
            private CartePersistenta cartePersistenta;

            public CAngajat()
            {
                this.angajatV = new AngajatV();
                this.cartePersistenta = new CartePersistenta();
                this.gestionareEvenimente();
            }

            public AngajatV AccesAngajatV()
            {
                return this.angajatV;
            }

            public void gestionareEvenimente()
            {
                this.angajatV.AccesBtnAdaugareCar().Click += new EventHandler(adaugare);
                this.angajatV.AccesBtnActualizareCar().Click += new EventHandler(actualizare);
                this.angajatV.AccesBtnStergereCar().Click += new EventHandler(stergere);
                this.angajatV.AccesBtnListaCar().Click += new EventHandler(vizualizare);
                this.angajatV.AccesBtnCautareCarTitlu().Click += new EventHandler(cauta);
                this.angajatV.AccesBtnFiltrareCar().Click += new EventHandler(filtreaza);
                this.angajatV.AccesBtnSortare().Click += new EventHandler(sorteaza);
                this.angajatV.AccesBtnDeconectare().Click += new EventHandler(deconectare);
            }

            private void adaugare(object sender, EventArgs e)
            {

                bool dateCorecte = true;
                string cod_car = this.angajatV.AccesTxtCodCar().Text;
                string domeniu = this.angajatV.AccesTxtDomeniuCar().Text;
                string editura = this.angajatV.AccesTxtEdituraCar().Text;
                string autor = this.angajatV.AccesTxtAutorCar().Text;
                string titlu = this.angajatV.AccesTxtTitluCar().Text; 
                string disponibilitate = this.angajatV.AccesCmbtDisponibilitateCar().Text;  
                string pret = this.angajatV.AccesTxtPretCar().Text;
                

                if (cod_car == "" || domeniu == "" || editura == "" || autor == "" || titlu == "" || disponibilitate == "" || pret == "")
                {
                    dateCorecte = false;
                    MessageBox.Show("Nu au fost introduse toate datele necesare!");
                }
                else
                {
                    uint cod;

                    bool conversie = uint.TryParse(cod_car, out cod);
                    if (conversie)
                    {
                        cod = Convert.ToUInt32(cod_car);
                        if (cod == 0)
                        {
                            dateCorecte = false;
                            MessageBox.Show("COD-ul nu poate fi 0!");
                        }
                    }

                    if ((!Regex.IsMatch(cod_car, @"^\d+$")) && cod_car != "")
                    {
                        MessageBox.Show("COD-ul trebuie sa fie compus din cifre!!!");
                        dateCorecte = false;
                    }

                 

                    if (this.cartePersistenta.CautareCarte(cod) != null)
                    {
                        MessageBox.Show("Exista deja o carte cu acest COD!");
                        dateCorecte = false;
                    }
                    else
                    {
                        uint pretul;
                        conversie = uint.TryParse(pret, out pretul);
                        if (conversie == true)
                        {
                            pretul = Convert.ToUInt32(pret);
                            if (pretul == 0)
                            {
                                MessageBox.Show("Pretul nu poate fi 0 !!!");
                                dateCorecte = false;
                            }

                        }
                        else
                        {

                            MessageBox.Show("Pretul trebuie sa fie in cifre!");
                            dateCorecte = false;
                        }
                        if (dateCorecte)
                        {


                            Carte ut = new Carte(cod, domeniu, editura, autor, titlu, disponibilitate, pretul);
                            bool succes = this.cartePersistenta.AdaugareCarte(ut);
                            if (!succes)
                                MessageBox.Show("Eroare la adaugare!");
                            else
                            {
                                this.refreshLista();
                            }
                        }

                    }
                }

            }

            private void actualizare(object sender, EventArgs e)
            {
                if (this.angajatV.AccesGridCarteView().SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nu exista nici o carte selectat pentru a fi actualizat!");
                }
                else
                {
                    bool dateCorecte = true;
                string cod_car = this.angajatV.AccesTxtCodCar().Text;
                string domeniu = this.angajatV.AccesTxtDomeniuCar().Text;
                string editura = this.angajatV.AccesTxtEdituraCar().Text;
                string autor = this.angajatV.AccesTxtAutorCar().Text;
                string titlu = this.angajatV.AccesTxtTitluCar().Text;
                string disponibilitate = this.angajatV.AccesCmbtDisponibilitateCar().Text;
                string pret = this.angajatV.AccesTxtPretCar().Text;
                uint cod_car_selectat = Convert.ToUInt32(this.angajatV.AccesGridCarteView().SelectedRows[0].Cells[0].Value);

                uint cod_car_nou;

                    bool conversie = uint.TryParse(cod_car, out cod_car_nou);
                    if (conversie)
                    {
                    cod_car_nou = Convert.ToUInt32(cod_car);
                        if (cod_car_nou == 0)
                        {
                            dateCorecte = false;
                            MessageBox.Show("COD-ul nu poate fi 0!");
                        }
                    }

                    if ((!Regex.IsMatch(cod_car, @"^\d+$")) && cod_car != "")
                    {
                        MessageBox.Show("COD-ul trebuie sa fie compus din cifre!!!");
                        dateCorecte = false;
                    }

                    if (this.cartePersistenta.CautareCarte(cod_car_nou) != null)
                    {
                        MessageBox.Show("Exista o alta carte cu acest COD!");
                        dateCorecte = false;
                    }
                    else
                    {
                     
                        uint pretul;
                        bool conversie2 = uint.TryParse(pret, out pretul);
                        if (conversie2)
                        {
                            pretul = Convert.ToUInt32(pret);
                            if (pretul == 0)
                            {
                                dateCorecte = false;
                                MessageBox.Show("Pretul nu poate fi 0!");
                            }
                        }
                        if ((!Regex.IsMatch(pret, @"^\d+$")) && pret != "")
                        {
                            MessageBox.Show("Pretul trebuie sa fie compus din cifre!!!");
                            dateCorecte = false;
                        }

                        if (dateCorecte)
                        {
                            Carte car = new Carte(cod_car_nou, domeniu, editura, autor, titlu, disponibilitate, pretul);
                            bool succes = this.cartePersistenta.ActualizareCarte(cod_car_selectat, car);
                            if (!succes)
                                MessageBox.Show("Eroare la actualizare!");
                            else
                                this.refreshLista();
                        }
                    }

                }
            }

            private void stergere(object sender, EventArgs e)
            {
                if (this.angajatV.AccesGridCarteView().SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nu exista nici o carte selectat pentru a fi sters!");
                }
                else
                {
                    uint cod_carte = Convert.ToUInt32(this.angajatV.AccesGridCarteView().SelectedRows[0].Cells[0].Value);
                    if (this.cartePersistenta.StergereCarte(cod_carte))
                    {
                        this.refreshLista();

                    }
                    else
                        MessageBox.Show("Nu s-a realizat stergerea in fisier!");
                }
            }

            private void vizualizare(object sender, EventArgs e)
            {
                List<Carte> lista = this.cartePersistenta.ListaCarti();

                if (lista != null)
                {
                    this.angajatV.AccesGridCarteView().Rows.Clear();
                    foreach (Carte c in lista)
                    {
                        DataGridViewRow rand = new DataGridViewRow();
                        rand.CreateCells(this.angajatV.AccesGridCarteView());
                        rand.Cells[0].Value = c.AccesCodCarte();
                        rand.Cells[1].Value = c.AccesDomeniu();
                        rand.Cells[2].Value = c.AccesEditura();
                        rand.Cells[3].Value = c.AccesAutor();
                        rand.Cells[4].Value = c.AccesTitlu();
                        rand.Cells[5].Value = c.AccesDisponibilitate();
                        rand.Cells[6].Value = c.AccesPret();
                        this.angajatV.AccesGridCarteView().Rows.Add(rand);
                    }
                }
                else
                    MessageBox.Show("Lista medicamentelor este vida!");
            }

            private void refreshLista()
            {
                List<Carte> lista = this.cartePersistenta.ListaCarti();

                if (lista != null)
                {
                    this.angajatV.AccesGridCarteView().Rows.Clear();
                    foreach (Carte c in lista)
                    {
                        DataGridViewRow rand = new DataGridViewRow();
                        rand.CreateCells(this.angajatV.AccesGridCarteView());
                        rand.Cells[0].Value = c.AccesCodCarte();
                        rand.Cells[1].Value = c.AccesDomeniu();
                        rand.Cells[2].Value = c.AccesEditura();
                        rand.Cells[3].Value = c.AccesAutor();
                        rand.Cells[4].Value = c.AccesTitlu();
                        rand.Cells[5].Value = c.AccesDisponibilitate();
                        rand.Cells[6].Value = c.AccesPret();
                        this.angajatV.AccesGridCarteView().Rows.Add(rand);
                }
                }
                else
                    MessageBox.Show("Lista cartilor este vida!");
            }

            private void cauta(object sender, EventArgs e)
            {

                List<Carte> lista = this.cartePersistenta.ListaCarti();
                string txtCautare = this.angajatV.AccesTxtCautareCarTitlu().Text;

                if (txtCautare.Equals(""))
                {
                    MessageBox.Show("Nu ati introdus titlul!");

                }
                else
                {
                    lista = this.cartePersistenta.CautareCarTitlu(txtCautare);

                    if (lista != null)
                    {
                        List<DataGridViewRow> randuri = new List<DataGridViewRow>();
                        this.angajatV.AccesGridCarteView().Rows.Clear();
                        foreach (Carte carte in lista)
                        {
                        DataGridViewRow rand = new DataGridViewRow();
                        rand.CreateCells(this.angajatV.AccesGridCarteView());
                        rand.Cells[0].Value = carte.AccesCodCarte();
                        rand.Cells[1].Value = carte.AccesDomeniu();
                        rand.Cells[2].Value = carte.AccesEditura();
                        rand.Cells[3].Value = carte.AccesAutor();
                        rand.Cells[4].Value = carte.AccesTitlu();
                        rand.Cells[5].Value = carte.AccesDisponibilitate();
                        rand.Cells[6].Value = carte.AccesPret();
                        this.angajatV.AccesGridCarteView().Rows.Add(rand);
                    }
                    }
                    else
                        MessageBox.Show("Lista cartilor este vida!");
                }
            }

            private void filtreaza(object sender, EventArgs e)
            {
                List<Carte> lista = new List<Carte>();
                string filtruSelectat = this.angajatV.AccesCmbCriteriuFiltrareCar().Text;
                string textFiltru = this.angajatV.AccesTxtFiltrareCar().Text;

                if (filtruSelectat == "" || textFiltru == "")
                {
                    MessageBox.Show("Nu s-au introdus toate datele pt. filtrare");
                }
                else
                {

                    lista = this.cartePersistenta.FiltrareCarti(filtruSelectat, textFiltru);

                    if (lista != null)
                    {
                        this.angajatV.AccesGridCarteView().Rows.Clear();
                        foreach (Carte carte in lista)
                        {
                            DataGridViewRow rand = new DataGridViewRow();
                            rand.CreateCells(this.angajatV.AccesGridCarteView());
                            rand.Cells[0].Value = carte.AccesCodCarte();
                            rand.Cells[1].Value = carte.AccesDomeniu();
                            rand.Cells[2].Value = carte.AccesEditura();
                            rand.Cells[3].Value = carte.AccesAutor();
                            rand.Cells[4].Value = carte.AccesTitlu();
                            rand.Cells[5].Value = carte.AccesDisponibilitate();
                            rand.Cells[6].Value = carte.AccesPret();
                            this.angajatV.AccesGridCarteView().Rows.Add(rand);
                    }

                    }
                    SalvareJSON salvare_j = new SalvareJSON();
                    salvare_j.SalvareCartiFiltrate(lista);
                    SalvareCSV salvare_Csv = new SalvareCSV();
                    salvare_Csv.SalvareCartiFiltrate(lista);

                }
            }

            private void sorteaza(object sender, EventArgs e)
            {

                List<Carte> lista = this.cartePersistenta.ListaCarti();
                List<Carte> lista_sortata = null;
                string sortare_aleasa = this.angajatV.AccesCmbSortare().Text;

                if (sortare_aleasa == "")
                {
                    MessageBox.Show("Nu s-a ales tipul de sortare!!");
                }

                if (sortare_aleasa == "Sortare_domeniu_crescator")
                {
                    lista_sortata = lista.OrderBy(o => o.AccesDomeniu()).ToList();
                }

                if (sortare_aleasa == "Sortare_domeniu_descrescator")
                {
                    lista_sortata = lista.OrderByDescending(o => o.AccesDomeniu()).ToList();
                }

                if (sortare_aleasa == "Sortare_autor_crescator")
                {
                    lista_sortata = lista.OrderBy(o => o.AccesAutor()).ToList();
                }

                if (sortare_aleasa == "Sortare_autor_descrescator")
                {
                    lista_sortata = lista.OrderByDescending(o => o.AccesAutor()).ToList();
                }
                if (sortare_aleasa == "Sortare_titlu_crescator")
                {
                    lista_sortata = lista.OrderBy(o => o.AccesTitlu()).ToList();
                }

                if (sortare_aleasa == "Sortare_titlu_descrescator")
                {
                    lista_sortata = lista.OrderByDescending(o => o.AccesTitlu()).ToList();
                }
            this.angajatV.AccesGridCarteView().Rows.Clear();
                foreach (Carte carte in lista_sortata)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.CreateCells(this.angajatV.AccesGridCarteView());
                    rand.Cells[0].Value = carte.AccesCodCarte();
                    rand.Cells[1].Value = carte.AccesDomeniu();
                    rand.Cells[2].Value = carte.AccesEditura();
                    rand.Cells[3].Value = carte.AccesAutor();
                    rand.Cells[4].Value = carte.AccesTitlu();
                    rand.Cells[5].Value = carte.AccesDisponibilitate();
                    rand.Cells[6].Value = carte.AccesPret();
                    this.angajatV.AccesGridCarteView().Rows.Add(rand);
            }

            }

            private void deconectare(object sender, EventArgs e)
            {
                this.angajatV.Hide();
                CAutentificare autentificareC = new CAutentificare();
                autentificareC.AccesAutentificareView().Show();
            }
        }
}
