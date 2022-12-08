using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Aplicativo_NET_Framawork_13.View;

namespace Aplicativo_NET_Framawork_13
{

    public partial class FrmMenu : Form
    {

        public FrmMenu()
        {

            InitializeComponent();

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

            try
            {

                Database.Criar_Banco();

            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nForm: " + this.Name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                FrmCidade form = new FrmCidade();

                form.Show();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nForm: " + this.Name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                FrmCliente form = new FrmCliente();

                form.Show();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nForm: " + this.Name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                FrmCategoria form = new FrmCategoria();

                form.Show();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nForm: " + this.Name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                FrmMarca form = new FrmMarca();

                form.Show();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nForm: " + this.Name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                FrmProduto form = new FrmProduto();

                form.Show();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nForm: " + this.Name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                FrmCaixa form = new FrmCaixa();

                form.Show();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nForm: " + this.Name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void excluir_banco_dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("Tem certeza de que deseja apagar todo o banco de dados? Após a confirmação, " +
                                    "não haverá como voltar atrás.",
                                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    Database.Apagar_Banco();

                }

                else
                {

                    MessageBox.Show("O banco de dados ainda não existe.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " \n\nForm: " + this.Name, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}
