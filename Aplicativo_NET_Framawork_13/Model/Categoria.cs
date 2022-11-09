using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_NET_Framawork_13.Model
{

    public  class Categoria
    {

        public int id { get; set; }

        public string nome { get; set; }

        public void Incluir()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("INSERT INTO Categoria(nome) VALUES(@nome)", Database.conexao);

                Database.comando.Parameters.AddWithValue("@nome", this.nome);

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

                Database.comando = new MySqlCommand("UPDATE Categoria SET nome = @nome WHERE id = @id", Database.conexao);

                Database.comando.Parameters.AddWithValue("@id", this.id);

                Database.comando.Parameters.AddWithValue("@nome", this.nome);

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

                Database.comando = new MySqlCommand("DELETE FROM Categoria WHERE id = @id", Database.conexao);

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

                Database.comando = new MySqlCommand("SELECT * FROM Categoria", Database.conexao);

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

                Database.comando = new MySqlCommand("SELECT * FROM Categoria WHERE nome LIKE @nome" +
                                                    "Order By nome ASC", Database.conexao);

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
