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
    public partial class ConsultarHistorico : Form
    {
        public ConsultarHistorico()
        {
            InitializeComponent();
        }

        private void NomeAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnviarHistorico_Click(object sender, EventArgs e)
        {
            string nomeBuscado = NomeAluno.Text.Trim();

            if (string.IsNullOrEmpty(nomeBuscado))
            {
                MessageBox.Show("Digite o nome do aluno.");
                return;
            }

            Historico historico = new Historico();
            var lista = historico.ConsultarPorNome(nomeBuscado);

            if (lista.Count == 0)
            {
                MessageBox.Show("Nenhum histórico encontrado.");
            }

            dataGridViewHistorico.DataSource = lista;
        }

        private void ConsultarHistorico_Load(object sender, EventArgs e)
        {
            dataGridViewHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHistorico.ReadOnly = true;
        }
    }
}
