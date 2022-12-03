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
            this.lbl_id_cliente = new System.Windows.Forms.Label();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.lbl_nome_cliente = new System.Windows.Forms.Label();
            this.txt_id_venda = new System.Windows.Forms.TextBox();
            this.lbl_id_venda = new System.Windows.Forms.Label();
            this.txt_valor_venda = new System.Windows.Forms.TextBox();
            this.lbl_valor_venda = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_id_cliente
            // 
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
            this.txt_id_cliente.Location = new System.Drawing.Point(16, 44);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_id_cliente.TabIndex = 4;
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Location = new System.Drawing.Point(122, 44);
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(269, 20);
            this.txt_nome_cliente.TabIndex = 6;
            // 
            // lbl_nome_cliente
            // 
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
            this.txt_id_venda.Location = new System.Drawing.Point(16, 107);
            this.txt_id_venda.Name = "txt_id_venda";
            this.txt_id_venda.Size = new System.Drawing.Size(100, 20);
            this.txt_id_venda.TabIndex = 8;
            // 
            // lbl_id_venda
            // 
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
            this.txt_valor_venda.Location = new System.Drawing.Point(122, 107);
            this.txt_valor_venda.Name = "txt_valor_venda";
            this.txt_valor_venda.Size = new System.Drawing.Size(269, 20);
            this.txt_valor_venda.TabIndex = 10;
            // 
            // lbl_valor_venda
            // 
            this.lbl_valor_venda.AutoSize = true;
            this.lbl_valor_venda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_venda.Location = new System.Drawing.Point(118, 85);
            this.lbl_valor_venda.Name = "lbl_valor_venda";
            this.lbl_valor_venda.Size = new System.Drawing.Size(123, 19);
            this.lbl_valor_venda.TabIndex = 9;
            this.lbl_valor_venda.Text = "Valor da Venda";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(32, 155);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 20);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dinheiro";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(110, 155);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cartão";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(179, 155);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 20);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cheque";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(254, 155);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(44, 20);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Pix";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(304, 155);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(62, 20);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Boleto";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 518);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txt_valor_venda);
            this.Controls.Add(this.lbl_valor_venda);
            this.Controls.Add(this.txt_id_venda);
            this.Controls.Add(this.lbl_id_venda);
            this.Controls.Add(this.txt_nome_cliente);
            this.Controls.Add(this.lbl_nome_cliente);
            this.Controls.Add(this.txt_id_cliente);
            this.Controls.Add(this.lbl_id_cliente);
            this.Name = "FrmCaixa";
            this.Text = "FrmCaixa";
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}