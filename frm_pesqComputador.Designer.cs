namespace Gestao_de_Parque_Computacional.Forms
{
    partial class frm_pesqComputador
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
            this.grid_computador = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroserie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelomemoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhomemoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelodh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhohd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placamae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloplacavideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanholacavideo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.check_chefe = new System.Windows.Forms.CheckBox();
            this.check_ns = new System.Windows.Forms.CheckBox();
            this.check_fornecedor = new System.Windows.Forms.CheckBox();
            this.check_config = new System.Windows.Forms.CheckBox();
            this.check_inativos = new System.Windows.Forms.CheckBox();
            this.txt_ns = new System.Windows.Forms.TextBox();
            this.txt_responsavel = new System.Windows.Forms.TextBox();
            this.txt_fornecedor = new System.Windows.Forms.TextBox();
            this.cmb_tamanhohd = new System.Windows.Forms.ComboBox();
            this.cmb_tamanhomemoria = new System.Windows.Forms.ComboBox();
            this.cmb_tamanhoplacavideo = new System.Windows.Forms.ComboBox();
            this.cmb_processador = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_tamanhohd2 = new System.Windows.Forms.ComboBox();
            this.cmb_tamanhomemoria2 = new System.Windows.Forms.ComboBox();
            this.cmb_tamanhoplacavideo2 = new System.Windows.Forms.ComboBox();
            this.cmb_processador2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_computador)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_computador
            // 
            this.grid_computador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_computador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.numeroserie,
            this.modelomemoria,
            this.tamanhomemoria,
            this.modelodh,
            this.tamanhohd,
            this.processador,
            this.Frequencia,
            this.placamae,
            this.modeloplacavideo,
            this.tamanholacavideo,
            this.responsavel,
            this.fornecedor,
            this.Ativo});
            this.grid_computador.Location = new System.Drawing.Point(13, 136);
            this.grid_computador.Name = "grid_computador";
            this.grid_computador.Size = new System.Drawing.Size(873, 283);
            this.grid_computador.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // numeroserie
            // 
            this.numeroserie.HeaderText = "Número de Série";
            this.numeroserie.Name = "numeroserie";
            // 
            // modelomemoria
            // 
            this.modelomemoria.HeaderText = "Modelo de Memória";
            this.modelomemoria.Name = "modelomemoria";
            // 
            // tamanhomemoria
            // 
            this.tamanhomemoria.HeaderText = "Tamanho de Memória";
            this.tamanhomemoria.Name = "tamanhomemoria";
            // 
            // modelodh
            // 
            this.modelodh.HeaderText = "Modelo do HD";
            this.modelodh.Name = "modelodh";
            // 
            // tamanhohd
            // 
            this.tamanhohd.HeaderText = "Tamanho do HD";
            this.tamanhohd.Name = "tamanhohd";
            // 
            // processador
            // 
            this.processador.HeaderText = "Processador";
            this.processador.Name = "processador";
            // 
            // Frequencia
            // 
            this.Frequencia.HeaderText = "Frequencia do Processador";
            this.Frequencia.Name = "Frequencia";
            // 
            // placamae
            // 
            this.placamae.HeaderText = "Placa Mãe";
            this.placamae.Name = "placamae";
            // 
            // modeloplacavideo
            // 
            this.modeloplacavideo.HeaderText = "Modelo de Placa de Vídeo";
            this.modeloplacavideo.Name = "modeloplacavideo";
            // 
            // tamanholacavideo
            // 
            this.tamanholacavideo.HeaderText = "Tamanho de Placa de  Vídeo";
            this.tamanholacavideo.Name = "tamanholacavideo";
            // 
            // responsavel
            // 
            this.responsavel.HeaderText = "Responsável";
            this.responsavel.Name = "responsavel";
            // 
            // fornecedor
            // 
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            // 
            // Ativo
            // 
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(811, 6);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisar.TabIndex = 1;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // check_chefe
            // 
            this.check_chefe.AutoSize = true;
            this.check_chefe.Location = new System.Drawing.Point(223, 12);
            this.check_chefe.Name = "check_chefe";
            this.check_chefe.Size = new System.Drawing.Size(88, 17);
            this.check_chefe.TabIndex = 2;
            this.check_chefe.Text = "Responsável";
            this.check_chefe.UseVisualStyleBackColor = true;
            this.check_chefe.CheckedChanged += new System.EventHandler(this.check_chefe_CheckedChanged);
            // 
            // check_ns
            // 
            this.check_ns.AutoSize = true;
            this.check_ns.Location = new System.Drawing.Point(12, 12);
            this.check_ns.Name = "check_ns";
            this.check_ns.Size = new System.Drawing.Size(92, 17);
            this.check_ns.TabIndex = 3;
            this.check_ns.Text = "Númerio Série";
            this.check_ns.UseVisualStyleBackColor = true;
            this.check_ns.CheckedChanged += new System.EventHandler(this.check_ns_CheckedChanged);
            // 
            // check_fornecedor
            // 
            this.check_fornecedor.AutoSize = true;
            this.check_fornecedor.Location = new System.Drawing.Point(435, 12);
            this.check_fornecedor.Name = "check_fornecedor";
            this.check_fornecedor.Size = new System.Drawing.Size(80, 17);
            this.check_fornecedor.TabIndex = 4;
            this.check_fornecedor.Text = "Fornecedor";
            this.check_fornecedor.UseVisualStyleBackColor = true;
            this.check_fornecedor.CheckedChanged += new System.EventHandler(this.check_fornecedor_CheckedChanged);
            // 
            // check_config
            // 
            this.check_config.AutoSize = true;
            this.check_config.Location = new System.Drawing.Point(12, 56);
            this.check_config.Name = "check_config";
            this.check_config.Size = new System.Drawing.Size(89, 17);
            this.check_config.TabIndex = 5;
            this.check_config.Text = "Configuração";
            this.check_config.UseVisualStyleBackColor = true;
            this.check_config.CheckedChanged += new System.EventHandler(this.check_config_CheckedChanged);
            // 
            // check_inativos
            // 
            this.check_inativos.AutoSize = true;
            this.check_inativos.Location = new System.Drawing.Point(654, 10);
            this.check_inativos.Name = "check_inativos";
            this.check_inativos.Size = new System.Drawing.Size(63, 17);
            this.check_inativos.TabIndex = 6;
            this.check_inativos.Text = "Inativos";
            this.check_inativos.UseVisualStyleBackColor = true;
            this.check_inativos.CheckedChanged += new System.EventHandler(this.check_inativos_CheckedChanged);
            // 
            // txt_ns
            // 
            this.txt_ns.Location = new System.Drawing.Point(110, 10);
            this.txt_ns.Name = "txt_ns";
            this.txt_ns.Size = new System.Drawing.Size(100, 20);
            this.txt_ns.TabIndex = 7;
            // 
            // txt_responsavel
            // 
            this.txt_responsavel.Location = new System.Drawing.Point(321, 10);
            this.txt_responsavel.Name = "txt_responsavel";
            this.txt_responsavel.Size = new System.Drawing.Size(100, 20);
            this.txt_responsavel.TabIndex = 8;
            // 
            // txt_fornecedor
            // 
            this.txt_fornecedor.Location = new System.Drawing.Point(533, 10);
            this.txt_fornecedor.Name = "txt_fornecedor";
            this.txt_fornecedor.Size = new System.Drawing.Size(100, 20);
            this.txt_fornecedor.TabIndex = 9;
            // 
            // cmb_tamanhohd
            // 
            this.cmb_tamanhohd.FormattingEnabled = true;
            this.cmb_tamanhohd.Location = new System.Drawing.Point(793, 54);
            this.cmb_tamanhohd.Name = "cmb_tamanhohd";
            this.cmb_tamanhohd.Size = new System.Drawing.Size(76, 21);
            this.cmb_tamanhohd.TabIndex = 83;
            // 
            // cmb_tamanhomemoria
            // 
            this.cmb_tamanhomemoria.FormattingEnabled = true;
            this.cmb_tamanhomemoria.Location = new System.Drawing.Point(603, 54);
            this.cmb_tamanhomemoria.Name = "cmb_tamanhomemoria";
            this.cmb_tamanhomemoria.Size = new System.Drawing.Size(76, 21);
            this.cmb_tamanhomemoria.TabIndex = 82;
            // 
            // cmb_tamanhoplacavideo
            // 
            this.cmb_tamanhoplacavideo.FormattingEnabled = true;
            this.cmb_tamanhoplacavideo.Location = new System.Drawing.Point(391, 52);
            this.cmb_tamanhoplacavideo.Name = "cmb_tamanhoplacavideo";
            this.cmb_tamanhoplacavideo.Size = new System.Drawing.Size(76, 21);
            this.cmb_tamanhoplacavideo.TabIndex = 81;
            // 
            // cmb_processador
            // 
            this.cmb_processador.FormattingEnabled = true;
            this.cmb_processador.Location = new System.Drawing.Point(189, 52);
            this.cmb_processador.Name = "cmb_processador";
            this.cmb_processador.Size = new System.Drawing.Size(76, 21);
            this.cmb_processador.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(269, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "GHZ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "GB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(874, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "GB";
            // 
            // GB
            // 
            this.GB.AutoSize = true;
            this.GB.Location = new System.Drawing.Point(682, 57);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(22, 13);
            this.GB.TabIndex = 76;
            this.GB.Text = "GB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Tamanho HD:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(497, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Tamanho Memória:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Processador:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Placa Video:";
            // 
            // cmb_tamanhohd2
            // 
            this.cmb_tamanhohd2.FormattingEnabled = true;
            this.cmb_tamanhohd2.Location = new System.Drawing.Point(793, 81);
            this.cmb_tamanhohd2.Name = "cmb_tamanhohd2";
            this.cmb_tamanhohd2.Size = new System.Drawing.Size(76, 21);
            this.cmb_tamanhohd2.TabIndex = 95;
            // 
            // cmb_tamanhomemoria2
            // 
            this.cmb_tamanhomemoria2.FormattingEnabled = true;
            this.cmb_tamanhomemoria2.Location = new System.Drawing.Point(603, 81);
            this.cmb_tamanhomemoria2.Name = "cmb_tamanhomemoria2";
            this.cmb_tamanhomemoria2.Size = new System.Drawing.Size(76, 21);
            this.cmb_tamanhomemoria2.TabIndex = 94;
            // 
            // cmb_tamanhoplacavideo2
            // 
            this.cmb_tamanhoplacavideo2.FormattingEnabled = true;
            this.cmb_tamanhoplacavideo2.Location = new System.Drawing.Point(391, 79);
            this.cmb_tamanhoplacavideo2.Name = "cmb_tamanhoplacavideo2";
            this.cmb_tamanhoplacavideo2.Size = new System.Drawing.Size(76, 21);
            this.cmb_tamanhoplacavideo2.TabIndex = 93;
            // 
            // cmb_processador2
            // 
            this.cmb_processador2.FormattingEnabled = true;
            this.cmb_processador2.Location = new System.Drawing.Point(189, 79);
            this.cmb_processador2.Name = "cmb_processador2";
            this.cmb_processador2.Size = new System.Drawing.Size(76, 21);
            this.cmb_processador2.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "GHZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "GB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(874, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "GB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(682, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "GB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(713, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 87;
            this.label12.Text = "Tamanho HD:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(497, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 86;
            this.label13.Text = "Tamanho Memória:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(113, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 85;
            this.label14.Text = "Processador:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 84;
            this.label15.Text = "Placa Video:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 96;
            // 
            // frm_pesqComputador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 439);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmb_tamanhohd2);
            this.Controls.Add(this.cmb_tamanhomemoria2);
            this.Controls.Add(this.cmb_tamanhoplacavideo2);
            this.Controls.Add(this.cmb_processador2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmb_tamanhohd);
            this.Controls.Add(this.cmb_tamanhomemoria);
            this.Controls.Add(this.cmb_tamanhoplacavideo);
            this.Controls.Add(this.cmb_processador);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_fornecedor);
            this.Controls.Add(this.txt_responsavel);
            this.Controls.Add(this.txt_ns);
            this.Controls.Add(this.check_inativos);
            this.Controls.Add(this.check_config);
            this.Controls.Add(this.check_fornecedor);
            this.Controls.Add(this.check_ns);
            this.Controls.Add(this.check_chefe);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.grid_computador);
            this.Name = "frm_pesqComputador";
            this.Text = "Pesquisar Computador";
            this.Load += new System.EventHandler(this.frm_pesqComputador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_computador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_computador;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroserie;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelomemoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhomemoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelodh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhohd;
        private System.Windows.Forms.DataGridViewTextBoxColumn processador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn placamae;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloplacavideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanholacavideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.CheckBox check_chefe;
        private System.Windows.Forms.CheckBox check_ns;
        private System.Windows.Forms.CheckBox check_fornecedor;
        private System.Windows.Forms.CheckBox check_config;
        private System.Windows.Forms.CheckBox check_inativos;
        private System.Windows.Forms.TextBox txt_ns;
        private System.Windows.Forms.TextBox txt_responsavel;
        private System.Windows.Forms.TextBox txt_fornecedor;
        private System.Windows.Forms.ComboBox cmb_tamanhohd;
        private System.Windows.Forms.ComboBox cmb_tamanhomemoria;
        private System.Windows.Forms.ComboBox cmb_tamanhoplacavideo;
        private System.Windows.Forms.ComboBox cmb_processador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label GB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_tamanhohd2;
        private System.Windows.Forms.ComboBox cmb_tamanhomemoria2;
        private System.Windows.Forms.ComboBox cmb_tamanhoplacavideo2;
        private System.Windows.Forms.ComboBox cmb_processador2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}