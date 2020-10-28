using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Berlin.model
{
    class Item
    {
        private readonly int id;
        private readonly string bezirk;
        private readonly double fallzahl;
        private readonly double differenz;
        private readonly double inzidenz;
        private readonly double genesen;

        public Item(int id, string bezirk, double fallzahl, double differenz, double inzidenz, double genesen)
        {
            this.id = id;
            this.bezirk = bezirk;
            this.fallzahl = fallzahl;
            this.differenz = differenz;
            this.inzidenz = inzidenz;
            this.genesen = genesen;
        }

        public int Id
        {
            get { return id; }
           // set { id = value; }
        }

        public string Bezirk
        {
            get { return bezirk; }
           // set { bezirk = value; }
        }

        public double Fallzahl
        {
            get { return fallzahl; }
           // set { fallzahl = value; }
        }

        public double Differenz
        {
            get { return differenz; }
           // set { differenz = value; }
        }

        public double Inzidenz
        {
            get { return inzidenz; }
           // set { inzidenz = value; }
        }

        public double Genesen
        {
            get { return genesen; }
          //  set { genesen = value; }
        }


    }
}
