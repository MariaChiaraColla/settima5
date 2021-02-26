using System;
using System.Collections.Generic;
using System.Text;

namespace Universita.Classi
{
    public class Immatricolazione
    {
        //statiche: matricola univoca e autogenerata
        public int MatricolaSeed = 100000;

        //proprietà
        public int Matricola { get; }
        public DateTime DataInizio { get; set; }
        public CorsoDiLaurea CorsoLaurea { get; set; }
        public bool FuoriCorso { get; set; }
        public int CFUAccumulati { get; set; }

        //costruttori
        public Immatricolazione()
        {
            Matricola = MatricolaSeed;
            MatricolaSeed++;
            DataInizio = DateTime.Now;
            CorsoLaurea = new CorsoDiLaurea();
            FuoriCorso = false;
            CFUAccumulati = 0;
        }
        public Immatricolazione(CorsoDiLaurea corso, bool fuoriCorso, int cfu)
        {
            Matricola = MatricolaSeed;
            MatricolaSeed++;
            DataInizio = DateTime.Now;
            CorsoLaurea = corso;
            FuoriCorso = fuoriCorso;
            CFUAccumulati = cfu;
        }
    }
}
