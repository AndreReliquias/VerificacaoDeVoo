using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VerificacaoDeVoos.control
{
    class Conexao
    {
        public SqlConnection conn = new SqlConnection(@"Insira aqui a cadeia de conexão");
        
        public void conectar()
        {
            conn.Open();
        }

        public void desconectar()
        {
            conn.Close();
        }
    }
}
