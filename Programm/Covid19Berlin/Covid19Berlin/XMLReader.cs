using Covid19Berlin.control;
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
            xmlDatei.Load(Konstanten.DEFAULTXML);

            foreach (XmlNode nodeItem in xmlDatei.SelectNodes("//item"))
            {
                Item item = new Item(
                    Convert.ToInt32(nodeItem[Konstanten.ID].InnerText), 
                    nodeItem[Konstanten.BEZIRK].InnerText, 
                    Convert.ToDouble(nodeItem[Konstanten.FALLZAHL].InnerText),
                    Convert.ToDouble(nodeItem[Konstanten.DIFFERENZ].InnerText),
                    Convert.ToDouble(nodeItem[Konstanten.INZIDENZ].InnerText),
                    Convert.ToDouble(nodeItem[Konstanten.GENESEN].InnerText)
                    );
                itemListe.Add(item);
            }

            return itemListe;
        }
    }
}
