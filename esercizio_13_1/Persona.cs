using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_13_1
{
    class Persona
    {
        private string _nome;
        public string nome { get; set; }

        private string _cognome;
        public string cognome { get; set; }

        private int _anni;
        public int anni
        {
            set
            {
                if (anni <= 0) anni = 1;
            }
            get
            { return _anni; }
        }

        public string codFisc
        {
            get
            {
                return nome + cognome + anni;
            }
        }

        public Persona(string nome, string cognome, int anni)
        {
            _nome = nome;
            _cognome = cognome;
            _anni = anni;
        }

        public virtual string describe()
        {
            string output = "NOME : " + nome + "\r\n"
                  + "COGNOME : " + cognome + "\r\n"
                  + "ANNI : " + anni;
            return output;
        }
    }
}
