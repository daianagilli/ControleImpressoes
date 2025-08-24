using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleImpressoes
{
    public class Historico
    {
        Conexao conexao = new Conexao(); 

        public List<HistoricoAluno> ConsultarPorNome(string nomeAluno)
        {
            List<HistoricoAluno> lista = new List<HistoricoAluno>();

            try
            {
                conexao.Conectar();

                // Busca o código do aluno pelo nome
                string sqlBusca = "SELECT codigo FROM Alunos WHERE nome = @nome";
                SqlCommand cmdBusca = new SqlCommand(sqlBusca, conexao.conn);
                cmdBusca.Parameters.AddWithValue("@nome", nomeAluno);

                object resultado = cmdBusca.ExecuteScalar();

                if (resultado == null)
                    return lista;

                int codigoAluno = Convert.ToInt32(resultado);

                // Consulta o histórico
                string sqlHistorico = @"
                SELECT dataHistorico, movimentacao, saldoAntesMovimentacao, saldoDepoisMovimentacao 
                FROM Historicos
                WHERE codigoAluno = @codigoAluno
                ORDER BY dataHistorico";

                SqlCommand cmdHist = new SqlCommand(sqlHistorico, conexao.conn);
                cmdHist.Parameters.AddWithValue("@codigoAluno", codigoAluno);

                SqlDataReader reader = cmdHist.ExecuteReader();

                while (reader.Read())
                {
                    DateTime data = reader.GetDateTime(0);
                    bool mov = reader.GetBoolean(1);
                    string tipo = mov ? "compra" : "impressão";
                    int saldoAntes = reader.GetInt32(2);
                    int saldoDepois = reader.GetInt32(3);

                    lista.Add(new HistoricoAluno
                    {
                        Data = data,
                        TipoMovimentacao = tipo,
                        SaldoAntes = saldoAntes,
                        SaldoDepois = saldoDepois
                    });
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar histórico: " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }

            return lista;
        }
    }
}
