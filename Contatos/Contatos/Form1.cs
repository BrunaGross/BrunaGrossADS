using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contatos
{
    public partial class frmContato : Form
    {
        //private Contatos osContatos;
        private Contato umContato = new Contato();
        private Contatos lstContatos = new Contatos();

        public frmContato()
        {
            InitializeComponent();
            //osContatos = new Contatos();
            BindingList<Fone> bl = new BindingList<Fone>(umContato.Fones);
            dataGridView1.DataSource = bl;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
           
            txtEmail.Text = "";
            txtNome.Text = "";
            txtNumero.Text = "";
            cmbTipo.Text = "";
            dataGridView1.Rows.Clear();

        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            
            umContato.adicionarFone(new Fone(txtNumero.Text, cmbTipo.Text));
            BindingList<Fone> bl = new BindingList<Fone>(umContato.Fones);
            dataGridView1.DataSource = bl;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
                int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    dataGridView1.Refresh(); // if needed
                }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            BindingList<Fone> bl = new BindingList<Fone>(umContato.Fones);                            
            dataGridView1.DataSource = bl;

            umContato.Email = txtEmail.Text;
            umContato.Nome = txtNome.Text;
            //umContato.adicionarFone(new Fone(txtNumero.Text, cmbTipo.Text));

            lstContatos.adicionar(umContato);
                       

            //Contato inclui = new Contato(txtEmail.Text, txtNome.Text, );
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            foreach(Contato pesquisa in lstContatos.MeusContatos)
            {
                if(txtEmail.Text == pesquisa.Email)
                {
                    txtNome.Text = pesquisa.Nome;
                    BindingList<Fone> bl = new BindingList<Fone>(pesquisa.Fones);
                    dataGridView1.DataSource = bl;
                    dataGridView1.Refresh();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            foreach (Contato pesquisa in lstContatos)
            {
                if (txtEmail.Text == pesquisa.Email)
                {
                    pesquisa.Nome = "";
                    pesquisa.Email = "";
                    pesquisa.Fones.Clear();
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtNumero.Clear();
                    cmbTipo.Text = "";
                }
            }
        }
    }
}
