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

    public partial class FrmCategoria : Form
    {

        public FrmCategoria()
        {

            InitializeComponent();

            desabilitar_elementos();

            carregar_dgv();

            btn_alterar.Enabled = false;

            btn_excluir.Enabled = false;

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

            /* Criando as colunas.

            dgv_registros.Columns.Insert(0, new DataGridViewCheckBoxColumn());

            dgv_registros.Columns.Insert(1, new DataGridViewTextBoxColumn());

            dgv_registros.Columns.Insert(2, new DataGridViewTextBoxColumn());

            Renomeando as colunas.

            dgv_registros.Columns[0].Name = "selecionado";

            dgv_registros.Columns[1].Name = "ID";

            dgv_registros.Columns[2].Name = "Nome"; */

            // Definindo permissões do usuário.

            dgv_registros.AllowUserToAddRows = false;

            dgv_registros.AllowUserToDeleteRows = false;

            dgv_registros.AllowUserToOrderColumns = true;

            // Configurando o DataGridView.

            dgv_registros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgv_registros.ReadOnly = true;

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

            if (String.IsNullOrEmpty(txt_nome_categoria.Text))
            {

                MessageBox.Show("Preencha o campo Categoria antes de prosseguir.",
                                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                Model.Categoria insercao = new Model.Categoria()
                {

                    nome = txt_nome_categoria.Text

                };

                if (dgv_registros.RowCount > 0)
                {

                    bool condicao_parada = false;

                    foreach (DataGridViewRow linha in dgv_registros.Rows)
                    {

                        if (linha.Cells[1].Value.ToString() == insercao.nome)
                        {

                            condicao_parada = true;

                            break;

                        }

                    }

                    if (condicao_parada == true)
                    {

                        MessageBox.Show("Não é possível inserir uma categoria que já está registrada.", "Aviso!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    else
                    {

                        if (MessageBox.Show("Deseja mesmo confirmar a adição de um novo registro ao banco de dados?", "Atenção!",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            insercao.Incluir();

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

                        insercao.Incluir();

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

            if (String.IsNullOrEmpty(txt_pesquisar_nome.Text))
            {

                MessageBox.Show("Preencha o campo Nome antes de prosseguir.",
                                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                Model.Categoria alteracao = new Model.Categoria()
                {

                    id = int.Parse(txt_pesquisar_id.Text),

                    nome = txt_pesquisar_nome.Text

                };

                if (MessageBox.Show("Tem certeza de que deseja fazer alterações no registro " + txt_pesquisar_id.Text + "?",
                                   "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    alteracao.Alterar();

                    limpar_campos();

                    desabilitar_elementos();

                    carregar_dgv();

                    MessageBox.Show("Alteração efetuada com sucesso.", "Atenção!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_nome_categoria.Text) && String.IsNullOrEmpty(txt_pesquisar_id.Text)
                && String.IsNullOrEmpty(txt_pesquisar_nome.Text) && btn_pesquisar.Enabled == false)
            {

                MessageBox.Show("Não há nada a ser cancelado.", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else if (btn_pesquisar.Enabled == true)
            {

                txt_pesquisar_nome.Clear();

                txt_pesquisar_nome.Enabled = false;

                btn_pesquisar.Enabled = false;

            }

            else
            {

                limpar_campos();

                desabilitar_elementos();

            }

            //carregar_dgv();

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            Model.Categoria exclusao = new Model.Categoria()
            {

                id = int.Parse(txt_pesquisar_id.Text)

            };

            if (MessageBox.Show("Realmente deseja apagar o registro " + txt_pesquisar_id.Text + "?", "Atenção!",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                exclusao.Deletar();

                limpar_campos();

                desabilitar_elementos();

                carregar_dgv();

                MessageBox.Show("Exclusão efetuada com sucesso.", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        void limpar_campos()
        {

            txt_codigo_categoria.Clear();

            txt_nome_categoria.Clear();

            txt_pesquisar_id.Clear();

            txt_pesquisar_nome.Clear();

        }

        void carregar_dgv()
        {

            Model.Categoria categoria = new Model.Categoria();

            categoria.Select();

            dgv_registros.DataSource = Database.tabela_de_dados;

        }

        void desabilitar_elementos()
        {

            // Desabilitando os elementos desnecessários:

            txt_pesquisar_nome.Enabled = false;

            btn_alterar.Enabled = false;

            btn_excluir.Enabled = false;

            btn_pesquisar.Enabled = false;

            btn_resetar.Enabled = false;

            // Habilitando os elementos necessários:

            txt_nome_categoria.Enabled = true;

            btn_incluir.Enabled = true;

        }

        private void dgv_registros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_registros.RowCount > 0)
            {

                if (btn_alterar.Enabled == false && btn_excluir.Enabled == false)
                {

                    string texto = "Opções disponíveis:\n\n" +
                                   "Alterar: caso deseje alterar um registro já existente, preencha " +
                                   "o campo Nome, ao lado da tabela, com a nova " +
                                   "informação. O campo ID serve somente para referenciar o registro " +
                                   "que foi clicado duas vezes.\n\n" +
                                   "Deletar: nesse caso, apenas de um duplo clique no registro " +
                                   "que deseja apagar.";

                    MessageBox.Show(texto, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                // Habilitando os elementos necessários:

                txt_pesquisar_nome.Enabled = true;

                btn_alterar.Enabled = true;

                btn_excluir.Enabled = true;

                // Desabilitando os elementos desnecessários:

                txt_nome_categoria.Enabled = false;

                btn_incluir.Enabled = false;

                // Definido os valores das TextBoxes de pesquisa:

                txt_pesquisar_id.Text = dgv_registros.CurrentRow.Cells[0].Value.ToString();

                txt_pesquisar_nome.Text = dgv_registros.CurrentRow.Cells[1].Value.ToString();

            }

        }

        private void dgv_registros_Click(object sender, EventArgs e)
        {

            if (btn_pesquisar.Enabled == false)
            {

                MessageBox.Show("Digite no campo Nome e então clique em pesquisar para encontrar um determinado registro. " +
                                "Caso a tabela não esteja mostrando todos os seus registros, clique em resetar antes de fazer a pesquisa.",
                                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            txt_pesquisar_nome.Enabled = true;

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

                Model.Categoria categoria = new Model.Categoria()
                {

                    nome = txt_pesquisar_nome.Text

                };

                categoria.SelectByName();

                dgv_registros.DataSource = Database.tabela_de_dados;

                limpar_campos();

                desabilitar_elementos();

            }

        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {

            int total_linhas = linhas_totais();

            if(dgv_registros.RowCount != total_linhas)
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

            Model.Categoria categoria = new Model.Categoria();

            categoria.Select();

            int qnt_linhas = 0;

            foreach(DataRow rows in Database.tabela_de_dados.Rows)
            {

                qnt_linhas++;

            }

            return qnt_linhas;

        }

    }

}
