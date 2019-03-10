using AgendaLegal.Dao;
using AgendaLegal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaLegalWinForms
{
    public partial class Agenda : Form
    {
        public ContatoDao contatoDao;
        public Agenda()
        {
            InitializeComponent();
            contatoDao = new ContatoDao();
            contatosDgv.AutoSize = true;
            contatosDgv.Columns.Add("nome", "Nome");
            contatosDgv.Columns.Add("telefone", "Telefone");
            contatosDgv.Columns.Add("email", "Email");
            
        }

        public void Limpar()
        {
            nomeTbx.Text = "";
            telefoneTbx.Text = "";
            emailTbx.Text = "";
            //contatosDgv.DataSource = null;
            //contatosDgv.DataSource = contatoDao.Contatos;                        
            contatosDgv.Rows.Clear();
            contatosDgv.Refresh();
            foreach (Contato c in contatoDao.FindAll())
            {
                int index = contatosDgv.Rows.Add();
                DataGridViewRow linha = contatosDgv.Rows[index];
                linha.Cells["nome"].Value = c.Nome;
                linha.Cells["telefone"].Value = c.Telefone;
                linha.Cells["email"].Value = c.Email;
            }
            
        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Nome = nomeTbx.Text;
            c.Telefone = telefoneTbx.Text;
            c.Email = emailTbx.Text;
            contatoDao.Adicionar(c);
            this.Limpar();
            MessageBox.Show("Contato adicionado com sucesso");
            
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            this.Limpar();
        }
    }
}
