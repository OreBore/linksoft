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
        private readonly string region;
        private readonly double fallzahlen;
        private readonly double differenz;
        private readonly double inzidenz;
        private readonly double genesen;

        public Item(int id, string region, double fallzahlen, double differenz, double inzidenz, double genesen)
        {
            this.id = id;
            this.region = region;
            this.fallzahlen = fallzahlen;
            this.differenz = differenz;
            this.inzidenz = inzidenz;
            this.genesen = genesen;
        }

        public int Id
        {
            get { return id; }
        }

        public string Region
        {
            get { return region; }
        }

        public double Fallzahlen
        {
            get { return fallzahlen; }
        }

        public double Differenz
        {
            get { return differenz; }
        }

        public double Inzidenz
        {
            get { return inzidenz; }
        }

        public double Genesen
        {
            get { return genesen; }
        }


    }
}
