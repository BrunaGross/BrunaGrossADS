using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    class Fone
    {
        private string numero;
        private string tipo;

        public Fone(string numero, string tipo)
        {
            this.numero = numero;
            this.tipo = tipo;
        }

        public Fone(): this("","")
        { }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
