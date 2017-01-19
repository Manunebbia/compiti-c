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
                if (value <= 0) value = 1;
                _anni = value;
            }
            get
            { return _anni; }
        }

        public string codFisc
        {
            get
            {
                return nome + cognome + anni.ToString();
            }
        }

        public Persona(string nome, string cognome, int anni)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.anni = anni;
        }

        public virtual string describe()
        {
            string output = "NOME : " + nome + System.Environment.NewLine
                  + "COGNOME : " + cognome + System.Environment.NewLine
                  + "ANNI : " + anni;
            return output;
        }
    }
}
