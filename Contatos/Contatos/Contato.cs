using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    class Contato
    {
        #region Atributos
        private string email;
        private string nome;
        private List<Fone> fones;
        #endregion

        #region Propriedades
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public List<Fone> Fones
        {
            get { return fones; }

        }
        #endregion

        #region Construtores
        public Contato(string email, string nome, List<Fone> fones)
        {
            this.email = email;
            this.nome = nome;
            this.fones = fones;
        }

        public Contato(string email) : this(email, "", new List<Fone>())
        { }

        public Contato()
            : this("", "", new List<Fone>())
        { }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return string.Format("e-mail: {0}\nNome: {1}\nFone: {2}",
                this.email, this.nome, "");
        }

        public override bool Equals(object obj)
        {
            return (this.email == ((Contato)obj).email);
        }
        #endregion

        public void adicionarFone(Fone f)
        {
            this.fones.Add(f);
        }

        public void removerFone(Fone f)
        {
            this.fones.Remove(f);    
        }
    }
}
