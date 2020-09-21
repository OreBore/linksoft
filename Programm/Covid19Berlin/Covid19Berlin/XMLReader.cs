using Covid19Berlin.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace Covid19Berlin
{
    class XMLReader
    {
        public List<Item> XmlRead()
        {
            List<Item> itemListe = new List<Item>();

            XmlDocument xmlDatei = new XmlDocument();
            xmlDatei.Load("../../ressources/statistikdaten.xml");

            foreach (XmlNode nodeItem in xmlDatei.SelectNodes("//item"))
            {
                Item item = new Item(
                    Convert.ToInt32(nodeItem["id"].InnerText), 
                    nodeItem["bezirk"].InnerText, 
                    Convert.ToDouble(nodeItem["fallzahl"].InnerText),
                    Convert.ToDouble(nodeItem["differenz"].InnerText),
                    Convert.ToDouble(nodeItem["inzidenz"].InnerText),
                    Convert.ToDouble(nodeItem["genesen"].InnerText)
                    );
                itemListe.Add(item);
            }

            return itemListe;
        }
    }
}
