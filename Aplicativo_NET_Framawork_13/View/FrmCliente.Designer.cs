namespace Aplicativo_NET_Framawork_13.View
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_buscar_cidades = new System.Windows.Forms.GroupBox();
            this.txt_pesquisar_nome = new System.Windows.Forms.TextBox();
            this.lbl_pesquisar_nome = new System.Windows.Forms.Label();
            this.txt_pesquisar_unidade_federal = new System.Windows.Forms.TextBox();
            this.lbl_pesquisar_unidade_federal = new System.Windows.Forms.Label();
            this.dgv_registros = new System.Windows.Forms.DataGridView();
            this.txt_pesquisar_id = new System.Windows.Forms.TextBox();
            this.lbl_pesquisar_id = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.txt_uf_cidade = new System.Windows.Forms.TextBox();
            this.lbl_uf_cidade = new System.Windows.Forms.Label();
            this.txt_nome_cidade = new System.Windows.Forms.TextBox();
            this.txt_codigo_cidade = new System.Windows.Forms.TextBox();
            this.lbl_nome_cidade = new System.Windows.Forms.Label();
            this.lbl_codigo_cidade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpicker_data_nascimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_buscar_cidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_buscar_cidades
            // 
            this.grp_buscar_cidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_buscar_cidades.Controls.Add(this.txt_pesquisar_nome);
            this.grp_buscar_cidades.Controls.Add(this.lbl_pesquisar_nome);
            this.grp_buscar_cidades.Controls.Add(this.txt_pesquisar_unidade_federal);
            this.grp_buscar_cidades.Controls.Add(this.lbl_pesquisar_unidade_federal);
            this.grp_buscar_cidades.Controls.Add(this.dgv_registros);
            this.grp_buscar_cidades.Controls.Add(this.txt_pesquisar_id);
            this.grp_buscar_cidades.Controls.Add(this.lbl_pesquisar_id);
            this.grp_buscar_cidades.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_buscar_cidades.Location = new System.Drawing.Point(8, 241);
            this.grp_buscar_cidades.Name = "grp_buscar_cidades";
            this.grp_buscar_cidades.Size = new System.Drawing.Size(785, 261);
            this.grp_buscar_cidades.TabIndex = 35;
            this.grp_buscar_cidades.TabStop = false;
            this.grp_buscar_cidades.Text = "Pesquisar:";
            // 
            // txt_pesquisar_nome
            // 
            this.txt_pesquisar_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar_nome.Location = new System.Drawing.Point(27, 124);
            this.txt_pesquisar_nome.Name = "txt_pesquisar_nome";
            this.txt_pesquisar_nome.Size = new System.Drawing.Size(100, 26);
            this.txt_pesquisar_nome.TabIndex = 9;
            // 
            // lbl_pesquisar_nome
            // 
            this.lbl_pesquisar_nome.AutoSize = true;
            this.lbl_pesquisar_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisar_nome.Location = new System.Drawing.Point(23, 102);
            this.lbl_pesquisar_nome.Name = "lbl_pesquisar_nome";
            this.lbl_pesquisar_nome.Size = new System.Drawing.Size(60, 19);
            this.lbl_pesquisar_nome.TabIndex = 8;
            this.lbl_pesquisar_nome.Text = "Nome:";
            // 
            // txt_pesquisar_unidade_federal
            // 
            this.txt_pesquisar_unidade_federal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar_unidade_federal.Location = new System.Drawing.Point(27, 208);
            this.txt_pesquisar_unidade_federal.MaxLength = 2;
            this.txt_pesquisar_unidade_federal.Name = "txt_pesquisar_unidade_federal";
            this.txt_pesquisar_unidade_federal.Size = new System.Drawing.Size(100, 26);
            this.txt_pesquisar_unidade_federal.TabIndex = 7;
            // 
            // lbl_pesquisar_unidade_federal
            // 
            this.lbl_pesquisar_unidade_federal.AutoSize = true;
            this.lbl_pesquisar_unidade_federal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisar_unidade_federal.Location = new System.Drawing.Point(23, 186);
            this.lbl_pesquisar_unidade_federal.Name = "lbl_pesquisar_unidade_federal";
            this.lbl_pesquisar_unidade_federal.Size = new System.Drawing.Size(102, 19);
            this.lbl_pesquisar_unidade_federal.TabIndex = 6;
            this.lbl_pesquisar_unidade_federal.Text = "Un. Federal:";
            // 
            // dgv_registros
            // 
            this.dgv_registros.AllowUserToAddRows = false;
            this.dgv_registros.AllowUserToDeleteRows = false;
            this.dgv_registros.AllowUserToOrderColumns = true;
            this.dgv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registros.Location = new System.Drawing.Point(158, 25);
            this.dgv_registros.Name = "dgv_registros";
            this.dgv_registros.ReadOnly = true;
            this.dgv_registros.Size = new System.Drawing.Size(600, 218);
            this.dgv_registros.TabIndex = 5;
            // 
            // txt_pesquisar_id
            // 
            this.txt_pesquisar_id.Enabled = false;
            this.txt_pesquisar_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar_id.Location = new System.Drawing.Point(27, 48);
            this.txt_pesquisar_id.Name = "txt_pesquisar_id";
            this.txt_pesquisar_id.Size = new System.Drawing.Size(100, 26);
            this.txt_pesquisar_id.TabIndex = 4;
            // 
            // lbl_pesquisar_id
            // 
            this.lbl_pesquisar_id.AutoSize = true;
            this.lbl_pesquisar_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisar_id.Location = new System.Drawing.Point(23, 26);
            this.lbl_pesquisar_id.Name = "lbl_pesquisar_id";
            this.lbl_pesquisar_id.Size = new System.Drawing.Size(31, 19);
            this.lbl_pesquisar_id.TabIndex = 3;
            this.lbl_pesquisar_id.Text = "ID:";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fechar.BackColor = System.Drawing.Color.Black;
            this.btn_fechar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(641, 151);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(152, 71);
            this.btn_fechar.TabIndex = 34;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_excluir.BackColor = System.Drawing.Color.Red;
            this.btn_excluir.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(482, 151);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(152, 71);
            this.btn_excluir.TabIndex = 33;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(324, 151);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(152, 71);
            this.btn_cancelar.TabIndex = 32;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_alterar.BackColor = System.Drawing.Color.Blue;
            this.btn_alterar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(166, 151);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(152, 71);
            this.btn_alterar.TabIndex = 31;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            // 
            // btn_incluir
            // 
            this.btn_incluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_incluir.BackColor = System.Drawing.Color.Green;
            this.btn_incluir.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incluir.ForeColor = System.Drawing.Color.White;
            this.btn_incluir.Location = new System.Drawing.Point(8, 151);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(152, 71);
            this.btn_incluir.TabIndex = 30;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = false;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // txt_uf_cidade
            // 
            this.txt_uf_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_uf_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uf_cidade.Location = new System.Drawing.Point(8, 108);
            this.txt_uf_cidade.MaxLength = 2;
            this.txt_uf_cidade.Name = "txt_uf_cidade";
            this.txt_uf_cidade.Size = new System.Drawing.Size(170, 26);
            this.txt_uf_cidade.TabIndex = 29;
            // 
            // lbl_uf_cidade
            // 
            this.lbl_uf_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_uf_cidade.AutoSize = true;
            this.lbl_uf_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uf_cidade.Location = new System.Drawing.Point(4, 87);
            this.lbl_uf_cidade.Name = "lbl_uf_cidade";
            this.lbl_uf_cidade.Size = new System.Drawing.Size(50, 19);
            this.lbl_uf_cidade.TabIndex = 28;
            this.lbl_uf_cidade.Text = "C.P.F.";
            // 
            // txt_nome_cidade
            // 
            this.txt_nome_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_cidade.Location = new System.Drawing.Point(114, 40);
            this.txt_nome_cidade.Name = "txt_nome_cidade";
            this.txt_nome_cidade.Size = new System.Drawing.Size(376, 26);
            this.txt_nome_cidade.TabIndex = 27;
            // 
            // txt_codigo_cidade
            // 
            this.txt_codigo_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigo_cidade.Enabled = false;
            this.txt_codigo_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_cidade.Location = new System.Drawing.Point(8, 40);
            this.txt_codigo_cidade.Name = "txt_codigo_cidade";
            this.txt_codigo_cidade.Size = new System.Drawing.Size(100, 26);
            this.txt_codigo_cidade.TabIndex = 26;
            this.txt_codigo_cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nome_cidade
            // 
            this.lbl_nome_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome_cidade.AutoSize = true;
            this.lbl_nome_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_cidade.Location = new System.Drawing.Point(111, 19);
            this.lbl_nome_cidade.Name = "lbl_nome_cidade";
            this.lbl_nome_cidade.Size = new System.Drawing.Size(138, 19);
            this.lbl_nome_cidade.TabIndex = 25;
            this.lbl_nome_cidade.Text = "Nome Completo:";
            // 
            // lbl_codigo_cidade
            // 
            this.lbl_codigo_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_codigo_cidade.AutoSize = true;
            this.lbl_codigo_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_cidade.Location = new System.Drawing.Point(8, 19);
            this.lbl_codigo_cidade.Name = "lbl_codigo_cidade";
            this.lbl_codigo_cidade.Size = new System.Drawing.Size(71, 19);
            this.lbl_codigo_cidade.TabIndex = 24;
            this.lbl_codigo_cidade.Text = "Código:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(496, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 26);
            this.textBox1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "E-mail:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(184, 108);
            this.textBox2.MaxLength = 2;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 26);
            this.textBox2.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Telefone:";
            // 
            // dtpicker_data_nascimento
            // 
            this.dtpicker_data_nascimento.CalendarFont = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_data_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker_data_nascimento.Location = new System.Drawing.Point(342, 109);
            this.dtpicker_data_nascimento.Name = "dtpicker_data_nascimento";
            this.dtpicker_data_nascimento.Size = new System.Drawing.Size(451, 20);
            this.dtpicker_data_nascimento.TabIndex = 40;
            this.dtpicker_data_nascimento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Data de Nascimento:";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpicker_data_nascimento);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_buscar_cidades);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.txt_uf_cidade);
            this.Controls.Add(this.lbl_uf_cidade);
            this.Controls.Add(this.txt_nome_cidade);
            this.Controls.Add(this.txt_codigo_cidade);
            this.Controls.Add(this.lbl_nome_cidade);
            this.Controls.Add(this.lbl_codigo_cidade);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.grp_buscar_cidades.ResumeLayout(false);
            this.grp_buscar_cidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_buscar_cidades;
        private System.Windows.Forms.TextBox txt_pesquisar_nome;
        private System.Windows.Forms.Label lbl_pesquisar_nome;
        private System.Windows.Forms.TextBox txt_pesquisar_unidade_federal;
        private System.Windows.Forms.Label lbl_pesquisar_unidade_federal;
        private System.Windows.Forms.DataGridView dgv_registros;
        private System.Windows.Forms.TextBox txt_pesquisar_id;
        private System.Windows.Forms.Label lbl_pesquisar_id;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.TextBox txt_uf_cidade;
        private System.Windows.Forms.Label lbl_uf_cidade;
        private System.Windows.Forms.TextBox txt_nome_cidade;
        private System.Windows.Forms.TextBox txt_codigo_cidade;
        private System.Windows.Forms.Label lbl_nome_cidade;
        private System.Windows.Forms.Label lbl_codigo_cidade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpicker_data_nascimento;
        private System.Windows.Forms.Label label3;
    }
}