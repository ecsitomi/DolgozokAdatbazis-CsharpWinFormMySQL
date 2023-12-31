using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginForm
{
    internal class Dolgozo
    {
        public ulong id;
        public string nev;
        public DateTime szuletes;
        public string nem;

        public Dolgozo(ulong id, string nev, DateTime szuletes, string nem)
        {
            this.id = id;
            this.nev = nev;
            this.szuletes = szuletes;
            this.nem = nem;
        }
        
        public string dolgozoKiirasa
        {
            get { return $"{id}. {nev}"; }
        }
    }
}
