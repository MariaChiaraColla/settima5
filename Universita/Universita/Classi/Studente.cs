using System;
using System.Collections.Generic;
using System.Text;

namespace Universita.Classi
{
    public class Studente
    {
        //proprietà
        public string Nome { get; set; }
        public string Cognome {get; set; }
        public int AnnoDiNascita { get; set; }
        public Immatricolazione ImmatricolazioneStudente { get; set; }
        public List<Esame> Esami { get; set; }
        public bool RichiestaLaurea { get; set; }

        //costruttore
        public Studente(string nome, string cognome, int nascita)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = nascita;
            ImmatricolazioneStudente = new Immatricolazione();
            Esami = new List<Esame>();
            RichiestaLaurea = false;
        }

        //metodi
        public void RichiestaEsame(Esame esameRichiesto)
        {
            bool presente = false;

            for(int i = 0; i < Esami.Count; i++)
            {
                if (Esami[i] == esameRichiesto)
                    presente = true;
            }

            if (presente == false)
            {
                Console.WriteLine("Esame non è presente nel Corso di Laurea associato a questo studente");
            }               
            //cfu totali + cfu del nuovo esame < cfu del corso di laurea
            else if((ImmatricolazioneStudente.CFUAccumulati + esameRichiesto.CorsoAssociato.CFU) > ImmatricolazioneStudente.CorsoLaurea.CFUPerLaurea)
            {
                Console.WriteLine("Il totale dei CFU accumulati con i CFU di questo esame supera quelli del Corso Di Laurea");
            }
            //
            else if(RichiestaLaurea == true)
            {
                Console.WriteLine("Non è possibile iscriversi ad un esame se è stata fatta la Richiesta di Laurea");
            }
            else
            {
                Esami.Add(esameRichiesto);
            }

        }

        public void EsamePassato(Esame esamePassato)
        {
            for(int i = 0; i<Esami.Count; i++)
            {
                if(Esami[i] == esamePassato)
                {
                    esamePassato.Passato = true;
                }
            }
            ImmatricolazioneStudente.CFUAccumulati = ImmatricolazioneStudente.CFUAccumulati + esamePassato.CorsoAssociato.CFU;
            esamePassato.Passato = true;

            if(ImmatricolazioneStudente.CFUAccumulati == ImmatricolazioneStudente.CorsoLaurea.CFUPerLaurea)
            {
                Console.WriteLine("Congratulazioni hai raggiunto i CFU necessari per la Laurea!");
                RichiestaLaurea = true;
            }
        }
    }
}
