using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Skateshop.sql
{
    class Conexao
    {
        public MySqlConnection objConect = new MySqlConnection();
        public MySqlCommand objComando = new MySqlCommand();
        public MySqlDataReader objDados;

        public void ConexaoDB()
        {
            try
            {
                objConect.ConnectionString = "Server='179.188.16.206';Database='veskateshop';User='veskateshop';Pwd='mamute09*/';SslMode=none";
                //objConect.ConnectionString = "Server='localhost';Database='veskateshop';User='root';Pwd=''";
                objConect.Open();
            }
            catch (Exception Erro)
            {

                MessageBox.Show("Erro ==> " + Erro.Message);
            }
        }
    }
}
