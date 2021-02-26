using System;
using System.Collections.Generic;
using System.Text;

namespace Universita.Classi
{
    public class Esame
    {
        //proprietà
        public Corso CorsoAssociato { get; set; }
        public bool Passato { get; set; }

        //costruttore
        public Esame()
        {
            CorsoAssociato = new Corso();
            Passato = false;
        }
        public Esame(Corso corso)
        {
            CorsoAssociato = corso;
            Passato = false;
        }

    }
}
