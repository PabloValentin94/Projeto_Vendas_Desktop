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

    public class Caixa
    {

        private readonly string file_name = "Caixa";

        public int id_cliente { get; set; }

        public int id_venda { get; set; }

        public double valor_pagamento { get; set; }

        public bool dinheiro { get; set; }

        public bool cartao_credito { get; set; }

        public bool cheque { get; set; }

        public bool pix { get; set; }

        public bool boleto { get; set; }

        public void Incluir()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("INSERT INTO Caixa(valor_pagamento, dinheiro, cartao_credito, cheque, pix, boleto) " +
                                                    "VALUES(@valor_pagamento, @dinheiro, @cartao_credito, @cheque, @pix, @boleto)", 
                                                    Database.conexao);

                Database.comando.Parameters.AddWithValue("@valor_pagamento", this.valor_pagamento);

                Database.comando.Parameters.AddWithValue("@dinheiro", this.dinheiro);

                Database.comando.Parameters.AddWithValue("@cartao_credito", this.cartao_credito);

                Database.comando.Parameters.AddWithValue("@cheque", this.cheque);

                Database.comando.Parameters.AddWithValue("@pix", this.pix);

                Database.comando.Parameters.AddWithValue("@boleto", this.boleto);

                Database.comando.ExecuteNonQuery();

                Database.Fechar_Conexao();

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nClasse: " + file_name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public void Alterar()
        {

            try
            {

                Database.Abrir_Conexao();

                Database.comando = new MySqlCommand("UPDATE Caixa SET valor_pagamento = @valor_pagamento, " +
                                                    "dinheiro = @dinheiro, cartao_credito = @cartao_credito," +
                                                    "cheque = @cheque, pix = @pix, boleto = @boleto " +
                                                    "WHERE id_cliente = @id_cliente AND id_venda = @id_venda", Database.conexao);

                Database.comando.Parameters.AddWithValue("@id_cliente", this.id_cliente);

                Database.comando.Parameters.AddWithValue("@id_venda", this.id_venda);

                Database.comando.Parameters.AddWithValue("@valor_pagamento", this.valor_pagamento);

                Database.comando.Parameters.AddWithValue("@dinheiro", this.dinheiro);

                Database.comando.Parameters.AddWithValue("@cartao_credito", this.cartao_credito);

                Database.comando.Parameters.AddWithValue("@cheque", this.cheque);

                Database.comando.Parameters.AddWithValue("@pix", this.pix);

                Database.comando.Parameters.AddWithValue("@boleto", this.boleto);

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

                Database.comando = new MySqlCommand("DELETE FROM Caixa WHERE id_cliente = @id_cliente AND id_venda = @id_venda", Database.conexao);

                Database.comando.Parameters.AddWithValue("@id_cliente", this.id_cliente);

                Database.comando.Parameters.AddWithValue("@id_venda", this.id_venda);

                Database.comando.ExecuteNonQuery();

                Database.Fechar_Conexao();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nClasse: " + file_name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}
