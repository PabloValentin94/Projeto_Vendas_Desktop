using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_NET_Framawork_13.View
{

    public partial class FrmProduto : Form
    {

        Model.Categoria categoria;

        Model.Marca marca;

        Model.Produto produto;

        public FrmProduto()
        {

            InitializeComponent();

            desabilitar_elementos();

            btn_alterar.Enabled = false;

            btn_excluir.Enabled = false;

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

            // Definindo permissões do usuário.

            dgv_registros.AllowUserToAddRows = false;

            dgv_registros.AllowUserToDeleteRows = false;

            dgv_registros.AllowUserToOrderColumns = true;

            // Configurando o DataGridView.

            dgv_registros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgv_registros.ReadOnly = true;

            // Configurando as ComboBoxes.

            this.categoria = new Model.Categoria();

            cb_categoria_produto.DataSource = categoria.Select();

            cb_categoria_produto.DisplayMember = "nome";

            cb_categoria_produto.ValueMember = "id";

            cb_categoria_produto.Text = "";

            this.marca = new Model.Marca();

            cb_marca_produto.DataSource = marca.Select();

            cb_marca_produto.DisplayMember = "nome";

            cb_marca_produto.ValueMember = "id";

            cb_marca_produto.Text = "";

            carregar_dgv();

            // Ocultando colunas do DataGridView.

            dgv_registros.Columns["foto"].Visible = false;

            dgv_registros.Columns["fk_categoria"].Visible = false;

            dgv_registros.Columns["fk_marca"].Visible = false;

            // Fazendo com que a imagem caiba dentro da PictureBox.

            pctbox_foto_produto.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("O formulário será fechado.", "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
               == DialogResult.OK)
            {

                this.Close();

            }

        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_nome_produto.Text) || String.IsNullOrEmpty(txt_fornecedor_produto.Text) ||
                String.IsNullOrEmpty(cb_categoria_produto.Text) || String.IsNullOrEmpty(cb_marca_produto.Text))
            {

                MessageBox.Show("Preencha todos os campos antes de prosseguir.",
                                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                this.produto = new Model.Produto()
                {

                    nome = txt_nome_produto.Text,

                    fornecedor = txt_fornecedor_produto.Text,

                    estoque = Convert.ToInt32(nud_estoque_produto.Value),

                    preco_venda = double.Parse(txt_preco_de_venda.Text),

                    foto = pctbox_foto_produto.ImageLocation,

                    fk_categoria = (int)cb_categoria_produto.SelectedValue,

                    fk_marca = (int)cb_marca_produto.SelectedValue,

                    categoria = cb_categoria_produto.Text,

                    marca = cb_marca_produto.Text

                };

                if (dgv_registros.RowCount > 0)
                {

                    bool condicao_parada = false;

                    foreach (DataGridViewRow linha in dgv_registros.Rows)
                    {

                        if (linha.Cells[1].Value.ToString() == this.produto.nome)
                        {

                            condicao_parada = true;

                            break;

                        }

                    }

                    if (condicao_parada == true)
                    {

                        MessageBox.Show("Não é possível inserir um produto que já está registrado.", "Aviso!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    else
                    {

                        if (MessageBox.Show("Deseja mesmo confirmar a adição de um novo registro ao banco de dados?", "Atenção!",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            this.produto.Incluir();

                            limpar_campos();

                            carregar_dgv();

                            //gerar_id_codigo();

                            MessageBox.Show("Inserção efetuada com sucesso.", "Atenção!",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }

                    }

                }

                else if (dgv_registros.RowCount == 0)
                {

                    if (MessageBox.Show("Deseja mesmo confirmar a adição de um novo registro ao banco de dados?", "Atenção!",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        this.produto.Incluir();

                        limpar_campos();

                        carregar_dgv();

                        //gerar_id_codigo();

                        MessageBox.Show("Inserção efetuada com sucesso.", "Atenção!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }

            }

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

            this.produto = new Model.Produto()
            {

                id = int.Parse(txt_codigo_produto.Text),

                nome = txt_nome_produto.Text,

                fornecedor = txt_fornecedor_produto.Text,

                estoque = Convert.ToInt32(nud_estoque_produto.Value),

                preco_venda = double.Parse(txt_preco_de_venda.Text),

                foto = pctbox_foto_produto.ImageLocation,

                fk_categoria = (int)cb_categoria_produto.SelectedValue,

                fk_marca = (int)cb_marca_produto.SelectedValue,

                categoria = cb_categoria_produto.Text,

                marca = cb_marca_produto.Text

            };

            if (MessageBox.Show("Tem certeza de que deseja fazer alterações no registro " + txt_codigo_produto.Text + "?",
                                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.produto.Alterar();

                limpar_campos();

                desabilitar_elementos();

                carregar_dgv();

                MessageBox.Show("Alteração efetuada com sucesso.", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_nome_produto.Text) && String.IsNullOrEmpty(txt_fornecedor_produto.Text)
                && String.IsNullOrEmpty(cb_categoria_produto.Text) && String.IsNullOrEmpty(cb_marca_produto.Text)
                && btn_pesquisar.Enabled == false)
            {

                MessageBox.Show("Não há nada a ser cancelado.", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {

                limpar_campos();

                desabilitar_elementos();

            }

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            this.produto = new Model.Produto()
            {

                id = int.Parse(txt_codigo_produto.Text)

            };

            if (MessageBox.Show("Realmente deseja apagar o registro " + txt_codigo_produto.Text + "?", "Atenção!",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.produto.Deletar();

                limpar_campos();

                desabilitar_elementos();

                carregar_dgv();

                MessageBox.Show("Exclusão efetuada com sucesso.", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        void limpar_campos()
        {

            txt_codigo_produto.Clear();

            txt_nome_produto.Clear();

            txt_fornecedor_produto.Clear();

            txt_preco_de_venda.Clear();

            cb_categoria_produto.Text = "";

            cb_marca_produto.Text = "";

            nud_estoque_produto.Value = 0;

            pctbox_foto_produto.ImageLocation = null;

        }

        void carregar_dgv()
        {

            this.produto = new Model.Produto();

            this.produto.Select();

            dgv_registros.DataSource = Database.tabela_de_dados;

        }

        void desabilitar_elementos()
        {

            // Desabilitando os elementos desnecessários:

            btn_alterar.Enabled = false;

            btn_excluir.Enabled = false;

            btn_pesquisar.Enabled = false;

            btn_resetar.Enabled = false;

            // Habilitando os elementos necessários:

            txt_nome_produto.Enabled = true;

            btn_incluir.Enabled = true;

        }

        private void pctbox_foto_produto_Click(object sender, EventArgs e)
        {

            //ofd_foto.InitialDirectory = "C:\\Users\\Evandro\\Downloads";

            ofd_foto_produto.InitialDirectory = "D:\\";

            ofd_foto_produto.FileName = "";

            ofd_foto_produto.ShowDialog();

            pctbox_foto_produto.ImageLocation = ofd_foto_produto.FileName;

        }

        private void dgv_registros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_registros.RowCount > 0)
            {

                if (btn_alterar.Enabled == false && btn_excluir.Enabled == false)
                {

                    string texto = "Opções disponíveis:\n\n" +
                                   "Alterar: caso deseje alterar um registro já existente, preencha " +
                                   "os campos com suas novas " +
                                   "informações. O campo Código serve somente para referenciar o registro " +
                                   "que foi clicado duas vezes.\n\n" +
                                   "Deletar: nesse caso, apenas de um duplo clique no registro " +
                                   "que deseja apagar.";

                    MessageBox.Show(texto, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                // Habilitando os elementos necessários:

                txt_nome_produto.Enabled = true;

                btn_alterar.Enabled = true;

                btn_excluir.Enabled = true;

                btn_incluir.Enabled = false;

                // Definido os valores das TextBoxes de pesquisa:

                txt_codigo_produto.Text = dgv_registros.CurrentRow.Cells["id"].Value.ToString();

                txt_nome_produto.Text = dgv_registros.CurrentRow.Cells["nome"].Value.ToString();

                txt_fornecedor_produto.Text = dgv_registros.CurrentRow.Cells["fornecedor"].Value.ToString();

                nud_estoque_produto.Value = Convert.ToDecimal(dgv_registros.CurrentRow.Cells["estoque"].Value);

                txt_preco_de_venda.Text = dgv_registros.CurrentRow.Cells["preco_venda"].Value.ToString();

                cb_categoria_produto.Text = dgv_registros.CurrentRow.Cells["categoria"].Value.ToString();

                cb_marca_produto.Text = dgv_registros.CurrentRow.Cells["marca"].Value.ToString();

                pctbox_foto_produto.ImageLocation = dgv_registros.CurrentRow.Cells["foto"].Value.ToString();

            }

        }

        private void dgv_registros_Click(object sender, EventArgs e)
        {

            if (btn_pesquisar.Enabled == false)
            {

                MessageBox.Show("Digite no campo Produto e então clique em pesquisar para encontrar um determinado registro. " +
                                "Caso a tabela não esteja mostrando todos os seus registros, clique em resetar antes de fazer a pesquisa.",
                                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            txt_nome_produto.Enabled = true;

            btn_pesquisar.Enabled = true;

            btn_resetar.Enabled = true;

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            /* Essa condição garante que o usuário só irá fazer outra pesquisa, quando o DataGridView estiver resetado, ou seja, 
             * quando todas as linhas estiverem visiveis. */

            int total_linhas = linhas_totais();

            if (dgv_registros.RowCount < total_linhas)
            {

                MessageBox.Show("Clique no botão resetar antes de fazer outra pesquisa.",
                                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                this.produto = new Model.Produto()
                {

                    nome = txt_nome_produto.Text

                };

                this.produto.SelectByName();

                dgv_registros.DataSource = Database.tabela_de_dados;

                limpar_campos();

                desabilitar_elementos();

            }

        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {

            int total_linhas = linhas_totais();

            if (dgv_registros.RowCount != total_linhas)
            {

                carregar_dgv();

            }

            else
            {

                MessageBox.Show("A tabela não precisa ser resetada. Prossiga com a pesquisa.",
                                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        int linhas_totais()
        {

            this.produto = new Model.Produto();

            this.produto.Select();

            int qnt_linhas = 0;

            foreach (DataRow rows in Database.tabela_de_dados.Rows)
            {

                qnt_linhas++;

            }

            return qnt_linhas;

        }

    }

}
