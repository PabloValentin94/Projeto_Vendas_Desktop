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

            dtpicker_data_nascimento.MaxDate = DateTime.Today;

            dtpicker_data_nascimento.MinDate = new DateTime(1950, 01, 01);

            /*Database.Abrir_Conexao();

            Database.comando = new MySqlCommand("DELIMITER //" +
                                                "CREATE TRIGGER tgr_formatar_data AFTER INSERT " +
                                                "ON Cliente FOR EACH ROW" +
                                                "BEGIN" +
                                                "UPDATE ALL Cliente SET data_nascimento = " +
                                                "DATE_FORMAT(data_nascimento, ('%Y/%M/%d')" +
                                                "WHERE data_nascimento = OLD.data_nascimento;" +
                                                "END; //", Database.conexao);

            Database.comando.ExecuteNonQuery();

            Database.Fechar_Conexao();*/

        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
