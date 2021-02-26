using System;
using System.Collections.Generic;
using System.Text;

namespace Universita.Classi
{
    public class CorsoDiLaurea
    {
        //proprietà
        public string Nome { get; set; }
        public int AnniDiCorso { get; set; }
        public int CFUPerLaurea { get; set; }
        public List<Corso> Corsi { get; set; }

        //costruttori
        public CorsoDiLaurea()
        {
            Nome = "Anonimo";
            AnniDiCorso = 0;
            CFUPerLaurea = 0;
            Corsi = new List<Corso>();
        }
        public CorsoDiLaurea(string nome, int anni, int cfu)
        {
            Nome = nome;
            AnniDiCorso = anni;
            CFUPerLaurea = cfu;
            Corsi = new List<Corso>();
        }


        //metodi
        public List<CorsoDiLaurea> CreazioneCorsiLaurea()
        {
            List<CorsoDiLaurea> TuttiICorsiLaurea = new List<CorsoDiLaurea>();
            //creazione di tutti i corsi di laurea
            CorsoDiLaurea LaureaInMatematica = new CorsoDiLaurea("Laurea magistrale in Matematica", 5, 28);
            TuttiICorsiLaurea.Add(LaureaInMatematica);
            CorsoDiLaurea LaureaInInformatica = new CorsoDiLaurea("Laurea triennale in Informatica", 3, 16);
            TuttiICorsiLaurea.Add(LaureaInInformatica);
            CorsoDiLaurea LaureaInFisica = new CorsoDiLaurea("Laurea triennale in Fisica", 3, 10);
            TuttiICorsiLaurea.Add(LaureaInFisica);
            CorsoDiLaurea LaureaInIngegneria = new CorsoDiLaurea("Laurea magistrale in Ingegneria", 5, 10);
            TuttiICorsiLaurea.Add(LaureaInIngegneria);
            CorsoDiLaurea LaureaInLettere = new CorsoDiLaurea("Laurea triennale in Lettere", 3, 9);
            TuttiICorsiLaurea.Add(LaureaInLettere);

            return TuttiICorsiLaurea;
        }
    }
}
