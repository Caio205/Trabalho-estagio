using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Trabalho_estágio___Pronto__
{
    public class Conexao
    {
        SqlConnection connection = new SqlConnection();

        public Conexao()
        {
            connection.ConnectionString = @"User ID=aluno5;Password=aluno_4498;Data Source=localhost\SQLEXPRESS;Initial Catalog=Eproc_aluno5; Persist Security Info=True;Timeout=120";
        }
        public SqlConnection Conectar()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        public void Desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
