﻿namespace Aplicativo_NET_Framawork_13.View
{
    partial class FrmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.grp_buscar_alterar_categorias = new System.Windows.Forms.GroupBox();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_pesquisar_nome = new System.Windows.Forms.TextBox();
            this.lbl_pesquisar_nome = new System.Windows.Forms.Label();
            this.dgv_registros = new System.Windows.Forms.DataGridView();
            this.txt_pesquisar_id = new System.Windows.Forms.TextBox();
            this.lbl_pesquisar_id = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.txt_nome_categoria = new System.Windows.Forms.TextBox();
            this.txt_codigo_categoria = new System.Windows.Forms.TextBox();
            this.lbl_nome_categoria = new System.Windows.Forms.Label();
            this.lbl_codigo_categoria = new System.Windows.Forms.Label();
            this.grp_buscar_alterar_categorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_buscar_alterar_categorias
            // 
            this.grp_buscar_alterar_categorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_buscar_alterar_categorias.Controls.Add(this.btn_resetar);
            this.grp_buscar_alterar_categorias.Controls.Add(this.btn_pesquisar);
            this.grp_buscar_alterar_categorias.Controls.Add(this.txt_pesquisar_nome);
            this.grp_buscar_alterar_categorias.Controls.Add(this.lbl_pesquisar_nome);
            this.grp_buscar_alterar_categorias.Controls.Add(this.dgv_registros);
            this.grp_buscar_alterar_categorias.Controls.Add(this.txt_pesquisar_id);
            this.grp_buscar_alterar_categorias.Controls.Add(this.lbl_pesquisar_id);
            this.grp_buscar_alterar_categorias.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_buscar_alterar_categorias.Location = new System.Drawing.Point(10, 172);
            this.grp_buscar_alterar_categorias.Name = "grp_buscar_alterar_categorias";
            this.grp_buscar_alterar_categorias.Size = new System.Drawing.Size(785, 261);
            this.grp_buscar_alterar_categorias.TabIndex = 35;
            this.grp_buscar_alterar_categorias.TabStop = false;
            this.grp_buscar_alterar_categorias.Text = "Alterar / Pesquisar:";
            // 
            // btn_resetar
            // 
            this.btn_resetar.BackColor = System.Drawing.Color.Magenta;
            this.btn_resetar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_resetar.ForeColor = System.Drawing.Color.White;
            this.btn_resetar.Location = new System.Drawing.Point(658, 57);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(100, 31);
            this.btn_resetar.TabIndex = 11;
            this.btn_resetar.Text = "Resetar";
            this.btn_resetar.UseVisualStyleBackColor = false;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
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
            this.txt_pesquisar_nome.Location = new System.Drawing.Point(29, 167);
            this.txt_pesquisar_nome.Name = "txt_pesquisar_nome";
            this.txt_pesquisar_nome.Size = new System.Drawing.Size(100, 26);
            this.txt_pesquisar_nome.TabIndex = 9;
            // 
            // lbl_pesquisar_nome
            // 
            this.lbl_pesquisar_nome.AutoSize = true;
            this.lbl_pesquisar_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisar_nome.Location = new System.Drawing.Point(25, 145);
            this.lbl_pesquisar_nome.Name = "lbl_pesquisar_nome";
            this.lbl_pesquisar_nome.Size = new System.Drawing.Size(60, 19);
            this.lbl_pesquisar_nome.TabIndex = 8;
            this.lbl_pesquisar_nome.Text = "Nome:";
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
            this.txt_pesquisar_id.Location = new System.Drawing.Point(29, 91);
            this.txt_pesquisar_id.Name = "txt_pesquisar_id";
            this.txt_pesquisar_id.Size = new System.Drawing.Size(100, 26);
            this.txt_pesquisar_id.TabIndex = 4;
            // 
            // lbl_pesquisar_id
            // 
            this.lbl_pesquisar_id.AutoSize = true;
            this.lbl_pesquisar_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisar_id.Location = new System.Drawing.Point(25, 69);
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
            this.btn_fechar.Location = new System.Drawing.Point(643, 82);
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
            this.btn_excluir.Location = new System.Drawing.Point(484, 82);
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
            this.btn_cancelar.Location = new System.Drawing.Point(326, 82);
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
            this.btn_alterar.Location = new System.Drawing.Point(168, 82);
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
            this.btn_incluir.Location = new System.Drawing.Point(10, 82);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(152, 71);
            this.btn_incluir.TabIndex = 30;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = false;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // txt_nome_categoria
            // 
            this.txt_nome_categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome_categoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_categoria.Location = new System.Drawing.Point(136, 39);
            this.txt_nome_categoria.Name = "txt_nome_categoria";
            this.txt_nome_categoria.Size = new System.Drawing.Size(659, 26);
            this.txt_nome_categoria.TabIndex = 27;
            // 
            // txt_codigo_categoria
            // 
            this.txt_codigo_categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigo_categoria.Enabled = false;
            this.txt_codigo_categoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_categoria.Location = new System.Drawing.Point(10, 39);
            this.txt_codigo_categoria.Name = "txt_codigo_categoria";
            this.txt_codigo_categoria.Size = new System.Drawing.Size(100, 26);
            this.txt_codigo_categoria.TabIndex = 26;
            this.txt_codigo_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nome_categoria
            // 
            this.lbl_nome_categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome_categoria.AutoSize = true;
            this.lbl_nome_categoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_categoria.Location = new System.Drawing.Point(133, 18);
            this.lbl_nome_categoria.Name = "lbl_nome_categoria";
            this.lbl_nome_categoria.Size = new System.Drawing.Size(89, 19);
            this.lbl_nome_categoria.TabIndex = 25;
            this.lbl_nome_categoria.Text = "Categoria:";
            // 
            // lbl_codigo_categoria
            // 
            this.lbl_codigo_categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_codigo_categoria.AutoSize = true;
            this.lbl_codigo_categoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_categoria.Location = new System.Drawing.Point(6, 18);
            this.lbl_codigo_categoria.Name = "lbl_codigo_categoria";
            this.lbl_codigo_categoria.Size = new System.Drawing.Size(71, 19);
            this.lbl_codigo_categoria.TabIndex = 24;
            this.lbl_codigo_categoria.Text = "Código:";
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grp_buscar_alterar_categorias);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.txt_nome_categoria);
            this.Controls.Add(this.txt_codigo_categoria);
            this.Controls.Add(this.lbl_nome_categoria);
            this.Controls.Add(this.lbl_codigo_categoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.grp_buscar_alterar_categorias.ResumeLayout(false);
            this.grp_buscar_alterar_categorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_buscar_alterar_categorias;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DataGridView dgv_registros;
        private System.Windows.Forms.TextBox txt_pesquisar_id;
        private System.Windows.Forms.Label lbl_pesquisar_id;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.TextBox txt_nome_categoria;
        private System.Windows.Forms.TextBox txt_codigo_categoria;
        private System.Windows.Forms.Label lbl_nome_categoria;
        private System.Windows.Forms.Label lbl_codigo_categoria;
        private System.Windows.Forms.TextBox txt_pesquisar_nome;
        private System.Windows.Forms.Label lbl_pesquisar_nome;
        private System.Windows.Forms.Button btn_resetar;
    }
}