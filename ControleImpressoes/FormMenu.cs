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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void cadastrar_Click(object sender, EventArgs e)
        {
            var form = new CadastrarAluno();
            form.ShowDialog();
        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            var form = new ComprarImpressoes();
            form.ShowDialog();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            var form = new VerSaldo();
            form.ShowDialog();
        }

        private void ConsultarHistorico_Click(object sender, EventArgs e)
        {
            var form = new ConsultarHistorico();
            form.ShowDialog();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
