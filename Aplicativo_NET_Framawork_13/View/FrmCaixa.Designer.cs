namespace Aplicativo_NET_Framawork_13.View
{
    partial class FrmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixa));
            this.lbl_id_cliente = new System.Windows.Forms.Label();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.lbl_nome_cliente = new System.Windows.Forms.Label();
            this.txt_id_venda = new System.Windows.Forms.TextBox();
            this.lbl_id_venda = new System.Windows.Forms.Label();
            this.txt_valor_venda = new System.Windows.Forms.TextBox();
            this.lbl_valor_venda = new System.Windows.Forms.Label();
            this.rdbtn_dinheiro = new System.Windows.Forms.RadioButton();
            this.rdbtn_cartao_credito = new System.Windows.Forms.RadioButton();
            this.rdbtn_cheque = new System.Windows.Forms.RadioButton();
            this.rdbtn_pix = new System.Windows.Forms.RadioButton();
            this.rdbtn_boleto = new System.Windows.Forms.RadioButton();
            this.pctbox_dinheiro = new System.Windows.Forms.PictureBox();
            this.pctbox_cartao_credito = new System.Windows.Forms.PictureBox();
            this.pctbox_cheque = new System.Windows.Forms.PictureBox();
            this.pctbox_boleto = new System.Windows.Forms.PictureBox();
            this.pctbox_pix = new System.Windows.Forms.PictureBox();
            this.btn_efetuar_alterar_pagamento = new System.Windows.Forms.Button();
            this.txt_dinheiro = new System.Windows.Forms.TextBox();
            this.txt_cartao_credito = new System.Windows.Forms.TextBox();
            this.txt_cheque = new System.Windows.Forms.TextBox();
            this.txt_pix = new System.Windows.Forms.TextBox();
            this.txt_boleto = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_dinheiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_cartao_credito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_cheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_boleto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_pix)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_id_cliente.AutoSize = true;
            this.lbl_id_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_cliente.Location = new System.Drawing.Point(12, 22);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(82, 19);
            this.lbl_id_cliente.TabIndex = 0;
            this.lbl_id_cliente.Text = "ID Cliente";
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id_cliente.Enabled = false;
            this.txt_id_cliente.Location = new System.Drawing.Point(16, 44);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_id_cliente.TabIndex = 4;
            this.txt_id_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome_cliente.Enabled = false;
            this.txt_nome_cliente.Location = new System.Drawing.Point(122, 44);
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(269, 20);
            this.txt_nome_cliente.TabIndex = 6;
            // 
            // lbl_nome_cliente
            // 
            this.lbl_nome_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome_cliente.AutoSize = true;
            this.lbl_nome_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_cliente.Location = new System.Drawing.Point(118, 22);
            this.lbl_nome_cliente.Name = "lbl_nome_cliente";
            this.lbl_nome_cliente.Size = new System.Drawing.Size(111, 19);
            this.lbl_nome_cliente.TabIndex = 5;
            this.lbl_nome_cliente.Text = "Nome Cliente";
            // 
            // txt_id_venda
            // 
            this.txt_id_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id_venda.Enabled = false;
            this.txt_id_venda.Location = new System.Drawing.Point(16, 107);
            this.txt_id_venda.Name = "txt_id_venda";
            this.txt_id_venda.Size = new System.Drawing.Size(100, 20);
            this.txt_id_venda.TabIndex = 8;
            this.txt_id_venda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_id_venda
            // 
            this.lbl_id_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_id_venda.AutoSize = true;
            this.lbl_id_venda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_venda.Location = new System.Drawing.Point(12, 85);
            this.lbl_id_venda.Name = "lbl_id_venda";
            this.lbl_id_venda.Size = new System.Drawing.Size(77, 19);
            this.lbl_id_venda.TabIndex = 7;
            this.lbl_id_venda.Text = "ID Venda";
            // 
            // txt_valor_venda
            // 
            this.txt_valor_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_valor_venda.Enabled = false;
            this.txt_valor_venda.Location = new System.Drawing.Point(122, 107);
            this.txt_valor_venda.Name = "txt_valor_venda";
            this.txt_valor_venda.Size = new System.Drawing.Size(269, 20);
            this.txt_valor_venda.TabIndex = 10;
            // 
            // lbl_valor_venda
            // 
            this.lbl_valor_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_valor_venda.AutoSize = true;
            this.lbl_valor_venda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_venda.Location = new System.Drawing.Point(118, 85);
            this.lbl_valor_venda.Name = "lbl_valor_venda";
            this.lbl_valor_venda.Size = new System.Drawing.Size(123, 19);
            this.lbl_valor_venda.TabIndex = 9;
            this.lbl_valor_venda.Text = "Valor da Venda";
            // 
            // rdbtn_dinheiro
            // 
            this.rdbtn_dinheiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtn_dinheiro.AutoSize = true;
            this.rdbtn_dinheiro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_dinheiro.Location = new System.Drawing.Point(32, 164);
            this.rdbtn_dinheiro.Name = "rdbtn_dinheiro";
            this.rdbtn_dinheiro.Size = new System.Drawing.Size(72, 20);
            this.rdbtn_dinheiro.TabIndex = 11;
            this.rdbtn_dinheiro.TabStop = true;
            this.rdbtn_dinheiro.Text = "Dinheiro";
            this.rdbtn_dinheiro.UseVisualStyleBackColor = true;
            this.rdbtn_dinheiro.CheckedChanged += new System.EventHandler(this.rdbtn_dinheiro_CheckedChanged);
            // 
            // rdbtn_cartao_credito
            // 
            this.rdbtn_cartao_credito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtn_cartao_credito.AutoSize = true;
            this.rdbtn_cartao_credito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_cartao_credito.Location = new System.Drawing.Point(110, 164);
            this.rdbtn_cartao_credito.Name = "rdbtn_cartao_credito";
            this.rdbtn_cartao_credito.Size = new System.Drawing.Size(63, 20);
            this.rdbtn_cartao_credito.TabIndex = 12;
            this.rdbtn_cartao_credito.TabStop = true;
            this.rdbtn_cartao_credito.Text = "Cartão";
            this.rdbtn_cartao_credito.UseVisualStyleBackColor = true;
            this.rdbtn_cartao_credito.CheckedChanged += new System.EventHandler(this.rdbtn_cartao_credito_CheckedChanged);
            // 
            // rdbtn_cheque
            // 
            this.rdbtn_cheque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtn_cheque.AutoSize = true;
            this.rdbtn_cheque.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_cheque.Location = new System.Drawing.Point(179, 164);
            this.rdbtn_cheque.Name = "rdbtn_cheque";
            this.rdbtn_cheque.Size = new System.Drawing.Size(69, 20);
            this.rdbtn_cheque.TabIndex = 13;
            this.rdbtn_cheque.TabStop = true;
            this.rdbtn_cheque.Text = "Cheque";
            this.rdbtn_cheque.UseVisualStyleBackColor = true;
            this.rdbtn_cheque.CheckedChanged += new System.EventHandler(this.rdbtn_cheque_CheckedChanged);
            // 
            // rdbtn_pix
            // 
            this.rdbtn_pix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtn_pix.AutoSize = true;
            this.rdbtn_pix.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_pix.Location = new System.Drawing.Point(254, 164);
            this.rdbtn_pix.Name = "rdbtn_pix";
            this.rdbtn_pix.Size = new System.Drawing.Size(44, 20);
            this.rdbtn_pix.TabIndex = 14;
            this.rdbtn_pix.TabStop = true;
            this.rdbtn_pix.Text = "Pix";
            this.rdbtn_pix.UseVisualStyleBackColor = true;
            this.rdbtn_pix.CheckedChanged += new System.EventHandler(this.rdbtn_pix_CheckedChanged);
            // 
            // rdbtn_boleto
            // 
            this.rdbtn_boleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtn_boleto.AutoSize = true;
            this.rdbtn_boleto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_boleto.Location = new System.Drawing.Point(304, 164);
            this.rdbtn_boleto.Name = "rdbtn_boleto";
            this.rdbtn_boleto.Size = new System.Drawing.Size(62, 20);
            this.rdbtn_boleto.TabIndex = 15;
            this.rdbtn_boleto.TabStop = true;
            this.rdbtn_boleto.Text = "Boleto";
            this.rdbtn_boleto.UseVisualStyleBackColor = true;
            this.rdbtn_boleto.CheckedChanged += new System.EventHandler(this.rdbtn_boleto_CheckedChanged);
            // 
            // pctbox_dinheiro
            // 
            this.pctbox_dinheiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbox_dinheiro.Image = ((System.Drawing.Image)(resources.GetObject("pctbox_dinheiro.Image")));
            this.pctbox_dinheiro.Location = new System.Drawing.Point(16, 214);
            this.pctbox_dinheiro.Name = "pctbox_dinheiro";
            this.pctbox_dinheiro.Size = new System.Drawing.Size(48, 50);
            this.pctbox_dinheiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbox_dinheiro.TabIndex = 16;
            this.pctbox_dinheiro.TabStop = false;
            // 
            // pctbox_cartao_credito
            // 
            this.pctbox_cartao_credito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbox_cartao_credito.Image = ((System.Drawing.Image)(resources.GetObject("pctbox_cartao_credito.Image")));
            this.pctbox_cartao_credito.Location = new System.Drawing.Point(16, 294);
            this.pctbox_cartao_credito.Name = "pctbox_cartao_credito";
            this.pctbox_cartao_credito.Size = new System.Drawing.Size(48, 50);
            this.pctbox_cartao_credito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbox_cartao_credito.TabIndex = 17;
            this.pctbox_cartao_credito.TabStop = false;
            // 
            // pctbox_cheque
            // 
            this.pctbox_cheque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbox_cheque.Image = ((System.Drawing.Image)(resources.GetObject("pctbox_cheque.Image")));
            this.pctbox_cheque.Location = new System.Drawing.Point(16, 374);
            this.pctbox_cheque.Name = "pctbox_cheque";
            this.pctbox_cheque.Size = new System.Drawing.Size(48, 50);
            this.pctbox_cheque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbox_cheque.TabIndex = 18;
            this.pctbox_cheque.TabStop = false;
            // 
            // pctbox_boleto
            // 
            this.pctbox_boleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbox_boleto.Image = ((System.Drawing.Image)(resources.GetObject("pctbox_boleto.Image")));
            this.pctbox_boleto.Location = new System.Drawing.Point(16, 528);
            this.pctbox_boleto.Name = "pctbox_boleto";
            this.pctbox_boleto.Size = new System.Drawing.Size(48, 50);
            this.pctbox_boleto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbox_boleto.TabIndex = 19;
            this.pctbox_boleto.TabStop = false;
            // 
            // pctbox_pix
            // 
            this.pctbox_pix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctbox_pix.Image = ((System.Drawing.Image)(resources.GetObject("pctbox_pix.Image")));
            this.pctbox_pix.Location = new System.Drawing.Point(16, 451);
            this.pctbox_pix.Name = "pctbox_pix";
            this.pctbox_pix.Size = new System.Drawing.Size(48, 50);
            this.pctbox_pix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbox_pix.TabIndex = 20;
            this.pctbox_pix.TabStop = false;
            // 
            // btn_efetuar_alterar_pagamento
            // 
            this.btn_efetuar_alterar_pagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_efetuar_alterar_pagamento.BackColor = System.Drawing.Color.Green;
            this.btn_efetuar_alterar_pagamento.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_efetuar_alterar_pagamento.ForeColor = System.Drawing.Color.White;
            this.btn_efetuar_alterar_pagamento.Location = new System.Drawing.Point(179, 613);
            this.btn_efetuar_alterar_pagamento.Name = "btn_efetuar_alterar_pagamento";
            this.btn_efetuar_alterar_pagamento.Size = new System.Drawing.Size(212, 53);
            this.btn_efetuar_alterar_pagamento.TabIndex = 21;
            this.btn_efetuar_alterar_pagamento.Text = "Efetuar Pagamento";
            this.btn_efetuar_alterar_pagamento.UseVisualStyleBackColor = false;
            this.btn_efetuar_alterar_pagamento.Click += new System.EventHandler(this.btn_efetuar_alterar_pagamento_Click);
            // 
            // txt_dinheiro
            // 
            this.txt_dinheiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_dinheiro.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dinheiro.Location = new System.Drawing.Point(70, 214);
            this.txt_dinheiro.Name = "txt_dinheiro";
            this.txt_dinheiro.Size = new System.Drawing.Size(321, 50);
            this.txt_dinheiro.TabIndex = 22;
            // 
            // txt_cartao_credito
            // 
            this.txt_cartao_credito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cartao_credito.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cartao_credito.Location = new System.Drawing.Point(70, 294);
            this.txt_cartao_credito.Name = "txt_cartao_credito";
            this.txt_cartao_credito.Size = new System.Drawing.Size(321, 50);
            this.txt_cartao_credito.TabIndex = 23;
            // 
            // txt_cheque
            // 
            this.txt_cheque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cheque.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cheque.Location = new System.Drawing.Point(70, 374);
            this.txt_cheque.Name = "txt_cheque";
            this.txt_cheque.Size = new System.Drawing.Size(321, 50);
            this.txt_cheque.TabIndex = 24;
            // 
            // txt_pix
            // 
            this.txt_pix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pix.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pix.Location = new System.Drawing.Point(70, 451);
            this.txt_pix.Name = "txt_pix";
            this.txt_pix.Size = new System.Drawing.Size(321, 50);
            this.txt_pix.TabIndex = 25;
            // 
            // txt_boleto
            // 
            this.txt_boleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_boleto.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_boleto.Location = new System.Drawing.Point(70, 528);
            this.txt_boleto.Name = "txt_boleto";
            this.txt_boleto.Size = new System.Drawing.Size(321, 50);
            this.txt_boleto.TabIndex = 26;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(16, 613);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(157, 53);
            this.btn_cancelar.TabIndex = 27;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 678);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_boleto);
            this.Controls.Add(this.txt_pix);
            this.Controls.Add(this.txt_cheque);
            this.Controls.Add(this.txt_cartao_credito);
            this.Controls.Add(this.txt_dinheiro);
            this.Controls.Add(this.btn_efetuar_alterar_pagamento);
            this.Controls.Add(this.pctbox_pix);
            this.Controls.Add(this.pctbox_boleto);
            this.Controls.Add(this.pctbox_cheque);
            this.Controls.Add(this.pctbox_cartao_credito);
            this.Controls.Add(this.pctbox_dinheiro);
            this.Controls.Add(this.rdbtn_boleto);
            this.Controls.Add(this.rdbtn_pix);
            this.Controls.Add(this.rdbtn_cheque);
            this.Controls.Add(this.rdbtn_cartao_credito);
            this.Controls.Add(this.rdbtn_dinheiro);
            this.Controls.Add(this.txt_valor_venda);
            this.Controls.Add(this.lbl_valor_venda);
            this.Controls.Add(this.txt_id_venda);
            this.Controls.Add(this.lbl_id_venda);
            this.Controls.Add(this.txt_nome_cliente);
            this.Controls.Add(this.lbl_nome_cliente);
            this.Controls.Add(this.txt_id_cliente);
            this.Controls.Add(this.lbl_id_cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCaixa";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.FrmCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_dinheiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_cartao_credito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_cheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_boleto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_pix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id_cliente;
        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.TextBox txt_nome_cliente;
        private System.Windows.Forms.Label lbl_nome_cliente;
        private System.Windows.Forms.TextBox txt_id_venda;
        private System.Windows.Forms.Label lbl_id_venda;
        private System.Windows.Forms.TextBox txt_valor_venda;
        private System.Windows.Forms.Label lbl_valor_venda;
        private System.Windows.Forms.RadioButton rdbtn_dinheiro;
        private System.Windows.Forms.RadioButton rdbtn_cartao_credito;
        private System.Windows.Forms.RadioButton rdbtn_cheque;
        private System.Windows.Forms.RadioButton rdbtn_pix;
        private System.Windows.Forms.RadioButton rdbtn_boleto;
        private System.Windows.Forms.PictureBox pctbox_dinheiro;
        private System.Windows.Forms.PictureBox pctbox_cartao_credito;
        private System.Windows.Forms.PictureBox pctbox_cheque;
        private System.Windows.Forms.PictureBox pctbox_boleto;
        private System.Windows.Forms.PictureBox pctbox_pix;
        private System.Windows.Forms.Button btn_efetuar_alterar_pagamento;
        private System.Windows.Forms.TextBox txt_dinheiro;
        private System.Windows.Forms.TextBox txt_cartao_credito;
        private System.Windows.Forms.TextBox txt_cheque;
        private System.Windows.Forms.TextBox txt_pix;
        private System.Windows.Forms.TextBox txt_boleto;
        private System.Windows.Forms.Button btn_cancelar;
    }
}