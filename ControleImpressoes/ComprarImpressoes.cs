using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleImpressoes
{
    public partial class ComprarImpressoes : Form
    {
        public ComprarImpressoes()
        {
            InitializeComponent();
        }

        private void NomeAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EnviarCompra_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            string nomeInput = NomeAluno.Text.Trim();

            if (string.IsNullOrEmpty(nomeInput))
            {
                MessageBox.Show("Digite o nome do aluno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conexao.Conectar();

                string sqlAluno = "SELECT codigo, saldo FROM Alunos WHERE nome = @nome";
                SqlCommand cmdAluno = new SqlCommand(sqlAluno, conexao.conn);
                cmdAluno.Parameters.AddWithValue("@nome", nomeInput);

                SqlDataReader reader = cmdAluno.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Aluno não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int codigoAluno = reader.GetInt32(0);
                int saldoAtual = reader.GetInt32(1);
                reader.Close();

                int quantidade = 0;
                if (comboBox1.SelectedIndex == 0)
                    quantidade = 25;
                else if (comboBox1.SelectedIndex == 1)
                    quantidade = 50;
                else
                {
                    MessageBox.Show("Selecione um pacote válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int novoSaldo = saldoAtual + quantidade;

                string sqlUpdate = "UPDATE Alunos SET saldo = @novoSaldo WHERE codigo = @codigo";
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conexao.conn);
                cmdUpdate.Parameters.AddWithValue("@novoSaldo", novoSaldo);
                cmdUpdate.Parameters.AddWithValue("@codigo", codigoAluno);
                cmdUpdate.ExecuteNonQuery();

                string sqlHistorico = @"INSERT INTO Historicos (codigoAluno, dataHistorico, movimentacao, saldoAntesMovimentacao, saldoDepoisMovimentacao) 
                                VALUES (@codigoAluno, @data, @movimentacao, @antes, @depois)";
                SqlCommand cmdHist = new SqlCommand(sqlHistorico, conexao.conn);
                cmdHist.Parameters.AddWithValue("@codigoAluno", codigoAluno);
                cmdHist.Parameters.AddWithValue("@data", DateTime.Now);
                cmdHist.Parameters.AddWithValue("@movimentacao", true);
                cmdHist.Parameters.AddWithValue("@antes", saldoAtual);
                cmdHist.Parameters.AddWithValue("@depois", novoSaldo);
                cmdHist.ExecuteNonQuery();

                MessageBox.Show($"Compra realizada com sucesso!\nSaldo anterior: {saldoAtual}\nNovo saldo: {novoSaldo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NomeAluno.Clear();
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void ComprarImpressoes_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Pacote de 25 impressões");
            comboBox1.Items.Add("Pacote de 50 impressões");
            comboBox1.SelectedIndex = 0;
        }
    }
}
