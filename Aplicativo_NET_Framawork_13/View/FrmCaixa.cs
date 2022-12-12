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

    public partial class FrmCaixa : Form
    {

        bool insercao;

        double valor_pagamento;

        bool[] formas_pagamento;

        public FrmCaixa(bool insercao = true, double valor_pagamento = 0, bool[] formas_pagamento = null)
        {

            InitializeComponent();

            if (!insercao)
            {

                btn_efetuar_alterar_pagamento.BackColor = Color.Blue;

                btn_efetuar_alterar_pagamento.Text = "Alterar Pagamento";

            }

            this.insercao = insercao;

            this.valor_pagamento = valor_pagamento;

            this.formas_pagamento = formas_pagamento;

        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {

            desabilitar_elementos();

        }

        private void rdbtn_dinheiro_CheckedChanged(object sender, EventArgs e)
        {

            desabilitar_elementos();

            txt_dinheiro.Enabled = true;

        }

        private void rdbtn_cartao_credito_CheckedChanged(object sender, EventArgs e)
        {

            desabilitar_elementos();

            txt_cartao_credito.Enabled = true;

        }

        private void rdbtn_cheque_CheckedChanged(object sender, EventArgs e)
        {

            desabilitar_elementos();

            txt_cheque.Enabled = true;

        }

        private void rdbtn_pix_CheckedChanged(object sender, EventArgs e)
        {

            desabilitar_elementos();

            txt_pix.Enabled = true;

        }

        private void rdbtn_boleto_CheckedChanged(object sender, EventArgs e)
        {

            desabilitar_elementos();

            txt_boleto.Enabled = true;

        }

        void desabilitar_elementos()
        {

            txt_dinheiro.Clear();

            txt_dinheiro.Enabled = false;

            txt_cartao_credito.Clear();

            txt_cartao_credito.Enabled = false;

            txt_cheque.Clear();

            txt_cheque.Enabled = false;

            txt_pix.Clear();

            txt_pix.Enabled = false;

            txt_boleto.Clear();

            txt_boleto.Enabled = false;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btn_efetuar_alterar_pagamento_Click(object sender, EventArgs e)
        {

            if(this.insercao)
            {



            }

            else
            {



            }

        }

    }

}
