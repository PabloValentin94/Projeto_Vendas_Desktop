using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }

}
