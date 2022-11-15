using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Aplicativo_NET_Framawork_13.View
{

    public partial class FrmCliente : Form
    {

        public FrmCliente()
        {

            InitializeComponent();

            /*dtpicker_data_nascimento_cliente.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            dtpicker_data_nascimento_cliente.Format = DateTimePickerFormat.Custom;*/

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {



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



        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {



        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {



        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {



        }

    }

}
