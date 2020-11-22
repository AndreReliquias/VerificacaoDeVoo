namespace VerificacaoDeVoos
{
    partial class NovoVoo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkNovaCidade = new System.Windows.Forms.LinkLabel();
            this.lnkNovoAviao = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.numDuracao = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cbCidadeDestino = new System.Windows.Forms.ComboBox();
            this.cbCidadeOrigem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAviao = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkNovaCidade);
            this.groupBox1.Controls.Add(this.lnkNovoAviao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpHora);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numDuracao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.cbCidadeDestino);
            this.groupBox1.Controls.Add(this.cbCidadeOrigem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbAviao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Voo";
            // 
            // lnkNovaCidade
            // 
            this.lnkNovaCidade.AutoSize = true;
            this.lnkNovaCidade.Location = new System.Drawing.Point(140, 236);
            this.lnkNovaCidade.Name = "lnkNovaCidade";
            this.lnkNovaCidade.Size = new System.Drawing.Size(117, 13);
            this.lnkNovaCidade.TabIndex = 14;
            this.lnkNovaCidade.TabStop = true;
            this.lnkNovaCidade.Text = "Cadastrar Nova Cidade";
            this.lnkNovaCidade.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNovaCidade_LinkClicked);
            // 
            // lnkNovoAviao
            // 
            this.lnkNovoAviao.AutoSize = true;
            this.lnkNovoAviao.Location = new System.Drawing.Point(6, 236);
            this.lnkNovoAviao.Name = "lnkNovoAviao";
            this.lnkNovoAviao.Size = new System.Drawing.Size(111, 13);
            this.lnkNovoAviao.TabIndex = 13;
            this.lnkNovoAviao.TabStop = true;
            this.lnkNovoAviao.Text = "Cadastrar Novo Avião";
            this.lnkNovoAviao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNovoAviao_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hora de partida:";
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(143, 124);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(121, 20);
            this.dtpHora.TabIndex = 11;
            this.dtpHora.Value = new System.DateTime(2020, 11, 17, 15, 16, 0, 0);
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = " dd/MM/yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpData.Location = new System.Drawing.Point(143, 98);
            this.dtpData.Name = "dtpData";
            this.dtpData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpData.Size = new System.Drawing.Size(121, 20);
            this.dtpData.TabIndex = 10;
            this.dtpData.Value = new System.DateTime(2020, 11, 17, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Duração estimada (horas):\r\n";
            // 
            // numDuracao
            // 
            this.numDuracao.Location = new System.Drawing.Point(143, 150);
            this.numDuracao.Name = "numDuracao";
            this.numDuracao.Size = new System.Drawing.Size(120, 20);
            this.numDuracao.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de partida:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AccessibleDescription = "";
            this.btnFinalizar.Location = new System.Drawing.Point(95, 195);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Tag = "btnFinalizar";
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cbCidadeDestino
            // 
            this.cbCidadeDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidadeDestino.FormattingEnabled = true;
            this.cbCidadeDestino.Location = new System.Drawing.Point(143, 71);
            this.cbCidadeDestino.Name = "cbCidadeDestino";
            this.cbCidadeDestino.Size = new System.Drawing.Size(121, 21);
            this.cbCidadeDestino.TabIndex = 5;
            // 
            // cbCidadeOrigem
            // 
            this.cbCidadeOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidadeOrigem.FormattingEnabled = true;
            this.cbCidadeOrigem.Location = new System.Drawing.Point(143, 44);
            this.cbCidadeOrigem.Name = "cbCidadeOrigem";
            this.cbCidadeOrigem.Size = new System.Drawing.Size(121, 21);
            this.cbCidadeOrigem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cidade de destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade de origem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Avião:";
            // 
            // cbAviao
            // 
            this.cbAviao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAviao.FormattingEnabled = true;
            this.cbAviao.Location = new System.Drawing.Point(143, 17);
            this.cbAviao.Name = "cbAviao";
            this.cbAviao.Size = new System.Drawing.Size(121, 21);
            this.cbAviao.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 289);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Validação de voos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCidadeDestino;
        private System.Windows.Forms.ComboBox cbCidadeOrigem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAviao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDuracao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnkNovaCidade;
        private System.Windows.Forms.LinkLabel lnkNovoAviao;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dtpHora;
    }
}

