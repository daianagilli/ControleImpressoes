using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleImpressoes
{
    public class Conexao
    {
        public SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=sistemaImpressoes;Data Source=DESKTOP-JHONATA\\SQLEXPRESS\r\n");

        public void Conectar()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void Desconectar()
        {
            
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
                
        }
    }
}
