namespace Aplicativo_NET_Framawork_13.View
{
    partial class FrmProduto
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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.txt_nome_produto = new System.Windows.Forms.TextBox();
            this.txt_codigo_produto = new System.Windows.Forms.TextBox();
            this.lbl_nome_produto = new System.Windows.Forms.Label();
            this.lbl_codigo_produto = new System.Windows.Forms.Label();
            this.txt_fornecedor_produto = new System.Windows.Forms.TextBox();
            this.lbl_marca_produto = new System.Windows.Forms.Label();
            this.lbl_fornecedor_produto = new System.Windows.Forms.Label();
            this.pctbox_foto_produto = new System.Windows.Forms.PictureBox();
            this.cb_marca_produto = new System.Windows.Forms.ComboBox();
            this.cb_categoria_produto = new System.Windows.Forms.ComboBox();
            this.lbl_categoria_produto = new System.Windows.Forms.Label();
            this.grp_buscar_clientes = new System.Windows.Forms.GroupBox();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.dgv_registros = new System.Windows.Forms.DataGridView();
            this.ofd_foto_produto = new System.Windows.Forms.OpenFileDialog();
            this.lbl_estoque_produto = new System.Windows.Forms.Label();
            this.nud_estoque_produto = new System.Windows.Forms.NumericUpDown();
            this.txt_preco_de_venda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_foto_produto)).BeginInit();
            this.grp_buscar_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_estoque_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fechar.BackColor = System.Drawing.Color.Black;
            this.btn_fechar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(643, 221);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(152, 71);
            this.btn_fechar.TabIndex = 54;
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
            this.btn_excluir.Location = new System.Drawing.Point(484, 221);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(152, 71);
            this.btn_excluir.TabIndex = 53;
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
            this.btn_cancelar.Location = new System.Drawing.Point(326, 221);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(152, 71);
            this.btn_cancelar.TabIndex = 52;
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
            this.btn_alterar.Location = new System.Drawing.Point(168, 221);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(152, 71);
            this.btn_alterar.TabIndex = 51;
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
            this.btn_incluir.Location = new System.Drawing.Point(10, 221);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(152, 71);
            this.btn_incluir.TabIndex = 50;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = false;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // txt_nome_produto
            // 
            this.txt_nome_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_produto.Location = new System.Drawing.Point(116, 46);
            this.txt_nome_produto.Name = "txt_nome_produto";
            this.txt_nome_produto.Size = new System.Drawing.Size(502, 26);
            this.txt_nome_produto.TabIndex = 49;
            // 
            // txt_codigo_produto
            // 
            this.txt_codigo_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigo_produto.Enabled = false;
            this.txt_codigo_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_produto.Location = new System.Drawing.Point(10, 46);
            this.txt_codigo_produto.Name = "txt_codigo_produto";
            this.txt_codigo_produto.Size = new System.Drawing.Size(100, 26);
            this.txt_codigo_produto.TabIndex = 48;
            this.txt_codigo_produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nome_produto
            // 
            this.lbl_nome_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome_produto.AutoSize = true;
            this.lbl_nome_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_produto.Location = new System.Drawing.Point(113, 25);
            this.lbl_nome_produto.Name = "lbl_nome_produto";
            this.lbl_nome_produto.Size = new System.Drawing.Size(77, 19);
            this.lbl_nome_produto.TabIndex = 47;
            this.lbl_nome_produto.Text = "Produto:";
            // 
            // lbl_codigo_produto
            // 
            this.lbl_codigo_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_codigo_produto.AutoSize = true;
            this.lbl_codigo_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_produto.Location = new System.Drawing.Point(6, 25);
            this.lbl_codigo_produto.Name = "lbl_codigo_produto";
            this.lbl_codigo_produto.Size = new System.Drawing.Size(71, 19);
            this.lbl_codigo_produto.TabIndex = 46;
            this.lbl_codigo_produto.Text = "Código:";
            // 
            // txt_fornecedor_produto
            // 
            this.txt_fornecedor_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fornecedor_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fornecedor_produto.Location = new System.Drawing.Point(10, 111);
            this.txt_fornecedor_produto.Name = "txt_fornecedor_produto";
            this.txt_fornecedor_produto.Size = new System.Drawing.Size(258, 26);
            this.txt_fornecedor_produto.TabIndex = 58;
            // 
            // lbl_marca_produto
            // 
            this.lbl_marca_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_marca_produto.AutoSize = true;
            this.lbl_marca_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca_produto.Location = new System.Drawing.Point(305, 154);
            this.lbl_marca_produto.Name = "lbl_marca_produto";
            this.lbl_marca_produto.Size = new System.Drawing.Size(61, 19);
            this.lbl_marca_produto.TabIndex = 57;
            this.lbl_marca_produto.Text = "Marca:";
            // 
            // lbl_fornecedor_produto
            // 
            this.lbl_fornecedor_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fornecedor_produto.AutoSize = true;
            this.lbl_fornecedor_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fornecedor_produto.Location = new System.Drawing.Point(6, 90);
            this.lbl_fornecedor_produto.Name = "lbl_fornecedor_produto";
            this.lbl_fornecedor_produto.Size = new System.Drawing.Size(104, 19);
            this.lbl_fornecedor_produto.TabIndex = 56;
            this.lbl_fornecedor_produto.Text = "Fornecedor:";
            // 
            // pctbox_foto_produto
            // 
            this.pctbox_foto_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbox_foto_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctbox_foto_produto.Location = new System.Drawing.Point(642, 12);
            this.pctbox_foto_produto.Name = "pctbox_foto_produto";
            this.pctbox_foto_produto.Size = new System.Drawing.Size(151, 190);
            this.pctbox_foto_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbox_foto_produto.TabIndex = 60;
            this.pctbox_foto_produto.TabStop = false;
            this.pctbox_foto_produto.Click += new System.EventHandler(this.pctbox_foto_produto_Click);
            // 
            // cb_marca_produto
            // 
            this.cb_marca_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_marca_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_marca_produto.FormattingEnabled = true;
            this.cb_marca_produto.Location = new System.Drawing.Point(309, 176);
            this.cb_marca_produto.Name = "cb_marca_produto";
            this.cb_marca_produto.Size = new System.Drawing.Size(309, 26);
            this.cb_marca_produto.TabIndex = 61;
            // 
            // cb_categoria_produto
            // 
            this.cb_categoria_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_categoria_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categoria_produto.FormattingEnabled = true;
            this.cb_categoria_produto.Location = new System.Drawing.Point(11, 176);
            this.cb_categoria_produto.Name = "cb_categoria_produto";
            this.cb_categoria_produto.Size = new System.Drawing.Size(292, 26);
            this.cb_categoria_produto.TabIndex = 63;
            // 
            // lbl_categoria_produto
            // 
            this.lbl_categoria_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_categoria_produto.AutoSize = true;
            this.lbl_categoria_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria_produto.Location = new System.Drawing.Point(7, 154);
            this.lbl_categoria_produto.Name = "lbl_categoria_produto";
            this.lbl_categoria_produto.Size = new System.Drawing.Size(89, 19);
            this.lbl_categoria_produto.TabIndex = 62;
            this.lbl_categoria_produto.Text = "Categoria:";
            // 
            // grp_buscar_clientes
            // 
            this.grp_buscar_clientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_buscar_clientes.Controls.Add(this.btn_resetar);
            this.grp_buscar_clientes.Controls.Add(this.btn_pesquisar);
            this.grp_buscar_clientes.Controls.Add(this.dgv_registros);
            this.grp_buscar_clientes.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_buscar_clientes.Location = new System.Drawing.Point(11, 313);
            this.grp_buscar_clientes.Name = "grp_buscar_clientes";
            this.grp_buscar_clientes.Size = new System.Drawing.Size(785, 261);
            this.grp_buscar_clientes.TabIndex = 64;
            this.grp_buscar_clientes.TabStop = false;
            this.grp_buscar_clientes.Text = "Pesquisar:";
            // 
            // btn_resetar
            // 
            this.btn_resetar.BackColor = System.Drawing.Color.Magenta;
            this.btn_resetar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_resetar.ForeColor = System.Drawing.Color.White;
            this.btn_resetar.Location = new System.Drawing.Point(549, 22);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(104, 26);
            this.btn_resetar.TabIndex = 52;
            this.btn_resetar.Text = "Resetar";
            this.btn_resetar.UseVisualStyleBackColor = false;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.Purple;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.Location = new System.Drawing.Point(650, 22);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(108, 26);
            this.btn_pesquisar.TabIndex = 51;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // dgv_registros
            // 
            this.dgv_registros.AllowUserToAddRows = false;
            this.dgv_registros.AllowUserToDeleteRows = false;
            this.dgv_registros.AllowUserToOrderColumns = true;
            this.dgv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registros.Location = new System.Drawing.Point(26, 48);
            this.dgv_registros.Name = "dgv_registros";
            this.dgv_registros.ReadOnly = true;
            this.dgv_registros.Size = new System.Drawing.Size(732, 201);
            this.dgv_registros.TabIndex = 5;
            this.dgv_registros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_registros_CellDoubleClick);
            this.dgv_registros.Click += new System.EventHandler(this.dgv_registros_Click);
            // 
            // lbl_estoque_produto
            // 
            this.lbl_estoque_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_estoque_produto.AutoSize = true;
            this.lbl_estoque_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estoque_produto.Location = new System.Drawing.Point(490, 90);
            this.lbl_estoque_produto.Name = "lbl_estoque_produto";
            this.lbl_estoque_produto.Size = new System.Drawing.Size(79, 19);
            this.lbl_estoque_produto.TabIndex = 65;
            this.lbl_estoque_produto.Text = "Estoque:";
            // 
            // nud_estoque_produto
            // 
            this.nud_estoque_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_estoque_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_estoque_produto.Location = new System.Drawing.Point(494, 112);
            this.nud_estoque_produto.Name = "nud_estoque_produto";
            this.nud_estoque_produto.Size = new System.Drawing.Size(124, 26);
            this.nud_estoque_produto.TabIndex = 67;
            // 
            // txt_preco_de_venda
            // 
            this.txt_preco_de_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_preco_de_venda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preco_de_venda.Location = new System.Drawing.Point(274, 111);
            this.txt_preco_de_venda.Name = "txt_preco_de_venda";
            this.txt_preco_de_venda.Size = new System.Drawing.Size(214, 26);
            this.txt_preco_de_venda.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Preço de Venda:";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.ControlBox = false;
            this.Controls.Add(this.txt_preco_de_venda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_estoque_produto);
            this.Controls.Add(this.lbl_estoque_produto);
            this.Controls.Add(this.grp_buscar_clientes);
            this.Controls.Add(this.cb_categoria_produto);
            this.Controls.Add(this.lbl_categoria_produto);
            this.Controls.Add(this.cb_marca_produto);
            this.Controls.Add(this.pctbox_foto_produto);
            this.Controls.Add(this.txt_fornecedor_produto);
            this.Controls.Add(this.lbl_marca_produto);
            this.Controls.Add(this.lbl_fornecedor_produto);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.txt_nome_produto);
            this.Controls.Add(this.txt_codigo_produto);
            this.Controls.Add(this.lbl_nome_produto);
            this.Controls.Add(this.lbl_codigo_produto);
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_foto_produto)).EndInit();
            this.grp_buscar_clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_estoque_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.TextBox txt_nome_produto;
        private System.Windows.Forms.TextBox txt_codigo_produto;
        private System.Windows.Forms.Label lbl_nome_produto;
        private System.Windows.Forms.Label lbl_codigo_produto;
        private System.Windows.Forms.TextBox txt_fornecedor_produto;
        private System.Windows.Forms.Label lbl_marca_produto;
        private System.Windows.Forms.Label lbl_fornecedor_produto;
        private System.Windows.Forms.PictureBox pctbox_foto_produto;
        private System.Windows.Forms.ComboBox cb_marca_produto;
        private System.Windows.Forms.ComboBox cb_categoria_produto;
        private System.Windows.Forms.Label lbl_categoria_produto;
        private System.Windows.Forms.GroupBox grp_buscar_clientes;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DataGridView dgv_registros;
        private System.Windows.Forms.OpenFileDialog ofd_foto_produto;
        private System.Windows.Forms.Label lbl_estoque_produto;
        private System.Windows.Forms.NumericUpDown nud_estoque_produto;
        private System.Windows.Forms.TextBox txt_preco_de_venda;
        private System.Windows.Forms.Label label1;
    }
}