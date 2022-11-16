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
            this.grp_buscar_alterar_clientes = new System.Windows.Forms.GroupBox();
            this.txt_pesquisar_nome = new System.Windows.Forms.TextBox();
            this.lbl_pesquisar_nome = new System.Windows.Forms.Label();
            this.txt_pesquisar_cpf = new System.Windows.Forms.TextBox();
            this.lbl_pesquisar_cpf = new System.Windows.Forms.Label();
            this.dgv_registros = new System.Windows.Forms.DataGridView();
            this.txt_pesquisar_id = new System.Windows.Forms.TextBox();
            this.lbl_pesquisar_id = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.lbl_cpf_cliente = new System.Windows.Forms.Label();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.txt_codigo_cliente = new System.Windows.Forms.TextBox();
            this.lbl_nome_cliente = new System.Windows.Forms.Label();
            this.lbl_codigo_cliente = new System.Windows.Forms.Label();
            this.txt_email_cliente = new System.Windows.Forms.TextBox();
            this.lbl_email_cliente = new System.Windows.Forms.Label();
            this.txt_telefone_cliente = new System.Windows.Forms.TextBox();
            this.lbl_telefone_cliente = new System.Windows.Forms.Label();
            this.dtpicker_data_nascimento_cliente = new System.Windows.Forms.DateTimePicker();
            this.lbl_data_nascimento_cliente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_renda = new System.Windows.Forms.TextBox();
            this.lbl_renda = new System.Windows.Forms.Label();
            this.cb_cidade = new System.Windows.Forms.ComboBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_unidade_federal = new System.Windows.Forms.TextBox();
            this.lbl_unidade_federal = new System.Windows.Forms.Label();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.grp_buscar_alterar_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_buscar_alterar_clientes
            // 
            this.grp_buscar_alterar_clientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_buscar_alterar_clientes.Controls.Add(this.txt_pesquisar_nome);
            this.grp_buscar_alterar_clientes.Controls.Add(this.lbl_pesquisar_nome);
            this.grp_buscar_alterar_clientes.Controls.Add(this.txt_pesquisar_cpf);
            this.grp_buscar_alterar_clientes.Controls.Add(this.lbl_pesquisar_cpf);
            this.grp_buscar_alterar_clientes.Controls.Add(this.dgv_registros);
            this.grp_buscar_alterar_clientes.Controls.Add(this.txt_pesquisar_id);
            this.grp_buscar_alterar_clientes.Controls.Add(this.lbl_pesquisar_id);
            this.grp_buscar_alterar_clientes.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_buscar_alterar_clientes.Location = new System.Drawing.Point(7, 451);
            this.grp_buscar_alterar_clientes.Name = "grp_buscar_alterar_clientes";
            this.grp_buscar_alterar_clientes.Size = new System.Drawing.Size(785, 261);
            this.grp_buscar_alterar_clientes.TabIndex = 35;
            this.grp_buscar_alterar_clientes.TabStop = false;
            this.grp_buscar_alterar_clientes.Text = "Alterar / Pesquisar:";
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
            // txt_pesquisar_cpf
            // 
            this.txt_pesquisar_cpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar_cpf.Location = new System.Drawing.Point(27, 208);
            this.txt_pesquisar_cpf.MaxLength = 2;
            this.txt_pesquisar_cpf.Name = "txt_pesquisar_cpf";
            this.txt_pesquisar_cpf.Size = new System.Drawing.Size(100, 26);
            this.txt_pesquisar_cpf.TabIndex = 7;
            // 
            // lbl_pesquisar_cpf
            // 
            this.lbl_pesquisar_cpf.AutoSize = true;
            this.lbl_pesquisar_cpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisar_cpf.Location = new System.Drawing.Point(23, 186);
            this.lbl_pesquisar_cpf.Name = "lbl_pesquisar_cpf";
            this.lbl_pesquisar_cpf.Size = new System.Drawing.Size(50, 19);
            this.lbl_pesquisar_cpf.TabIndex = 6;
            this.lbl_pesquisar_cpf.Text = "C.P.F.";
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
            this.btn_fechar.Location = new System.Drawing.Point(640, 361);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(152, 71);
            this.btn_fechar.TabIndex = 34;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_excluir.BackColor = System.Drawing.Color.Red;
            this.btn_excluir.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(481, 361);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(152, 71);
            this.btn_excluir.TabIndex = 33;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(323, 361);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(152, 71);
            this.btn_cancelar.TabIndex = 32;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_alterar.BackColor = System.Drawing.Color.Blue;
            this.btn_alterar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(165, 361);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(152, 71);
            this.btn_alterar.TabIndex = 31;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_incluir.BackColor = System.Drawing.Color.Green;
            this.btn_incluir.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incluir.ForeColor = System.Drawing.Color.White;
            this.btn_incluir.Location = new System.Drawing.Point(7, 361);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(152, 71);
            this.btn_incluir.TabIndex = 30;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = false;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // lbl_cpf_cliente
            // 
            this.lbl_cpf_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_cpf_cliente.AutoSize = true;
            this.lbl_cpf_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf_cliente.Location = new System.Drawing.Point(4, 170);
            this.lbl_cpf_cliente.Name = "lbl_cpf_cliente";
            this.lbl_cpf_cliente.Size = new System.Drawing.Size(50, 19);
            this.lbl_cpf_cliente.TabIndex = 28;
            this.lbl_cpf_cliente.Text = "C.P.F.";
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_cliente.Location = new System.Drawing.Point(116, 43);
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(437, 26);
            this.txt_nome_cliente.TabIndex = 27;
            // 
            // txt_codigo_cliente
            // 
            this.txt_codigo_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigo_cliente.Enabled = false;
            this.txt_codigo_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_cliente.Location = new System.Drawing.Point(7, 43);
            this.txt_codigo_cliente.Name = "txt_codigo_cliente";
            this.txt_codigo_cliente.Size = new System.Drawing.Size(100, 26);
            this.txt_codigo_cliente.TabIndex = 26;
            this.txt_codigo_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nome_cliente
            // 
            this.lbl_nome_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome_cliente.AutoSize = true;
            this.lbl_nome_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_cliente.Location = new System.Drawing.Point(113, 22);
            this.lbl_nome_cliente.Name = "lbl_nome_cliente";
            this.lbl_nome_cliente.Size = new System.Drawing.Size(138, 19);
            this.lbl_nome_cliente.TabIndex = 25;
            this.lbl_nome_cliente.Text = "Nome Completo:";
            // 
            // lbl_codigo_cliente
            // 
            this.lbl_codigo_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_codigo_cliente.AutoSize = true;
            this.lbl_codigo_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_cliente.Location = new System.Drawing.Point(4, 21);
            this.lbl_codigo_cliente.Name = "lbl_codigo_cliente";
            this.lbl_codigo_cliente.Size = new System.Drawing.Size(71, 19);
            this.lbl_codigo_cliente.TabIndex = 24;
            this.lbl_codigo_cliente.Text = "Código:";
            // 
            // txt_email_cliente
            // 
            this.txt_email_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_cliente.Location = new System.Drawing.Point(8, 116);
            this.txt_email_cliente.Name = "txt_email_cliente";
            this.txt_email_cliente.Size = new System.Drawing.Size(545, 26);
            this.txt_email_cliente.TabIndex = 37;
            // 
            // lbl_email_cliente
            // 
            this.lbl_email_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email_cliente.AutoSize = true;
            this.lbl_email_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email_cliente.Location = new System.Drawing.Point(4, 95);
            this.lbl_email_cliente.Name = "lbl_email_cliente";
            this.lbl_email_cliente.Size = new System.Drawing.Size(62, 19);
            this.lbl_email_cliente.TabIndex = 36;
            this.lbl_email_cliente.Text = "E-mail:";
            // 
            // txt_telefone_cliente
            // 
            this.txt_telefone_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telefone_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone_cliente.Location = new System.Drawing.Point(236, 191);
            this.txt_telefone_cliente.MaxLength = 2;
            this.txt_telefone_cliente.Name = "txt_telefone_cliente";
            this.txt_telefone_cliente.Size = new System.Drawing.Size(317, 26);
            this.txt_telefone_cliente.TabIndex = 39;
            // 
            // lbl_telefone_cliente
            // 
            this.lbl_telefone_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_telefone_cliente.AutoSize = true;
            this.lbl_telefone_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone_cliente.Location = new System.Drawing.Point(232, 170);
            this.lbl_telefone_cliente.Name = "lbl_telefone_cliente";
            this.lbl_telefone_cliente.Size = new System.Drawing.Size(80, 19);
            this.lbl_telefone_cliente.TabIndex = 38;
            this.lbl_telefone_cliente.Text = "Telefone:";
            // 
            // dtpicker_data_nascimento_cliente
            // 
            this.dtpicker_data_nascimento_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpicker_data_nascimento_cliente.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_data_nascimento_cliente.CustomFormat = "dd/MM/yyyy  HH:mm:ss";
            this.dtpicker_data_nascimento_cliente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_data_nascimento_cliente.Location = new System.Drawing.Point(7, 320);
            this.dtpicker_data_nascimento_cliente.Name = "dtpicker_data_nascimento_cliente";
            this.dtpicker_data_nascimento_cliente.Size = new System.Drawing.Size(546, 20);
            this.dtpicker_data_nascimento_cliente.TabIndex = 40;
            // 
            // lbl_data_nascimento_cliente
            // 
            this.lbl_data_nascimento_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_data_nascimento_cliente.AutoSize = true;
            this.lbl_data_nascimento_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_nascimento_cliente.Location = new System.Drawing.Point(3, 298);
            this.lbl_data_nascimento_cliente.Name = "lbl_data_nascimento_cliente";
            this.lbl_data_nascimento_cliente.Size = new System.Drawing.Size(168, 19);
            this.lbl_data_nascimento_cliente.TabIndex = 41;
            this.lbl_data_nascimento_cliente.Text = "Data de Nascimento:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(576, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 256);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // txt_renda
            // 
            this.txt_renda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_renda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_renda.Location = new System.Drawing.Point(576, 314);
            this.txt_renda.MaxLength = 2;
            this.txt_renda.Name = "txt_renda";
            this.txt_renda.Size = new System.Drawing.Size(212, 26);
            this.txt_renda.TabIndex = 44;
            // 
            // lbl_renda
            // 
            this.lbl_renda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_renda.AutoSize = true;
            this.lbl_renda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_renda.Location = new System.Drawing.Point(572, 292);
            this.lbl_renda.Name = "lbl_renda";
            this.lbl_renda.Size = new System.Drawing.Size(65, 19);
            this.lbl_renda.TabIndex = 43;
            this.lbl_renda.Text = "Renda:";
            // 
            // cb_cidade
            // 
            this.cb_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cidade.FormattingEnabled = true;
            this.cb_cidade.Location = new System.Drawing.Point(7, 255);
            this.cb_cidade.Name = "cb_cidade";
            this.cb_cidade.Size = new System.Drawing.Size(310, 26);
            this.cb_cidade.TabIndex = 45;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(3, 233);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(69, 19);
            this.lbl_cidade.TabIndex = 46;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // txt_unidade_federal
            // 
            this.txt_unidade_federal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_unidade_federal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidade_federal.Location = new System.Drawing.Point(323, 255);
            this.txt_unidade_federal.MaxLength = 2;
            this.txt_unidade_federal.Name = "txt_unidade_federal";
            this.txt_unidade_federal.Size = new System.Drawing.Size(230, 26);
            this.txt_unidade_federal.TabIndex = 48;
            // 
            // lbl_unidade_federal
            // 
            this.lbl_unidade_federal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_unidade_federal.AutoSize = true;
            this.lbl_unidade_federal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidade_federal.Location = new System.Drawing.Point(319, 234);
            this.lbl_unidade_federal.Name = "lbl_unidade_federal";
            this.lbl_unidade_federal.Size = new System.Drawing.Size(140, 19);
            this.lbl_unidade_federal.TabIndex = 47;
            this.lbl_unidade_federal.Text = "Unidade Federal:";
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_cpf.Location = new System.Drawing.Point(7, 191);
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(223, 26);
            this.mtxt_cpf.TabIndex = 49;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 722);
            this.ControlBox = false;
            this.Controls.Add(this.mtxt_cpf);
            this.Controls.Add(this.txt_unidade_federal);
            this.Controls.Add(this.lbl_unidade_federal);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.cb_cidade);
            this.Controls.Add(this.txt_renda);
            this.Controls.Add(this.lbl_renda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_data_nascimento_cliente);
            this.Controls.Add(this.dtpicker_data_nascimento_cliente);
            this.Controls.Add(this.txt_telefone_cliente);
            this.Controls.Add(this.lbl_telefone_cliente);
            this.Controls.Add(this.txt_email_cliente);
            this.Controls.Add(this.lbl_email_cliente);
            this.Controls.Add(this.grp_buscar_alterar_clientes);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.lbl_cpf_cliente);
            this.Controls.Add(this.txt_nome_cliente);
            this.Controls.Add(this.txt_codigo_cliente);
            this.Controls.Add(this.lbl_nome_cliente);
            this.Controls.Add(this.lbl_codigo_cliente);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.grp_buscar_alterar_clientes.ResumeLayout(false);
            this.grp_buscar_alterar_clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_buscar_alterar_clientes;
        private System.Windows.Forms.TextBox txt_pesquisar_nome;
        private System.Windows.Forms.Label lbl_pesquisar_nome;
        private System.Windows.Forms.TextBox txt_pesquisar_cpf;
        private System.Windows.Forms.Label lbl_pesquisar_cpf;
        private System.Windows.Forms.DataGridView dgv_registros;
        private System.Windows.Forms.TextBox txt_pesquisar_id;
        private System.Windows.Forms.Label lbl_pesquisar_id;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.Label lbl_cpf_cliente;
        private System.Windows.Forms.TextBox txt_nome_cliente;
        private System.Windows.Forms.TextBox txt_codigo_cliente;
        private System.Windows.Forms.Label lbl_nome_cliente;
        private System.Windows.Forms.Label lbl_codigo_cliente;
        private System.Windows.Forms.TextBox txt_email_cliente;
        private System.Windows.Forms.Label lbl_email_cliente;
        private System.Windows.Forms.TextBox txt_telefone_cliente;
        private System.Windows.Forms.Label lbl_telefone_cliente;
        private System.Windows.Forms.DateTimePicker dtpicker_data_nascimento_cliente;
        private System.Windows.Forms.Label lbl_data_nascimento_cliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_renda;
        private System.Windows.Forms.Label lbl_renda;
        private System.Windows.Forms.ComboBox cb_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox txt_unidade_federal;
        private System.Windows.Forms.Label lbl_unidade_federal;
        private System.Windows.Forms.MaskedTextBox mtxt_cpf;
    }
}