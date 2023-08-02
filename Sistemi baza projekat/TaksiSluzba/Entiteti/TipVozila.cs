using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiSluzba.Entiteti
{
    public class TipVozila
    {
       
        public virtual string Karoserija { get; set; }
        public virtual string Kapacitet { get; set; }
        public virtual string ModelVozila { get; set; }
        public virtual string Marka { get; set; }
        public virtual string RegistarskaOznakaVozila { get; set; }
        public TipVozila()
        {
            
        }
    }
}