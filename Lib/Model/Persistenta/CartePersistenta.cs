using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lib.Model.Persistenta
{
    public class CartePersistenta
    {
        public bool AdaugareCarte(Carte cart)
        {
            try
            {
                XElement xElement = XElement.Load(@"carti.xml");
                xElement.Add(new XElement("carte",
                    new XElement("cod_carte", cart.AccesCodCarte().ToString()),
                    new XElement("domeniu", cart.AccesDomeniu().ToString()),
                    new XElement("editura", cart.AccesEditura()),
                    new XElement("autor", cart.AccesAutor()),
                    new XElement("titlu", cart.AccesTitlu()),
                    new XElement("disponibilitate", cart.AccesDisponibilitate()),
                    new XElement("pret", cart.AccesPret().ToString())
                    ));
                xElement.Save(@"carti.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adaugare carte! " + ex.ToString());
                return false;
            }
        }

        public bool StergereCarte(uint cod_carte)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"carti.xml");
                xDoc.Root.Elements("carte").Where(e => e.Element("cod_carte").Value == cod_carte.ToString()).Remove();
                xDoc.Save(@"carti.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la stergere carte! " + ex.ToString());
                return false;
            }
        }

        public bool ActualizareCarte(uint cod_carte, Carte cart)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"carti.xml");
                var element = xDoc.Root.Elements("carte").Where(e => e.Element("cod_carte").Value == cod_carte.ToString()).Single();
                element.Element("cod_carte").Value = cart.AccesCodCarte().ToString();
                if (cart.AccesDomeniu() != "") element.Element("domeniu").Value = cart.AccesDomeniu();
                if (cart.AccesEditura() != "") element.Element("editura").Value = cart.AccesEditura();
                if (cart.AccesAutor() != "") element.Element("autor").Value = cart.AccesAutor();
                if (cart.AccesTitlu() != "") element.Element("titlu").Value = cart.AccesTitlu();
                if (cart.AccesDisponibilitate() != "") element.Element("disponibilitate").Value = cart.AccesDisponibilitate();
                if (cart.AccesPret().ToString() != "0") element.Element("pret").Value = cart.AccesPret().ToString();
                xDoc.Save(@"carti.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la actualizare carte! " + ex.ToString());
                return false;
            }
        }

        public Carte CautareCarte(uint cod_carte)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"carti.xml");
                List<XElement> lista = xDoc.Root.Elements("carte").ToList();
                foreach (XElement xElem in lista)
                {
                    uint cdc = (uint)Convert.ToUInt32(xElem.Element("cod_carte").Value);
                    if (cdc == cod_carte)
                    {
                        string domeniu = xElem.Element("domeniu").Value;
                        string editura = xElem.Element("editura").Value;
                        string autor = xElem.Element("autor").Value;
                        string titlu = xElem.Element("titlu").Value;
                        string disponibilitate = xElem.Element("disponibilitate").Value;
                        uint pret = Convert.ToUInt32(xElem.Element("pret").Value);


                        Carte c = new Carte(cod_carte, domeniu, editura, autor, titlu, disponibilitate, pret);
                        return c;
                    }

                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la cautare carte! " + ex.ToString());
                return null;
            }
        }

        public List<Carte> ListaCarti()
        {
            try
            {
                List<Carte> listaCarti = new List<Carte>();
                XDocument xDoc = XDocument.Load(@"carti.xml");
                List<XElement> listaXML = xDoc.Root.Elements("carte").ToList();
                foreach (XElement xElem in listaXML)
                {
                   
                    string domeniu = xElem.Element("domeniu").Value;
                    uint cod_carte = Convert.ToUInt32(xElem.Element("cod_carte").Value);
                    string editura = xElem.Element("editura").Value;
                    string autor = xElem.Element("autor").Value;
                    string titlu = xElem.Element("titlu").Value;
                    string disponibilitate = xElem.Element("disponibilitate").Value;
                    uint pret = Convert.ToUInt32(xElem.Element("pret").Value);

                    Carte c = new Carte(cod_carte, domeniu, editura, autor, titlu, disponibilitate, pret);
                    listaCarti.Add(c);
                }
                return listaCarti;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citire carte! " + ex.ToString());
                return null;
            }
        }

   

        public List<Carte> FiltrareCarti(string filtruSelectat, string textFiltru)
        {
            try
            {
                List<Carte> listaCarti = new List<Carte>();
                XDocument xDoc = XDocument.Load(@"carti.xml");
                List<XElement> listaXML = xDoc.Root.Elements("carte").ToList();
                foreach (XElement xElem in listaXML)
                {
                    string filtru = xElem.Element(filtruSelectat).Value;
                    if (filtru == textFiltru)
                    {
                        uint cod_carte = Convert.ToUInt32(xElem.Element("cod_carte").Value);
                        string domeniu = xElem.Element("domeniu").Value;
                        string editura = xElem.Element("editura").Value;
                        string autor = xElem.Element("autor").Value;
                        string titlu = xElem.Element("titlu").Value; 
                        string disponibilitate = xElem.Element("disponibilitate").Value;
                        uint pret = Convert.ToUInt32(xElem.Element("pret").Value); 
                        Carte c = new Carte(cod_carte, domeniu, editura, autor, titlu, disponibilitate, pret);
                        listaCarti.Add(c);
                    }
                }
                return listaCarti;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la filtrare carti! " + ex.ToString());
                return null;
            }
        }

        public List<Carte> CautareCarTitlu(string txtCautare)
        {
            try
            {
                List<Carte> listaCarti = new List<Carte>();
                XDocument xDoc = XDocument.Load(@"carti.xml");
                List<XElement> listaXML = xDoc.Root.Elements("carte").ToList();
                foreach (XElement xElem in listaXML)
                {

                    string titl = xElem.Element("titlu").Value;
                    if (titl == txtCautare)
                    {
                        string titlu = xElem.Element("titlu").Value;
                        uint cod_carte = Convert.ToUInt32(xElem.Element("cod_carte").Value);
                        string domeniu = xElem.Element("domeniu").Value;
                        string editura = xElem.Element("editura").Value;
                        string autor = xElem.Element("autor").Value;
                        string disponibilitate = xElem.Element("disponibilitate").Value;
                        uint pret = Convert.ToUInt32(xElem.Element("pret").Value);

                        Carte c = new Carte(cod_carte, domeniu, disponibilitate, editura, titlu, autor, pret);
                        listaCarti.Add(c);
                    }
                }
                return listaCarti;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la filtrare parfumuri! " + ex.ToString());
                return null;
            }
        }

        
    }
}