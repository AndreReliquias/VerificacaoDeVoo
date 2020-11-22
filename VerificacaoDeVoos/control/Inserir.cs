using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VerificacaoDeVoos.control
{
    public class Inserir
    {
        public void insert(String sql)
        {
            Conexao cnn = new Conexao();
            try
            {
                cnn.conectar();
                SqlCommand comando = new SqlCommand(sql, cnn.conn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro efetuado com sucesso!","Salvo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "Erro ao salvar no banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                throw;
            }
            cnn.desconectar();
        }
    }
}
