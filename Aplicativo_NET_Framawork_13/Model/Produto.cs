using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Aplicativo_NET_Framawork_13.Model
{

    public class Produto
    {

        public int id { get; set; }

        public string nome { get; set; }

        public string fornecedor { get; set; }

        public int estoque { get; set; }

        public double preco_venda { get; set; }

        public string foto { get; set; }

        public int fk_categoria { get; set; }

        public int fk_marca { get; set; }

        public string categoria { get; set; }

        public string marca { get; set; }

        public void Incluir()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("INSERT INTO Produto(nome, fornecedor, estoque, " +
                                                    "preco_venda, foto, " +
                                                    "fk_categoria, fk_marca, categoria, marca) " +
                                                    "VALUES(@nome, @fornecedor, @estoque, @preco_venda, @foto, " +
                                                    "@fk_categoria, @fk_marca, @categoria, @marca)", Database.conexao);

                Database.comando.Parameters.AddWithValue("@nome", this.nome);

                Database.comando.Parameters.AddWithValue("@fornecedor", this.fornecedor);

                Database.comando.Parameters.AddWithValue("@estoque", this.estoque);

                Database.comando.Parameters.AddWithValue("@preco_venda", this.preco_venda);

                Database.comando.Parameters.AddWithValue("@foto", this.foto);

                Database.comando.Parameters.AddWithValue("@fk_categoria", this.fk_categoria);

                Database.comando.Parameters.AddWithValue("@fk_marca", this.fk_marca);

                Database.comando.Parameters.AddWithValue("@categoria", this.categoria);

                Database.comando.Parameters.AddWithValue("@marca", this.marca);

                Database.comando.ExecuteNonQuery();

                Database.Fechar_Conexao();

            }

            catch(Exception e)
            {

                MessageBox.Show(e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void Alterar()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("UPDATE Produto SET nome = @nome, fornecedor = @fornecedor, esto" +
                                                    "preco_venda = @preco_venda, foto = @foto, " +
                                                    "fk_categoria = @fk_categoria, fk_marca = @fk_marca, " +
                                                    "categoria = @categoria, marca = @marca WHERE id = @id", Database.conexao);

                Database.comando.Parameters.AddWithValue("@id", this.id);

                Database.comando.Parameters.AddWithValue("@nome", this.nome);

                Database.comando.Parameters.AddWithValue("@fornecedor", this.fornecedor);

                Database.comando.Parameters.AddWithValue("@preco_venda", this.preco_venda);

                Database.comando.Parameters.AddWithValue("@foto", this.foto);

                Database.comando.Parameters.AddWithValue("@fk_categoria", this.fk_categoria);

                Database.comando.Parameters.AddWithValue("@fk_marca", this.fk_marca);

                Database.comando.Parameters.AddWithValue("@categoria", this.categoria);

                Database.comando.Parameters.AddWithValue("@marca", this.marca);

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

                Database.comando = new MySqlCommand("DELETE FROM Produto WHERE id = @id", Database.conexao);

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

                Database.comando = new MySqlCommand("SELECT * FROM Produto", Database.conexao);

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

                Database.comando = new MySqlCommand("SELECT * FROM Produto WHERE nome LIKE @nome", Database.conexao);

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
