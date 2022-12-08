using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplicativo_NET_Framawork_13.Model
{

    public class Cliente
    {

        private string file_name = "Cliente"; 

        public int id { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string cpf { get; set; }

        public string telefone { get; set; }

        public DateTime data_nascimento { get; set; }

        public double renda { get; set; }

        public string foto { get; set; }

        public bool bloqueio_venda { get; set; }

        public int fk_cidade { get; set; }

        public void Incluir()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("INSERT INTO " +
                                                    "Cliente(nome, email, cpf, telefone, data_nascimento, " +
                                                    "renda, foto, bloqueio_venda, fk_cidade) " +
                                                    "VALUES(@nome, @email, @cpf, @telefone, @data_nascimento, " +
                                                    "@renda, @foto, @bloqueio_venda, @fk_cidade)", Database.conexao);

                Database.comando.Parameters.AddWithValue("@nome", this.nome);

                Database.comando.Parameters.AddWithValue("@email", this.email);

                Database.comando.Parameters.AddWithValue("@cpf", this.cpf);

                Database.comando.Parameters.AddWithValue("@telefone", this.telefone);

                Database.comando.Parameters.AddWithValue("@data_nascimento", this.data_nascimento);

                Database.comando.Parameters.AddWithValue("@renda", this.renda);

                Database.comando.Parameters.AddWithValue("@foto", this.foto);

                Database.comando.Parameters.AddWithValue("@bloqueio_venda", this.bloqueio_venda);

                Database.comando.Parameters.AddWithValue("@fk_cidade", this.fk_cidade);

                Database.comando.ExecuteNonQuery();

                Database.Fechar_Conexao();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nClasse: " + file_name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void Alterar()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("UPDATE Cliente SET nome = @nome, " +
                                                    "email = @email, cpf = @cpf, telefone = @telefone, " +
                                                    "data_nascimento = @data_nascimento, " +
                                                    "renda = @renda, foto = @foto, bloqueio_venda = @bloqueio_venda, " +
                                                    "fk_cidade = @fk_cidade " +
                                                    "WHERE id = @id", Database.conexao);

                Database.comando.Parameters.AddWithValue("@nome", this.nome);

                Database.comando.Parameters.AddWithValue("@email", this.email);

                Database.comando.Parameters.AddWithValue("@cpf", this.cpf);

                Database.comando.Parameters.AddWithValue("@telefone", this.telefone);

                Database.comando.Parameters.AddWithValue("@data_nascimento", this.data_nascimento);

                Database.comando.Parameters.AddWithValue("@renda", this.renda);

                Database.comando.Parameters.AddWithValue("@foto", this.foto);

                Database.comando.Parameters.AddWithValue("@bloqueio_venda", this.bloqueio_venda);

                Database.comando.Parameters.AddWithValue("@fk_cidade", this.fk_cidade);

                Database.comando.Parameters.AddWithValue("@id", this.id);

                Database.comando.ExecuteNonQuery();

                Database.Fechar_Conexao();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nClasse: " + file_name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nClasse: " + file_name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public DataTable Select()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("SELECT cli.*, cid.nome as cidade, cid.uf as uf " +
                                                    "FROM Cliente cli " +
                                                    "INNER JOIN Cidade cid ON cli.fk_cidade = cid.id", Database.conexao);

                Database.adaptador = new MySqlDataAdapter(Database.comando);

                Database.tabela_de_dados = new DataTable();

                Database.adaptador.Fill(Database.tabela_de_dados);

                Database.Fechar_Conexao();

                return Database.tabela_de_dados;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nClasse: " + file_name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;

            }

        }

        public DataTable SelectByName()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("SELECT cli.*, cid.nome as cidade, cid.uf as uf " +
                                                    "FROM Cliente cli " +
                                                    "INNER JOIN Cidade cid ON cli.fk_cidade = cid.id " +
                                                    "WHERE cli.nome LIKE @nome " +
                                                    "ORDER BY cli.nome ASC", Database.conexao);

                Database.comando.Parameters.AddWithValue("@nome", "%" + this.nome + "%");

                Database.adaptador = new MySqlDataAdapter(Database.comando);

                Database.tabela_de_dados = new DataTable();

                Database.adaptador.Fill(Database.tabela_de_dados);

                Database.Fechar_Conexao();

                return Database.tabela_de_dados;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nClasse: " + file_name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;

            }

        }

    }

}
