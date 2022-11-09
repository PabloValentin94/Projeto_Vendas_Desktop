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

            Database.Criar_Banco();

        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmCidade form = new FrmCidade();

            form.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmCliente form = new FrmCliente();

            form.Show();

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmCategoria form = new FrmCategoria();

            form.Show();

        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmMarca form = new FrmMarca();

            form.Show();

        }

    }

}
