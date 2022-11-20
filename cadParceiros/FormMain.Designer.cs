namespace cadParceiros
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmailSolicitacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeParceiro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoParceiro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCepC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCidadeC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbEstadoC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbBairroC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNumeroC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbLogradouroC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCidadeE = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbEstadoE = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbBairroE = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbNumeroE = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbLogradouroE = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbCepE = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tnbCopiarEndereco = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEmailCadastro = new System.Windows.Forms.Button();
            this.tbCPFCNPJ = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbxParceiros = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email para solicitação";
            // 
            // tbEmailSolicitacao
            // 
            this.tbEmailSolicitacao.Location = new System.Drawing.Point(254, 87);
            this.tbEmailSolicitacao.Name = "tbEmailSolicitacao";
            this.tbEmailSolicitacao.Size = new System.Drawing.Size(220, 23);
            this.tbEmailSolicitacao.TabIndex = 1;
            this.tbEmailSolicitacao.TextChanged += new System.EventHandler(this.tbEmailSolicitacao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Parceiro";
            // 
            // tbNomeParceiro
            // 
            this.tbNomeParceiro.Location = new System.Drawing.Point(642, 87);
            this.tbNomeParceiro.MaxLength = 200;
            this.tbNomeParceiro.Name = "tbNomeParceiro";
            this.tbNomeParceiro.Size = new System.Drawing.Size(374, 23);
            this.tbNomeParceiro.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Parceiro";
            // 
            // cbTipoParceiro
            // 
            this.cbTipoParceiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoParceiro.FormattingEnabled = true;
            this.cbTipoParceiro.Items.AddRange(new object[] {
            "Cliente",
            "Fornecedor"});
            this.cbTipoParceiro.Location = new System.Drawing.Point(279, 146);
            this.cbTipoParceiro.Name = "cbTipoParceiro";
            this.cbTipoParceiro.Size = new System.Drawing.Size(121, 23);
            this.cbTipoParceiro.TabIndex = 5;
            this.cbTipoParceiro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de Pessoa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbTipoPessoa.Location = new System.Drawing.Point(529, 146);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(128, 23);
            this.cbTipoPessoa.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(676, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "CPF ou CNPJ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(706, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Cadastrado",
            "Solicitado",
            "Cancelado"});
            this.cbStatus.Location = new System.Drawing.Point(744, 11);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 23);
            this.cbStatus.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(264, 216);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(220, 23);
            this.tbEmail.TabIndex = 13;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(556, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Telefone";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(617, 216);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(220, 23);
            this.tbTelefone.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "CEP";
            // 
            // tbCepC
            // 
            this.tbCepC.Location = new System.Drawing.Point(178, 42);
            this.tbCepC.Name = "tbCepC";
            this.tbCepC.Size = new System.Drawing.Size(127, 23);
            this.tbCepC.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCidadeC);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbEstadoC);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbBairroC);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbNumeroC);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbLogradouroC);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbCepC);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(26, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 135);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço de Cobrança";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbCidadeC
            // 
            this.tbCidadeC.Location = new System.Drawing.Point(410, 88);
            this.tbCidadeC.Name = "tbCidadeC";
            this.tbCidadeC.Size = new System.Drawing.Size(127, 23);
            this.tbCidadeC.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(351, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "Cidade";
            // 
            // tbEstadoC
            // 
            this.tbEstadoC.Location = new System.Drawing.Point(610, 88);
            this.tbEstadoC.Name = "tbEstadoC";
            this.tbEstadoC.Size = new System.Drawing.Size(157, 23);
            this.tbEstadoC.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(553, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Estado";
            // 
            // tbBairroC
            // 
            this.tbBairroC.Location = new System.Drawing.Point(720, 42);
            this.tbBairroC.Name = "tbBairroC";
            this.tbBairroC.Size = new System.Drawing.Size(157, 23);
            this.tbBairroC.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(683, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Bairro";
            // 
            // tbNumeroC
            // 
            this.tbNumeroC.Location = new System.Drawing.Point(610, 42);
            this.tbNumeroC.Name = "tbNumeroC";
            this.tbNumeroC.Size = new System.Drawing.Size(47, 23);
            this.tbNumeroC.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(553, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Número";
            // 
            // tbLogradouroC
            // 
            this.tbLogradouroC.Location = new System.Drawing.Point(410, 42);
            this.tbLogradouroC.Name = "tbLogradouroC";
            this.tbLogradouroC.Size = new System.Drawing.Size(127, 23);
            this.tbLogradouroC.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Logradouro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCidadeE);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbEstadoE);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tbBairroE);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.tbNumeroE);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.tbLogradouroE);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.tbCepE);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(26, 494);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(985, 135);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço de Entrega";
            // 
            // tbCidadeE
            // 
            this.tbCidadeE.Location = new System.Drawing.Point(408, 80);
            this.tbCidadeE.Name = "tbCidadeE";
            this.tbCidadeE.Size = new System.Drawing.Size(127, 23);
            this.tbCidadeE.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(349, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "Cidade";
            // 
            // tbEstadoE
            // 
            this.tbEstadoE.Location = new System.Drawing.Point(608, 80);
            this.tbEstadoE.Name = "tbEstadoE";
            this.tbEstadoE.Size = new System.Drawing.Size(157, 23);
            this.tbEstadoE.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(551, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 15);
            this.label16.TabIndex = 24;
            this.label16.Text = "Estado";
            // 
            // tbBairroE
            // 
            this.tbBairroE.Location = new System.Drawing.Point(718, 34);
            this.tbBairroE.Name = "tbBairroE";
            this.tbBairroE.Size = new System.Drawing.Size(157, 23);
            this.tbBairroE.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(681, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "Bairro";
            // 
            // tbNumeroE
            // 
            this.tbNumeroE.Location = new System.Drawing.Point(608, 34);
            this.tbNumeroE.Name = "tbNumeroE";
            this.tbNumeroE.Size = new System.Drawing.Size(47, 23);
            this.tbNumeroE.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(551, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 15);
            this.label18.TabIndex = 20;
            this.label18.Text = "Número";
            // 
            // tbLogradouroE
            // 
            this.tbLogradouroE.Location = new System.Drawing.Point(408, 34);
            this.tbLogradouroE.Name = "tbLogradouroE";
            this.tbLogradouroE.Size = new System.Drawing.Size(127, 23);
            this.tbLogradouroE.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(333, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 15);
            this.label19.TabIndex = 18;
            this.label19.Text = "Logradouro";
            // 
            // tbCepE
            // 
            this.tbCepE.Location = new System.Drawing.Point(176, 34);
            this.tbCepE.Name = "tbCepE";
            this.tbCepE.Size = new System.Drawing.Size(127, 23);
            this.tbCepE.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(142, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 15);
            this.label20.TabIndex = 16;
            this.label20.Text = "CEP";
            // 
            // tnbCopiarEndereco
            // 
            this.tnbCopiarEndereco.Location = new System.Drawing.Point(298, 431);
            this.tnbCopiarEndereco.Name = "tnbCopiarEndereco";
            this.tnbCopiarEndereco.Size = new System.Drawing.Size(453, 23);
            this.tnbCopiarEndereco.TabIndex = 20;
            this.tnbCopiarEndereco.Text = "Copiar Endereço de Cobrança para Entrega";
            this.tnbCopiarEndereco.UseVisualStyleBackColor = true;
            this.tnbCopiarEndereco.Click += new System.EventHandler(this.tnbCopiarEndereco_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(231, 657);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(140, 23);
            this.btnCadastro.TabIndex = 21;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(677, 657);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar Solicitação";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEmailCadastro
            // 
            this.btnEmailCadastro.Location = new System.Drawing.Point(427, 657);
            this.btnEmailCadastro.Name = "btnEmailCadastro";
            this.btnEmailCadastro.Size = new System.Drawing.Size(223, 23);
            this.btnEmailCadastro.TabIndex = 23;
            this.btnEmailCadastro.Text = "Enviar e-mail para solicitar cadastro";
            this.btnEmailCadastro.UseVisualStyleBackColor = true;
            this.btnEmailCadastro.Click += new System.EventHandler(this.btnEmailCadastro_Click);
            // 
            // tbCPFCNPJ
            // 
            this.tbCPFCNPJ.Location = new System.Drawing.Point(757, 146);
            this.tbCPFCNPJ.Name = "tbCPFCNPJ";
            this.tbCPFCNPJ.Size = new System.Drawing.Size(220, 23);
            this.tbCPFCNPJ.TabIndex = 9;
            this.tbCPFCNPJ.TextChanged += new System.EventHandler(this.tbCPFCNPJ_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(168, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(124, 15);
            this.label21.TabIndex = 24;
            this.label21.Text = "Parceiros de Negócios";
            // 
            // cbxParceiros
            // 
            this.cbxParceiros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParceiros.FormattingEnabled = true;
            this.cbxParceiros.Location = new System.Drawing.Point(301, 13);
            this.cbxParceiros.Name = "cbxParceiros";
            this.cbxParceiros.Size = new System.Drawing.Size(375, 23);
            this.cbxParceiros.TabIndex = 25;
            this.cbxParceiros.DropDown += new System.EventHandler(this.cbxParceiros_DropDown);
            this.cbxParceiros.SelectedIndexChanged += new System.EventHandler(this.cbxParceiros_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 717);
            this.Controls.Add(this.cbxParceiros);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnEmailCadastro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.tnbCopiarEndereco);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCPFCNPJ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTipoPessoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTipoParceiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNomeParceiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmailSolicitacao);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Parceiros de Negócios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbEmailSolicitacao;
        private Label label2;
        private TextBox tbNomeParceiro;
        private Label label3;
        private ComboBox cbTipoParceiro;
        private Label label4;
        private ComboBox cbTipoPessoa;
        private Label label5;
        private Label label6;
        private ComboBox cbStatus;
        private Label label7;
        private TextBox tbEmail;
        private Label label8;
        private TextBox tbTelefone;
        private Label label9;
        private TextBox tbCepC;
        private GroupBox groupBox1;
        private Label label12;
        private TextBox tbNumeroC;
        private Label label11;
        private TextBox tbLogradouroC;
        private Label label10;
        private TextBox tbCidadeC;
        private Label label14;
        private TextBox tbEstadoC;
        private Label label13;
        private TextBox tbBairroC;
        private GroupBox groupBox2;
        private TextBox tbCidadeE;
        private Label label15;
        private TextBox tbEstadoE;
        private Label label16;
        private TextBox tbBairroE;
        private Label label17;
        private TextBox tbNumeroE;
        private Label label18;
        private TextBox tbLogradouroE;
        private Label label19;
        private TextBox tbCepE;
        private Label label20;
        private Button tnbCopiarEndereco;
        private Button btnCadastro;
        private Button btnCancelar;
        private Button btnEmailCadastro;
        private TextBox tbCPFCNPJ;
        private Label label21;
        private ComboBox cbxParceiros;
    }
}