using System;
using System.Collections.Generic;
using System.Text;

namespace Universita.Classi
{
    public class Corso
    {
        //statiche: nome corso solo: Matematica, Fisica, Informatica, Ingegneria, Lettere.
        public enum NomiCorso
        {
            Matematica,
            Fisica,
            Informatica,
            Ingegneria,
            Lettere
        }

        //proprietà
        public NomiCorso Nome{ get; set; }
        public int CFU { get; set; }

        //costruttori
        public Corso()
        {
            Nome = NomiCorso.Matematica;
            CFU = 0;
        }
        public Corso(NomiCorso nome, int cfu)
        {
            Nome = nome;
            CFU = cfu;
        }
        
        //metodi
        public List<Corso> CreaCorsi()
        {
            List<Corso> TuttiICorsi = new List<Corso>();
            //creazione dei corsi
            Corso Matematica = new Corso(Corso.NomiCorso.Matematica, 10);
            TuttiICorsi.Add(Matematica);
            Corso Informatica = new Corso(Corso.NomiCorso.Informatica, 12);
            TuttiICorsi.Add(Informatica);
            Corso Fisica = new Corso(Corso.NomiCorso.Fisica, 6);
            TuttiICorsi.Add(Fisica);
            Corso Ingegneria = new Corso(Corso.NomiCorso.Ingegneria, 12);
            TuttiICorsi.Add(Ingegneria);
            Corso Lettere = new Corso(Corso.NomiCorso.Lettere, 9);
            TuttiICorsi.Add(Lettere);

            return TuttiICorsi;
        }
    }

}
