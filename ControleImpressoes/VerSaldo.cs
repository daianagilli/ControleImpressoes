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
    public partial class VerSaldo : Form
    {
        public VerSaldo()
        {
            InitializeComponent();
        }

        private void NomeAluno_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewSaldo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void EnviarSaldo_Click(object sender, EventArgs e)
        {
            string nomeBuscado = NomeAluno.Text.Trim();

            var lista = AlunoService.ObterSaldos();

            if (!string.IsNullOrEmpty(nomeBuscado))
            {
                lista = lista
                    .Where(a => a.Nome.ToLower().Contains(nomeBuscado.ToLower()))
                    .ToList();
            }

            if (lista.Count == 0)
            {
                MessageBox.Show("Nenhum aluno encontrado com esse nome.", "Consulta de Saldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridViewSaldo.DataSource = lista;
        }

        private void VerSaldo_Load(object sender, EventArgs e)
        {
            var lista = AlunoService.ObterSaldos();
            dataGridViewSaldo.DataSource = lista;
        }
    }
}
