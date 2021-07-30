
namespace TesteApi.Forms
{
    partial class frmConsultaCep
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
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.bt_Busca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_logradouro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_localidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ibge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ddd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_siafi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(12, 33);
            this.txt_cep.MaxLength = 8;
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(190, 23);
            this.txt_cep.TabIndex = 0;
            // 
            // bt_Busca
            // 
            this.bt_Busca.Location = new System.Drawing.Point(213, 33);
            this.bt_Busca.Name = "bt_Busca";
            this.bt_Busca.Size = new System.Drawing.Size(75, 23);
            this.bt_Busca.TabIndex = 1;
            this.bt_Busca.Text = "Busca";
            this.bt_Busca.UseVisualStyleBackColor = true;
            this.bt_Busca.Click += new System.EventHandler(this.bt_Busca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Logradouro";
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.Location = new System.Drawing.Point(12, 77);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(276, 23);
            this.txt_logradouro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Complemento";
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(12, 121);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(276, 23);
            this.txt_complemento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bairro";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(12, 165);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(276, 23);
            this.txt_bairro.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cidade";
            // 
            // txt_localidade
            // 
            this.txt_localidade.Location = new System.Drawing.Point(12, 209);
            this.txt_localidade.Name = "txt_localidade";
            this.txt_localidade.Size = new System.Drawing.Size(276, 23);
            this.txt_localidade.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "UF";
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(12, 254);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(276, 23);
            this.txt_uf.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "IBGE";
            // 
            // txt_ibge
            // 
            this.txt_ibge.Location = new System.Drawing.Point(12, 298);
            this.txt_ibge.Name = "txt_ibge";
            this.txt_ibge.Size = new System.Drawing.Size(276, 23);
            this.txt_ibge.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "GIA";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(12, 342);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(276, 23);
            this.txt_gia.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "DDD";
            // 
            // txt_ddd
            // 
            this.txt_ddd.Location = new System.Drawing.Point(12, 387);
            this.txt_ddd.Name = "txt_ddd";
            this.txt_ddd.Size = new System.Drawing.Size(276, 23);
            this.txt_ddd.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "SIAFI";
            // 
            // txt_siafi
            // 
            this.txt_siafi.Location = new System.Drawing.Point(12, 432);
            this.txt_siafi.Name = "txt_siafi";
            this.txt_siafi.Size = new System.Drawing.Size(276, 23);
            this.txt_siafi.TabIndex = 20;
            // 
            // frmConsultaCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 479);
            this.Controls.Add(this.txt_siafi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_ddd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ibge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_localidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_logradouro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Busca);
            this.Controls.Add(this.txt_cep);
            this.Name = "frmConsultaCep";
            this.Text = "Consulta CEP";
            this.Load += new System.EventHandler(this.frmConsultaCep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.Button bt_Busca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_logradouro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_localidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ibge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ddd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_siafi;
    }
}