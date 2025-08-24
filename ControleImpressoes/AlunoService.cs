using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleImpressoes
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Saldo { get; set; }
    }
    public class AlunoService
    {
        public static List<Aluno> ObterSaldos()
        {
            List<Aluno> lista = new List<Aluno>();
            Conexao conexao = new Conexao();

            try
            {
                conexao.Conectar();
                string sql = "SELECT nome, saldo FROM Alunos";
                SqlCommand cmd = new SqlCommand(sql, conexao.conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Aluno
                    {
                        Nome = reader["nome"].ToString(),
                        Saldo = Convert.ToInt32(reader["saldo"])
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar saldos: " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }

            return lista;
        }
    }
}
