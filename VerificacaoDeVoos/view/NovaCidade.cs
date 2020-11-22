using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerificacaoDeVoos.control;

namespace VerificacaoDeVoos
{
    public partial class NovaCidade : Form
    {
        public NovaCidade()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("Caixa de texto vazia!", "Campo incompleto!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
            }
            else
            {
                Inserir novo = new Inserir();
                novo.insert("INSERT INTO Cidade (nome) VALUES('" + txtNome.Text + "');");
                txtNome.Clear();
                txtNome.Focus();
            }
        }
    }
}
