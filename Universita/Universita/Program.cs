using System;
using System.Collections.Generic;
using Universita.Classi;

namespace Universita
{
    public class Program
    {
        static void Main(string[] args)
        {
            //creazione corsi
            Corso corso = new Corso();
            List<Corso> TuttiICorsi = corso.CreaCorsi();
            //mate, info, fisica, ing, lettere

            //creazione Corso di laurea
            CorsoDiLaurea corsoLaurea = new CorsoDiLaurea();
            List<CorsoDiLaurea> TuttiICorsiDiLaurea = corsoLaurea.CreazioneCorsiLaurea();
            //mate, info, fisica, ing, lettere

            //creazione studenti
            Studente studente1 = new Studente("Maria", "Bianchi", 1997);
            Studente studente2 = new Studente("Mario", "Verdi", 1998);
            Studente studente3 = new Studente("Marco", "Rossi", 1998);

            //immatricolazione
            studente1.ImmatricolazioneStudente = new Immatricolazione(TuttiICorsiDiLaurea[0], false, 0);
            studente2.ImmatricolazioneStudente = new Immatricolazione(TuttiICorsiDiLaurea[1], false, 0);
            studente3.ImmatricolazioneStudente = new Immatricolazione(TuttiICorsiDiLaurea[2], true, 9);

            //Esami
            Esame Analisi1 = new Esame(TuttiICorsi[0]);
            Esame Analisi2 = new Esame(TuttiICorsi[0]);
            Esame programmazione1 = new Esame(TuttiICorsi[1]);
            Esame programmazione2 = new Esame(TuttiICorsi[1]);
            Esame fisica1 = new Esame(TuttiICorsi[2]);
            Esame fisica2 = new Esame(TuttiICorsi[2]);
            Esame elettronica1 = new Esame(TuttiICorsi[3]);
            Esame elettronica2 = new Esame(TuttiICorsi[3]);
            Esame Italiano1 = new Esame(TuttiICorsi[4]);
            Esame Storia1 = new Esame(TuttiICorsi[4]);

            //nuovo esame
            studente1.Esami.Add(Analisi1);
            studente1.Esami.Add(Analisi2);
            studente2.Esami.Add(programmazione1);
            studente2.Esami.Add(programmazione2);
            studente3.Esami.Add(fisica1);

            studente1.RichiestaEsame(Analisi1); //esame nel suo corso, ok
            studente1.RichiestaEsame(Storia1); //esame non del suo corso, ko

            studente2.RichiestaEsame(programmazione1); //passato
            studente2.RichiestaEsame(programmazione2);  //passato

            studente3.RichiestaEsame(fisica1); //somma cfu > della laurea

            //esame passato
            studente2.EsamePassato(programmazione1);
            studente3.EsamePassato(programmazione2); //numero cf arrivato a quelli per la laurea
            studente1.EsamePassato(Analisi1);  //esame passato
            


        }
    }
}
