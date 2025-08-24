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

namespace ControleImpressoes
{
    public partial class CadastrarAluno : Form
    {
        public CadastrarAluno()
        {
            InitializeComponent();
        }

        private void EnviarAluno_Click(object sender, EventArgs e)
        {
            string nome = NomeAluno.Text.Trim();
            string matricula = MatriculaAluno.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(matricula))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Conexao conexao = new Conexao();

            try
            {
                conexao.Conectar();

                string sql = @"INSERT INTO Alunos (nome, matricula, saldo)
                       VALUES (@nome, @matricula, @saldo)";

                SqlCommand cmd = new SqlCommand(sql, conexao.conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@saldo", 0);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NomeAluno.Clear();
                    MatriculaAluno.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar aluno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void NomeAluno_TextChanged(object sender, EventArgs e)
        {
            string texto = NomeAluno.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-ZÀ-ÿ\s]*$"))
            {
                MessageBox.Show("O nome só pode conter letras e espaços.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NomeAluno.Text = ""; 
            }
        }
    }
}
