using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_13_1
{
    class Studente : Persona
    {
        public string sezione { get; set; }

        public Studente(string nome, string cognome, string sezione, int anni) : base(nome, cognome, anni)
        {
            this.sezione = sezione;
        }

        public override string describe()
        {
            return base.describe() + System.Environment.NewLine
                            + "SEZIONE : " + sezione;
        }
    }
}
