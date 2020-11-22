using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using VerificacaoDeVoos;

namespace VerificacaoDeVoos.control
{
    public partial class Mostrar
    {
        public object show(String tabela)
        {
            Conexao cnn = new Conexao();
            try
            {
                cnn.conectar();
                String sql = "SELECT * FROM " + tabela;
                SqlCommand comando = new SqlCommand(sql, cnn.conn);
                SqlDataReader reader = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                DataRow row = table.NewRow();

                row["nome"] = "Selecione";
                table.Rows.InsertAt(row, 0);
                cnn.desconectar();
                return table;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "Erro ao acessar o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnn.desconectar();
                Application.Exit();
                throw;
            }
        }
    }
}
