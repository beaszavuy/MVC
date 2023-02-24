using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lib.Model.Persistenta
{
    public class UtilizatorPersistenta
    {
        public bool AdaugareUtilizator(Utilizator ut)
        {
            try
            {
                XElement xElement = XElement.Load(@"utilizatori.xml");
                xElement.Add(new XElement("utilizator",
                    new XElement("legitimatie", ut.AccesLegitimatie().ToString()),
                    new XElement("nume", ut.AccesNume()),
                    new XElement("cont", ut.AccesCont()),
                    new XElement("parola", ut.AccesParola()),
                    new XElement("rol", ut.AccesRol())
                    ));
                xElement.Save(@"utilizatori.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adaugare utilizator! " + ex.ToString());
                return false;
            }
        }

        public bool ActualizareUtilizator(uint nrLegitimatie, Utilizator ut)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"utilizatori.xml");
                var element = xDoc.Root.Elements("utilizator").Where(e => e.Element("legitimatie").Value == nrLegitimatie.ToString()).Single();
                if (ut.AccesLegitimatie() != 0) element.Element("legitimatie").Value = ut.AccesLegitimatie().ToString();
                if (ut.AccesNume() != "") element.Element("nume").Value = ut.AccesNume();
                if (ut.AccesCont() != "") element.Element("cont").Value = ut.AccesCont();
                if (ut.AccesParola() != "") element.Element("parola").Value = ut.AccesParola();
                if (ut.AccesRol() != "") element.Element("rol").Value = ut.AccesRol();
                xDoc.Save(@"utilizatori.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la actualizare utilizator! " + ex.ToString());
                return false;
            }
        }

        public bool StergereUtilizator(uint nrLegitimatie)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"utilizatori.xml");
                xDoc.Root.Elements("utilizator").Where(e => e.Element("legitimatie").Value == nrLegitimatie.ToString()).Remove();
                xDoc.Save(@"utilizatori.xml");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la stergere utilizator! " + ex.ToString());
                return false;
            }
        }

        public Utilizator CautareUtilizator(string nume, string parola)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"utilizatori.xml");
                List<XElement> lista = xDoc.Root.Elements("utilizator").ToList();
                foreach (XElement xElem in lista)
                {
                    string userXML = xElem.Element("cont").Value;
                    string parolaXML = xElem.Element("parola").Value;

                    if (userXML == nume && parolaXML == parola)
                    {

                        uint legitimatieXML = Convert.ToUInt32(xElem.Element("legitimatie").Value);
                        string rolXML = xElem.Element("rol").Value;
                        string numeXML = xElem.Element("nume").Value;
                        Utilizator utilizator = new Utilizator(legitimatieXML, numeXML, userXML, parolaXML, rolXML);

                        return utilizator;

                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la cautare utilizator! " + ex.ToString());
                return null;
            }
        }
        public Utilizator CautareUtilizator(uint legitimatie)
        {
            try
            {
                XDocument xDoc = XDocument.Load(@"utilizatori.xml");
                List<XElement> lista = xDoc.Root.Elements("utilizator").ToList();
                foreach (XElement xElem in lista)
                {
                    uint nrLeg = Convert.ToUInt32(xElem.Element("legitimatie").Value);
                    if (nrLeg == legitimatie)
                    {
                        string nume = xElem.Element("nume").Value;
                        string cont = xElem.Element("cont").Value;
                        string parola = xElem.Element("parola").Value;
                        string rol = xElem.Element("rol").Value;
                        Utilizator ut = new Utilizator(legitimatie, nume, cont, parola, rol);
                        return ut;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la cautare utilizator! " + ex.ToString());
                return null;
            }
        }

        public List<Utilizator> ListaUtilizatori()
        {
            try
            {
                List<Utilizator> listaUtilizatori = new List<Utilizator>();
                XDocument xDoc = XDocument.Load(@"utilizatori.xml");
                List<XElement> listaXML = xDoc.Root.Elements("utilizator").ToList();
                foreach (XElement xElem in listaXML)
                {
                    string nume = xElem.Element("nume").Value;
                    uint nrLeg = Convert.ToUInt32(xElem.Element("legitimatie").Value);
                    string cont = xElem.Element("cont").Value;
                    string parola = xElem.Element("parola").Value;
                    string rol = xElem.Element("rol").Value;
                    Utilizator ut = new Utilizator(nrLeg, nume, cont, parola, rol);
                    listaUtilizatori.Add(ut);
                }
                return listaUtilizatori;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citire utilizatori! " + ex.ToString());
                return null;
            }
        }


    }
}
