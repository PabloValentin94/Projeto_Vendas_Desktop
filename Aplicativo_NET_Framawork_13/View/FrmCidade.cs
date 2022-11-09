﻿using System;
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

    public partial class FrmCidade : Form
    {

        public FrmCidade()
        {

            InitializeComponent();

            desabilitar_elementos();

            carregar_dgv();

            //gerar_id_codigo();

            btn_alterar.Enabled = false;

            btn_excluir.Enabled = false;

        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {

            /* Criando as colunas.

            dgv_registros.Columns.Insert(0, new DataGridViewCheckBoxColumn());

            dgv_registros.Columns.Insert(1, new DataGridViewTextBoxColumn());

            dgv_registros.Columns.Insert(2, new DataGridViewTextBoxColumn());

            dgv_registros.Columns.Insert(3, new DataGridViewTextBoxColumn());

            Renomeando as colunas.

            dgv_registros.Columns[0].Name = "selecionado";

            dgv_registros.Columns[1].Name = "ID";

            dgv_registros.Columns[2].Name = "Nome";

            dgv_registros.Columns[3].Name = "Unidade Federal"; */

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

            if(MessageBox.Show("O formulário será fechado.", "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
               == DialogResult.OK)
            {

                this.Close();

            }

        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(txt_nome_cidade.Text) || String.IsNullOrEmpty(txt_uf_cidade.Text))
            {

                MessageBox.Show("Preencha os campos Cidade e U.F. antes de prosseguir.",
                                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                Model.Cidade insercao = new Model.Cidade()
                {

                    nome = txt_nome_cidade.Text,

                    uf = txt_uf_cidade.Text.ToUpper()

                };

                if(dgv_registros.RowCount > 0)
                {

                    bool condicao_parada = false;

                    foreach(DataGridViewRow linha in dgv_registros.Rows)
                    {

                        if(linha.Cells[1].Value.ToString() == insercao.nome)
                        {

                            condicao_parada = true;

                            break;

                        }

                    }

                    if(condicao_parada == true)
                    {

                        MessageBox.Show("Não é possível inserir uma cidade que já está registrada.", "Aviso!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    else
                    {

                        if(MessageBox.Show("Deseja mesmo confirmar a adição de um novo registro ao banco de dados?", "Atenção!",
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

                else if(dgv_registros.RowCount == 0)
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

            if(String.IsNullOrEmpty(txt_pesquisar_nome.Text) || String.IsNullOrEmpty(txt_pesquisar_unidade_federal.Text))
            {

                MessageBox.Show("Preencha os campos Nome e Un. Federal antes de prosseguir.",
                                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                Model.Cidade alteracao = new Model.Cidade()
                {

                    id = int.Parse(txt_pesquisar_id.Text),

                    nome = txt_pesquisar_nome.Text,

                    uf = txt_pesquisar_unidade_federal.Text.ToUpper()

                };

                if(MessageBox.Show("Tem certeza de que deseja fazer alterações no registro " + txt_pesquisar_id.Text + "?",
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

            if(String.IsNullOrEmpty(txt_nome_cidade.Text) && String.IsNullOrEmpty(txt_uf_cidade.Text)
               && String.IsNullOrEmpty(txt_pesquisar_id.Text) && String.IsNullOrEmpty(txt_pesquisar_nome.Text)
               && String.IsNullOrEmpty(txt_pesquisar_unidade_federal.Text) && btn_pesquisar.Enabled == false)
            {

                MessageBox.Show("Não há nada a ser cancelado.", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else if(btn_pesquisar.Enabled == true)
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

            Model.Cidade exclusao = new Model.Cidade()
            {

                id = int.Parse(txt_pesquisar_id.Text)

            };

            if(MessageBox.Show("Realmente deseja apagar o registro " + txt_pesquisar_id.Text + "?", "Atenção!",
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

            txt_codigo_cidade.Clear();

            txt_nome_cidade.Clear();

            txt_uf_cidade.Clear();

            txt_pesquisar_id.Clear();

            txt_pesquisar_nome.Clear();

            txt_pesquisar_unidade_federal.Clear();

        }

        void carregar_dgv()
        {

            Model.Cidade cidade = new Model.Cidade();

            cidade.Select();

            dgv_registros.DataSource = Database.tabela_de_dados;

        }

        void busca_personalizada(string nome = null)
        {

            Model.Cidade cidade = new Model.Cidade();

            cidade.SelectByName();

            dgv_registros.DataSource = Database.tabela_de_dados;

        }

        /*void gerar_id_codigo()
        {

            if (dgv_registros.RowCount > 0)
            {

                int id_atual = (Convert.ToInt32(dgv_registros.Rows[dgv_registros.RowCount - 1].Cells[0].Value) + 1);

                txt_codigo_cidade.Text = id_atual.ToString();

            }

            else if (dgv_registros.RowCount == 0)
            {

                txt_codigo_cidade.Text = "";

            }

        }*/

        void desabilitar_elementos()
        {

            // Desabilitando os elementos desnecessários:

            txt_pesquisar_nome.Enabled = false;

            txt_pesquisar_unidade_federal.Enabled = false;

            btn_alterar.Enabled = false;

            btn_excluir.Enabled = false;

            btn_pesquisar.Enabled = false;

            // Habilitando os elementos necessários:

            txt_nome_cidade.Enabled = true;

            txt_uf_cidade.Enabled = true;

            btn_incluir.Enabled = true;

        }

        private void dgv_registros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if(dgv_registros.RowCount > 0)
            {

                if (btn_alterar.Enabled == false && btn_excluir.Enabled == false)
                {

                    string texto = "Opções disponíveis:\n\n" +
                                   "Alterar: caso deseje alterar um registro já existente, preencha " +
                                   "os campos Nome e Un. Federal, ao lado da tabela, com as novas " +
                                   "informações. O campo ID serve somente para referenciar o registro " +
                                   "que foi clicado duas vezes.\n\n" +
                                   "Deletar: nesse caso, apenas de um duplo clique no registro " +
                                   "que deseja apagar.";

                    MessageBox.Show(texto, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                // Habilitando os elementos necessários:

                txt_pesquisar_nome.Enabled = true;

                txt_pesquisar_unidade_federal.Enabled = true;

                btn_alterar.Enabled = true;

                btn_excluir.Enabled = true;

                // Desabilitando os elementos desnecessários:

                txt_nome_cidade.Enabled = false;

                txt_uf_cidade.Enabled = false;

                btn_incluir.Enabled = false;

                // Definido os valores das TextBoxes de pesquisa:

                txt_pesquisar_id.Text = dgv_registros.CurrentRow.Cells[0].Value.ToString();

                txt_pesquisar_nome.Text = dgv_registros.CurrentRow.Cells[1].Value.ToString();

                txt_pesquisar_unidade_federal.Text = dgv_registros.CurrentRow.Cells[2].Value.ToString();

            }

        }

        private void txt_pesquisar_nome_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;

                //busca_personalizada(txt_pesquisar_nome.Text);

            }

            else
            {

                e.Handled = true;

            }

        }

        private void dgv_registros_Click(object sender, EventArgs e)
        {

            if(btn_pesquisar.Enabled == false)
            {

                MessageBox.Show("Digite no campo Nome e então clique em pesquisar para encontrar um determinado registro.",
                                "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            txt_pesquisar_nome.Enabled = true;

            btn_pesquisar.Enabled = true;

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            txt_pesquisar_nome.Clear();

            busca_personalizada(txt_pesquisar_nome.Text);

        }

        private void grp_buscar_cidades_Enter(object sender, EventArgs e)
        {

        }

        private void txt_uf_cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_uf_cidade_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_codigo_cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nome_cidade_Click(object sender, EventArgs e)
        {

        }

        private void lbl_codigo_cidade_Click(object sender, EventArgs e)
        {

        }
    }

}
