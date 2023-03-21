using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using Mysqlx.Prepare;

namespace Estoque
{
    internal class Conexão
    {
        
        

        public static MySqlConnection conexao ;

        public static MySqlCommand cmd;

        private  static readonly string conection = "server = localhost ; uid = root ; pwd = sua_senha ";

        




    public static void Conectar()
        {
            try
            {

                conexao = new MySqlConnection(conection);
                cmd = new MySqlCommand
                {
                    Connection = conexao
                };

                conexao.Open();               

                cmd.CommandText = "create database if not exists mercado_do_zé;";
               

                cmd.ExecuteNonQuery();

                cmd.CommandText = " use mercado_do_zé;";

                cmd.ExecuteNonQuery();

                cmd.CommandText = " create table if not exists produtos (" +
                    "                       Nome_produtos varchar(30) primary key not null," +
                    "                       Categoria varchar(7) not null,                 " +
                    "                       Preço decimal(7,2) not null," +
                    "                       Quantidade int not null" +
                    ");";


                cmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO CONECTAR",ex.Message);
            }

        }


        public static void CadatrarP_banco(string nome ,string Categoria, string preço , int quantidade)
        {
            try
            {
                conexao = new MySqlConnection(conection);
                cmd = new MySqlCommand
                {
                    Connection = conexao
                };

                conexao.Open();

                cmd.CommandText = "use mercado_do_zé;";

                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO produtos VALUES (@nome,@Categoria, @Preço,@Quantidade)";


                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@Categoria", Categoria);
                cmd.Parameters.AddWithValue("@Preço", preço);
                cmd.Parameters.AddWithValue("@Quantidade", quantidade);

                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Produto cadastrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO cadastrar produto", ex.Message);
            }


            
        }

        public static DataTable Carrega_dados_estoque()
        {
            try
            {
                conexao = new MySqlConnection(conection);
                cmd = new MySqlCommand
                {
                    Connection = conexao
                };
                conexao.Open();
                cmd.CommandText = "SELECT * FROM produtos ;";

                
                DataTable dt = new();
                dt.Load(cmd.ExecuteReader());
                conexao.Close();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO Carrega dados estoque", ex.Message);
                return null;
            }

            
        }


        public static void Atualiza_estoque(string nome, string preço, int quantidade)
        {
            try
            {
                conexao = new MySqlConnection(conection);
                cmd = new MySqlCommand
                {
                    Connection = conexao
                };

                conexao.Open();

                cmd.CommandText = "use mercado_do_zé;";

                cmd.ExecuteNonQuery();

                cmd.CommandText = " UPDATE produtos set Preço = @preço , Quantidade= @Quantidade where Nome_produtos = @nome ";


                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@Preço", preço);
                cmd.Parameters.AddWithValue("@Quantidade", quantidade);

                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Produto atualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao atualizar estoque", ex.Message);
            }


        }


        public static void Deletar_produto(string nome)
        {
            try
            {
                conexao = new MySqlConnection(conection);
                cmd = new MySqlCommand
                {
                    Connection = conexao
                };

                conexao.Open();

                cmd.CommandText = "use mercado_do_zé;";

                cmd.ExecuteNonQuery();

                cmd.CommandText = " DELETE FROM produtos WHERE Nome_produtos = @nome ";


                cmd.Parameters.AddWithValue("@nome", nome);
                

                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Produto deletado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao deletar produto", ex.Message);
            }


        }




    }

    

}
