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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void NomeAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownPaginas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EnviarImprimir_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            string nomeAluno = NomeAluno.Text.Trim();
            int quantidade = (int)numericUpDownPaginas.Value;

            if (string.IsNullOrEmpty(nomeAluno))
            {
                MessageBox.Show("Digite o nome do aluno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantidade <= 0)
            {
                MessageBox.Show("Digite uma quantidade válida de páginas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conexao.Conectar();

                string sqlBusca = "SELECT saldo FROM Alunos WHERE nome = @nome";
                SqlCommand cmdBusca = new SqlCommand(sqlBusca, conexao.conn);
                cmdBusca.Parameters.AddWithValue("@nome", nomeAluno);

                object result = cmdBusca.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Aluno não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int saldoAtual = Convert.ToInt32(result);

                    if (saldoAtual >= quantidade)
                    {
                        int novoSaldo = saldoAtual - quantidade;

                        string sqlAtualizar = "UPDATE Alunos SET saldo = @novoSaldo WHERE nome = @nome";
                        SqlCommand cmdAtualizar = new SqlCommand(sqlAtualizar, conexao.conn);
                        cmdAtualizar.Parameters.AddWithValue("@novoSaldo", novoSaldo);
                        cmdAtualizar.Parameters.AddWithValue("@nome", nomeAluno);
                        cmdAtualizar.ExecuteNonQuery();

                        MessageBox.Show($"Impressão realizada com sucesso!\nPáginas impressas: {quantidade}\nSaldo restante: {novoSaldo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NomeAluno.Clear();
                        numericUpDownPaginas.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente para realizar a impressão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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

    }
}
