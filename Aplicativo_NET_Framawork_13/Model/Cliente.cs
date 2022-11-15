using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.Data;
//using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplicativo_NET_Framawork_13.Model
{

    internal class Cliente
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string cpf { get; set; }

        public string telefone { get; set; }

        public DateTime data_nascimento { get; set; }

        public void Incluir()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("INSERT INTO " +
                                                    "Cliente(nome, email, cpf, telefone, data_nascimento) " +
                                                    "VALUES(@nome, @email, @cpf, @telefone, @data_nascimento)",
                                                    Database.conexao);

                Database.comando.Parameters.AddWithValue("@nome", this.nome);

                Database.comando.Parameters.AddWithValue("@email", this.email);

                Database.comando.Parameters.AddWithValue("@cpf", this.cpf);

                Database.comando.Parameters.AddWithValue("@telefone", this.telefone);

                Database.comando.Parameters.AddWithValue("@data_nascimento", this.data_nascimento);

                Database.comando.ExecuteNonQuery();

                Database.Fechar_Conexao();

            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void Alterar()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("UPDATE Cliente SET nome = @nome, " +
                                                    "email = @email, cpf = @cpf, telefone = @telefone, " +
                                                    "data_nascimento = @data_nascimento " +
                                                    "WHERE id = @id", Database.conexao);

                Database.comando.Parameters.AddWithValue("@id", this.id);

                Database.comando.Parameters.AddWithValue("@nome", this.nome);

                Database.comando.Parameters.AddWithValue("@email", this.email);

                Database.comando.Parameters.AddWithValue("@cpf", this.cpf);

                Database.comando.Parameters.AddWithValue("@telefone", this.telefone);

                Database.comando.Parameters.AddWithValue("@data_nascimento", this.data_nascimento);

                Database.comando.ExecuteNonQuery();

                Database.Fechar_Conexao();

            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void Deletar()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("DELETE FROM Cliente WHERE id = @id",
                                                    Database.conexao);

                Database.comando.Parameters.AddWithValue("@id", this.id);

                Database.comando.ExecuteNonQuery();

                Database.Fechar_Conexao();

            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public DataTable Select()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("SELECT * FROM Cliente", Database.conexao);

                Database.adaptador = new MySqlDataAdapter(Database.comando);

                Database.tabela_de_dados = new DataTable();

                Database.adaptador.Fill(Database.tabela_de_dados);

                Database.Fechar_Conexao();

                return Database.tabela_de_dados;

            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;

            }

        }

        public DataTable SelectByName()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("SELECT * FROM Cliente WHERE nome = @nome", Database.conexao);

                Database.comando.Parameters.AddWithValue("@nome", "%" + this.nome + "%");

                Database.adaptador = new MySqlDataAdapter(Database.comando);

                Database.tabela_de_dados = new DataTable();

                Database.adaptador.Fill(Database.tabela_de_dados);

                Database.Fechar_Conexao();

                return Database.tabela_de_dados;

            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;

            }

        }

    }

}
