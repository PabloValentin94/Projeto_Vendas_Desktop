using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;

namespace Aplicativo_NET_Framawork_13
{

    public class Database
    {

        public static MySqlConnection conexao;

        public static MySqlCommand comando;

        public static MySqlDataAdapter adaptador;

        public static DataTable tabela_de_dados;

        private static string file_name = "Database";

        public static void Abrir_Conexao()
        {

            try
            {

                // Criando uma conexão com o MySQL e abrindo-a.

                conexao = new MySqlConnection("server=localhost;port=3306;uid=root;pwd=etecjau");

                conexao.Open();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nArquivo: " + file_name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public static void Fechar_Conexao()
        {

            try
            {

                // Fechando a conexão com o MySQL.

                conexao.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nArquivo: " + file_name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public static void Criar_Banco()
        {

            try
            {

                // Abrindo uma conexão com o MySQL.

                Abrir_Conexao();

                // Criando o banco de dados.

                comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS db_vendas; USE db_vendas;", conexao);

                comando.ExecuteNonQuery();

                // Criando a tabela Cidade.

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cidade" +
                                           "(id integer auto_increment primary key," +
                                           "nome varchar(40)," +
                                           "uf char(02))", conexao);

                comando.ExecuteNonQuery();

                // Criando a tabela Categoria.

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Categoria" +
                                           "(id integer auto_increment primary key," +
                                           "nome varchar(30))", conexao);

                comando.ExecuteNonQuery();

                // Criando a tabela Marca.

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Marca" +
                                           "(id integer auto_increment primary key," +
                                           "nome varchar(30))", conexao);

                comando.ExecuteNonQuery();

                // Criando a tabela Cliente.

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cliente" +
                                           "(id integer auto_increment primary key," +
                                           "nome varchar(75)," +
                                           "cpf char(12)," +
                                           "telefone varchar(9)," +
                                           "email varchar(100)," +
                                           "data_nascimento date," +
                                           "renda double," +
                                           "bloqueio_venda boolean," +
                                           "foto varchar(100)," +
                                           "fk_cidade integer)", conexao);

                comando.ExecuteNonQuery();

                // Criando a tabela Produto.

                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Produto" +
                                           "(id integer auto_increment primary key," +
                                           "nome varchar(100)," +
                                           "fornecedor varchar(100)," +
                                           "estoque integer, " +
                                           "preco_venda double, " +
                                           "foto varchar(100)," +
                                           "fk_categoria integer," +
                                           "fk_marca integer," +
                                           "categoria varchar(30)," +
                                           "marca varchar(30))", conexao);

                comando.ExecuteNonQuery();

                // Fechando a conexão com o MySQL.

                Fechar_Conexao();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nArquivo: " + file_name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public static void Apagar_Banco()
        {

            try
            {

                Abrir_Conexao();

                comando = new MySqlCommand("DROP DATABASE IF EXISTS db_vendas", conexao);

                comando.ExecuteNonQuery();

                Fechar_Conexao();

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nArquivo: " + file_name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}
