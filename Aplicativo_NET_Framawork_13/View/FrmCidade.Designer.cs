namespace Aplicativo_NET_Framawork_13.View
{
    partial class FrmCidade
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
            this.grp_buscar_alterar_cidades = new System.Windows.Forms.GroupBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
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
            this.grp_buscar_alterar_cidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_buscar_alterar_cidades
            // 
            this.grp_buscar_alterar_cidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_buscar_alterar_cidades.Controls.Add(this.btn_pesquisar);
            this.grp_buscar_alterar_cidades.Controls.Add(this.txt_pesquisar_nome);
            this.grp_buscar_alterar_cidades.Controls.Add(this.lbl_pesquisar_nome);
            this.grp_buscar_alterar_cidades.Controls.Add(this.txt_pesquisar_unidade_federal);
            this.grp_buscar_alterar_cidades.Controls.Add(this.lbl_pesquisar_unidade_federal);
            this.grp_buscar_alterar_cidades.Controls.Add(this.dgv_registros);
            this.grp_buscar_alterar_cidades.Controls.Add(this.txt_pesquisar_id);
            this.grp_buscar_alterar_cidades.Controls.Add(this.lbl_pesquisar_id);
            this.grp_buscar_alterar_cidades.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_buscar_alterar_cidades.Location = new System.Drawing.Point(8, 172);
            this.grp_buscar_alterar_cidades.Name = "grp_buscar_alterar_cidades";
            this.grp_buscar_alterar_cidades.Size = new System.Drawing.Size(785, 261);
            this.grp_buscar_alterar_cidades.TabIndex = 23;
            this.grp_buscar_alterar_cidades.TabStop = false;
            this.grp_buscar_alterar_cidades.Text = "Alterar / Pesquisar:";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.Purple;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.Location = new System.Drawing.Point(658, 26);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(100, 31);
            this.btn_pesquisar.TabIndex = 10;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // txt_pesquisar_nome
            // 
            this.txt_pesquisar_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar_nome.Location = new System.Drawing.Point(27, 124);
            this.txt_pesquisar_nome.Name = "txt_pesquisar_nome";
            this.txt_pesquisar_nome.Size = new System.Drawing.Size(100, 26);
            this.txt_pesquisar_nome.TabIndex = 9;
            this.txt_pesquisar_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pesquisar_nome_KeyPress);
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
            this.dgv_registros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_registros_CellDoubleClick);
            this.dgv_registros.Click += new System.EventHandler(this.dgv_registros_Click);
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
            this.btn_fechar.Location = new System.Drawing.Point(641, 82);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(152, 71);
            this.btn_fechar.TabIndex = 22;
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
            this.btn_excluir.Location = new System.Drawing.Point(482, 82);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(152, 71);
            this.btn_excluir.TabIndex = 21;
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
            this.btn_cancelar.Location = new System.Drawing.Point(324, 82);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(152, 71);
            this.btn_cancelar.TabIndex = 20;
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
            this.btn_alterar.Location = new System.Drawing.Point(166, 82);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(152, 71);
            this.btn_alterar.TabIndex = 19;
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
            this.btn_incluir.Location = new System.Drawing.Point(8, 82);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(152, 71);
            this.btn_incluir.TabIndex = 18;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = false;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // txt_uf_cidade
            // 
            this.txt_uf_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_uf_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uf_cidade.Location = new System.Drawing.Point(684, 39);
            this.txt_uf_cidade.MaxLength = 2;
            this.txt_uf_cidade.Name = "txt_uf_cidade";
            this.txt_uf_cidade.Size = new System.Drawing.Size(109, 26);
            this.txt_uf_cidade.TabIndex = 17;
            // 
            // lbl_uf_cidade
            // 
            this.lbl_uf_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_uf_cidade.AutoSize = true;
            this.lbl_uf_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uf_cidade.Location = new System.Drawing.Point(681, 18);
            this.lbl_uf_cidade.Name = "lbl_uf_cidade";
            this.lbl_uf_cidade.Size = new System.Drawing.Size(37, 19);
            this.lbl_uf_cidade.TabIndex = 16;
            this.lbl_uf_cidade.Text = "U.F.";
            // 
            // txt_nome_cidade
            // 
            this.txt_nome_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_cidade.Location = new System.Drawing.Point(134, 39);
            this.txt_nome_cidade.Name = "txt_nome_cidade";
            this.txt_nome_cidade.Size = new System.Drawing.Size(527, 26);
            this.txt_nome_cidade.TabIndex = 15;
            // 
            // txt_codigo_cidade
            // 
            this.txt_codigo_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigo_cidade.Enabled = false;
            this.txt_codigo_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_cidade.Location = new System.Drawing.Point(8, 39);
            this.txt_codigo_cidade.Name = "txt_codigo_cidade";
            this.txt_codigo_cidade.Size = new System.Drawing.Size(100, 26);
            this.txt_codigo_cidade.TabIndex = 14;
            this.txt_codigo_cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nome_cidade
            // 
            this.lbl_nome_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome_cidade.AutoSize = true;
            this.lbl_nome_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_cidade.Location = new System.Drawing.Point(131, 18);
            this.lbl_nome_cidade.Name = "lbl_nome_cidade";
            this.lbl_nome_cidade.Size = new System.Drawing.Size(69, 19);
            this.lbl_nome_cidade.TabIndex = 13;
            this.lbl_nome_cidade.Text = "Cidade:";
            // 
            // lbl_codigo_cidade
            // 
            this.lbl_codigo_cidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_codigo_cidade.AutoSize = true;
            this.lbl_codigo_cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_cidade.Location = new System.Drawing.Point(4, 18);
            this.lbl_codigo_cidade.Name = "lbl_codigo_cidade";
            this.lbl_codigo_cidade.Size = new System.Drawing.Size(71, 19);
            this.lbl_codigo_cidade.TabIndex = 12;
            this.lbl_codigo_cidade.Text = "Código:";
            // 
            // FrmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grp_buscar_alterar_cidades);
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
            this.Name = "FrmCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCidade_Load);
            this.grp_buscar_alterar_cidades.ResumeLayout(false);
            this.grp_buscar_alterar_cidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_buscar_alterar_cidades;
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
        private System.Windows.Forms.TextBox txt_pesquisar_unidade_federal;
        private System.Windows.Forms.Label lbl_pesquisar_unidade_federal;
        private System.Windows.Forms.TextBox txt_pesquisar_nome;
        private System.Windows.Forms.Label lbl_pesquisar_nome;
        private System.Windows.Forms.Button btn_pesquisar;
    }
}