using AgendaLegal.Dao;
using AgendaLegal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLegalConsole
{
    public class Program
    {
        public ContatoDao contatoDao;

        public Program()
        {
            contatoDao = new ContatoDao();
        }

        public void Adicionar()
        {
            Contato c = new Contato();
            Console.Clear();
            Console.WriteLine("*** Adicionar ***");
            Console.Write("Nome: ");
            c.Nome = Console.ReadLine();
            Console.Write("Telefone: ");
            c.Telefone = Console.ReadLine();
            Console.Write("Email: ");
            c.Email = Console.ReadLine();
            contatoDao.Adicionar(c);
        }

        public void Listar()
        {
            Console.Clear();
            Console.WriteLine("*** Contatos ****");
            Console.WriteLine("Nome\tTelefone\tEmail");
            foreach(Contato c in contatoDao.FindAll())
            {
                Console.WriteLine($"{c.Nome}\t{c.Telefone}\t{c.Email}");
            }
            Console.WriteLine("Pressione uma tecla para retornar ao menu");
            Console.ReadKey();
        }

        public void menu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("*** Menu ****");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("Entre com a opção desejada: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0: this.Sair(); break;
                    case 1: this.Adicionar(); break;
                    case 2: this.Listar();  break;
                    default: this.Padrao();  break;
                }
            } while (op != 0);
        }

        private void Padrao()
        {
            Console.Clear();
            Console.WriteLine("Opção inválida!!!");
            Console.WriteLine("Pressione uma tecla para retornar ao menu");
            Console.ReadKey();
        }

        private void Sair()
        {
            Console.WriteLine("Bye");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.menu();            
        }
    }
}
