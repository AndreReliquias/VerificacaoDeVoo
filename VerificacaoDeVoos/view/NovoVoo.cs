using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VerificacaoDeVoos.control;


namespace VerificacaoDeVoos
{
    public partial class NovoVoo : Form
    {
        public NovoVoo()
        {
            InitializeComponent();
            carregarDados();
        }

        public void carregarDados()
        {
            Mostrar mostrar = new Mostrar();
            this.cbAviao.ValueMember = "id";
            this.cbAviao.DisplayMember = "nome";
            this.cbAviao.DataSource = mostrar.show("Aviao");

            this.cbCidadeOrigem.ValueMember = "id";
            this.cbCidadeOrigem.DisplayMember = "nome";
            this.cbCidadeOrigem.DataSource = mostrar.show("Cidade");

            this.cbCidadeDestino.ValueMember = "id";
            this.cbCidadeDestino.DisplayMember = "nome";
            this.cbCidadeDestino.DataSource = mostrar.show("Cidade");
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (numDuracao.Value == 0 || this.cbAviao.SelectedIndex == 0 || this.cbCidadeDestino.SelectedIndex == 0 || this.cbCidadeOrigem.SelectedIndex == 0)
            {
                MessageBox.Show("Insira as Informações!", "Campo incompleto!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numDuracao.Focus();
            }
            else
            {
                Verificacao verifica = new Verificacao();
                dtpData.CustomFormat = ("yyyy/MM/dd");
                string data = dtpData.Text;
                dtpData.CustomFormat = "dd/MM/yyyy";
                verifica.ver(Convert.ToInt32(this.cbAviao.SelectedValue),
                                  Convert.ToInt32(this.cbCidadeOrigem.SelectedValue),
                                  Convert.ToInt32(this.cbCidadeDestino.SelectedValue),
                                  data,
                                  dtpHora.Text,
                                  Convert.ToInt32(numDuracao.Value));
                carregarDados();
            }
        }

        private void lnkNovoAviao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NovoAviao nAviao = new NovoAviao();
            nAviao.ShowDialog();
            carregarDados();
        }

        private void lnkNovaCidade_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NovaCidade nCidade = new NovaCidade();
            nCidade.ShowDialog();
            carregarDados();
        }
    }
}
