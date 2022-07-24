using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Trabalho_estágio___Pronto__
{
    public class Manipulacao
    {
        SqlCommand cmd = new SqlCommand();
        Conexao Conexao = new Conexao();
        public void Inclusão(string nomep, string valorp, int qtdp)
        {
            cmd.CommandText = $"insert into Produto(nomep, valorp, qtdp) values(@nomep, @valorp, @qtdp)" +
                                "select cast(scope_identity() as int)";
            cmd.Parameters.AddWithValue("@nomep", nomep);
            cmd.Parameters.AddWithValue("@valorp", valorp);
            cmd.Parameters.AddWithValue("@qtdp", qtdp);
            try
            {
                cmd.Connection = Conexao.Conectar();
                var i = cmd.ExecuteScalar();
                Conexao.Desconectar();
            }
            catch (SqlException es)
            {
                Console.WriteLine(es.Message);
            }
        }
        public void Alteração(string nomep, string valorp, int qtdp)
        {
            cmd.CommandText = "update Produto set valorp = @valorp, qtdp = @qtdp where nomep = @nomep";
            cmd.Parameters.AddWithValue("@nomep", nomep);
            cmd.Parameters.AddWithValue("@valorp", valorp);
            cmd.Parameters.AddWithValue("@qtdp", qtdp);
            try
            {
                cmd.Connection = Conexao.Conectar();
                var i = cmd.ExecuteNonQuery();
                Conexao.Desconectar();
            }
            catch (SqlException es)
            {
                Console.WriteLine(es.Message);
            }
        }
        public void Deletar(string nomep)
        {
            cmd.CommandText = $"delete from Produto where nomep = @nomep";
            cmd.Parameters.AddWithValue("@nomep", nomep);
            try
            {
                cmd.Connection = Conexao.Conectar();
                var i = cmd.ExecuteNonQuery();
                Conexao.Desconectar();
            }
            catch (SqlException es)
            {
                Console.WriteLine(es.Message);
            }
        }
        public void Consulta()
        {
            cmd.CommandText = $"select * from Produto";

            try
            {
                cmd.Connection = Conexao.Conectar();
                var i = cmd.ExecuteReader();


                while (i.Read())
                {
                    Console.WriteLine(string.Format(@"Nome: {0} | Valor: {1} | Quantidade: {2}", i[1], i[2], i[3]));
                }
                Conexao.Desconectar();
            }
            catch (SqlException es)
            {
                Console.WriteLine(es.Message);
            }
        }
    }
}
