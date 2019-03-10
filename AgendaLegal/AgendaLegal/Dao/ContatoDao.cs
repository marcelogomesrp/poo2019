using AgendaLegal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLegal.Dao
{
    public class ContatoDao
    {
        public List<Contato> Contatos;

        public ContatoDao()
        {
            Contatos = new List<Contato>();
        }

        public void Adicionar(Contato contato)
        {
            Contatos.Add(contato);
        }

        public List<Contato> FindAll()
        {
            return Contatos;
        }

    }
}
