using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

namespace Covid19Berlin
{
    class XMLReader
    {
        public void XmlTextRead()
        {
            XmlTextReader reader = new XmlTextReader("../../ressources/statistikdaten.xml");
           
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        Console.WriteLine("<" + reader.Name + ">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;

                }
            }
        }
    }
}
