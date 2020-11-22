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
    public class Verificacao
    {
        public void ver(int idAviaoc, int idCidadeOrigemc, int idCidadeDestinoc, string data, string hora, int duracao)
        {
            bool status = false;

            MessageBox.Show("Aviao(id): " + idAviaoc + "\nOrigem(id): " + idCidadeOrigemc + "\nDestino(id): " + idCidadeDestinoc + "\nData: " + data + "\nHora: " + hora + "\nDuracao: " + duracao, "Informações que serão salvas",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Conexao cnn = new Conexao();
            try
            {
                cnn.conectar();
                //Seleciona todos os objetos da tabela Voo
                String sql = "SELECT * FROM Voo;";
                SqlCommand comando = new SqlCommand(sql, cnn.conn);
                SqlDataReader reader = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                Inserir novo = new Inserir();
                if (table.Rows.Count<1)
                {
                    //Tabela sem registro, pode salvar a primeira vez
                    novo.insert("INSERT INTO Voo(data, horario, duracao, idAviao, idCidadeOrigem, idCidadeDestino) VALUES('"+data+"','"+hora+"',"+duracao+","+idAviaoc+","+idCidadeOrigemc+","+idCidadeDestinoc+");");
                }
                else
                {
                    //Tabela Voo com registro, fazer as verificacoes dos registos existentes para o aviao: idAviao
                    sql = "SELECT * FROM Voo WHERE idAviao = "+idAviaoc+";";
                    comando = new SqlCommand(sql, cnn.conn);
                    reader = comando.ExecuteReader();
                    DataTable tabAviao = new DataTable();
                    tabAviao.Load(reader);
                    if (tabAviao.Rows.Count < 1)
                    {
                        //Primeiro registro para o aviao: idAviao
                        novo.insert("INSERT INTO Voo(data, horario, duracao, idAviao, idCidadeOrigem, idCidadeDestino) VALUES('" + data + "','" + hora + "'," + duracao + "," + idAviaoc + "," + idCidadeOrigemc + "," + idCidadeDestinoc + ");");
                    }
                    else
                    {
                        //Aviao ja possui algum registro salvo, verificar as condicoes
                        reader = comando.ExecuteReader();
                        if (reader.HasRows)
                        {   
                            while (reader.Read())
                            {
                                //Se Origem Novo Voo == Destino voo passado
                                if (idCidadeOrigemc.ToString() == reader["idCidadeDestino"].ToString())
                                {
                                    //Conversoes 
                                    DateTime antHorario = DateTime.ParseExact(reader["horario"].ToString(), "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                                    DateTime atHorario = Convert.ToDateTime(hora, System.Globalization.CultureInfo.InvariantCulture);
                                    DateTime antData = DateTime.ParseExact(reader["data"].ToString(), "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                                    DateTime atData = Convert.ToDateTime(data, System.Globalization.CultureInfo.InvariantCulture);
                                    
                                    double hCompleta = Convert.ToDouble(reader["duracao"]);
                                    //Compara o horario do Voo anterior somado com sua duracao, com o horario do proximo voo
                                    int resultHora = DateTime.Compare((antHorario.AddHours(hCompleta)), atHorario);
                                    //Compara as datas
                                    int resultData = DateTime.Compare(antData.Date, atData);

                                    //Se a data for igual e o horario do novo voo for posterior ao horario+duracao do voo anterior
                                    //ou, se a data do antigo voo for anterior a data atual, e a hora do novo voo for anterior, salva
                                    //ex: ultimo voo 03/11/2020	20H, voo atual: 04/11/2020	7H
                                    if (((resultData == 0 || resultData < 0) && resultHora < 0) || (resultData < 0 && resultHora > 0))
                                    {
                                        status = true;
                                    }
                                }
                                else
                                {
                                    status = false;
                                }
                            }
                        }
                        cnn.desconectar();
                        if (status)
                        {
                            novo.insert("INSERT INTO Voo(data, horario, duracao, idAviao, idCidadeOrigem, idCidadeDestino) VALUES('" + data + "','" + hora + "'," + duracao + "," + idAviaoc + "," + idCidadeOrigemc + "," + idCidadeDestinoc + ");");
                        }
                        else
                        {
                            MessageBox.Show("Voo Rejeitado!", "Voo invalido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                cnn.desconectar();
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
