namespace AppAluno.Cadastros
{
    partial class CADAluno
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CADAluno));
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lblCpfAluno = new System.Windows.Forms.Label();
            this.lblRGAluno = new System.Windows.Forms.Label();
            this.lblEmailAluno = new System.Windows.Forms.Label();
            this.lblDataDeNascimentoAluno = new System.Windows.Forms.Label();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprovado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMais = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CKBSim = new System.Windows.Forms.CheckBox();
            this.lblAprovado = new System.Windows.Forms.Label();
            this.CKBInativo = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtTelefoneContatoAluno = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneContatoAluno = new System.Windows.Forms.Label();
            this.txtTelefoneCelularAluno = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneCelularAluno = new System.Windows.Forms.Label();
            this.txtCpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtDataDeNascimentoAluno = new System.Windows.Forms.MaskedTextBox();
            this.cbxSexoAluno = new System.Windows.Forms.ComboBox();
            this.txtEmailAluno = new System.Windows.Forms.TextBox();
            this.txtRGAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblSexoAluno = new System.Windows.Forms.Label();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnSalvarCadastroAluno = new System.Windows.Forms.Button();
            this.btnVoltarCadastro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtRGResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeResponsavel = new System.Windows.Forms.TextBox();
            this.lblNomeResponsavel = new System.Windows.Forms.Label();
            this.lblRGResponsavel = new System.Windows.Forms.Label();
            this.lblCpfResponsavel = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.Location = new System.Drawing.Point(13, 28);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(44, 15);
            this.lblNomeAluno.TabIndex = 10;
            this.lblNomeAluno.Text = "Nome :";
            // 
            // lblCpfAluno
            // 
            this.lblCpfAluno.AutoSize = true;
            this.lblCpfAluno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfAluno.Location = new System.Drawing.Point(577, 28);
            this.lblCpfAluno.Name = "lblCpfAluno";
            this.lblCpfAluno.Size = new System.Drawing.Size(33, 15);
            this.lblCpfAluno.TabIndex = 18;
            this.lblCpfAluno.Text = "CPF :";
            // 
            // lblRGAluno
            // 
            this.lblRGAluno.AutoSize = true;
            this.lblRGAluno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGAluno.Location = new System.Drawing.Point(412, 28);
            this.lblRGAluno.Name = "lblRGAluno";
            this.lblRGAluno.Size = new System.Drawing.Size(28, 15);
            this.lblRGAluno.TabIndex = 19;
            this.lblRGAluno.Text = "RG :";
            // 
            // lblEmailAluno
            // 
            this.lblEmailAluno.AutoSize = true;
            this.lblEmailAluno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAluno.Location = new System.Drawing.Point(194, 70);
            this.lblEmailAluno.Name = "lblEmailAluno";
            this.lblEmailAluno.Size = new System.Drawing.Size(50, 15);
            this.lblEmailAluno.TabIndex = 20;
            this.lblEmailAluno.Text = "E-MAIL :";
            // 
            // lblDataDeNascimentoAluno
            // 
            this.lblDataDeNascimentoAluno.AutoSize = true;
            this.lblDataDeNascimentoAluno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeNascimentoAluno.Location = new System.Drawing.Point(724, 28);
            this.lblDataDeNascimentoAluno.Name = "lblDataDeNascimentoAluno";
            this.lblDataDeNascimentoAluno.Size = new System.Drawing.Size(123, 15);
            this.lblDataDeNascimentoAluno.TabIndex = 21;
            this.lblDataDeNascimentoAluno.Text = "Data de Nascimento :";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nome,
            this.RG,
            this.CPF,
            this.Email,
            this.Sexo,
            this.DataNascimento,
            this.Status,
            this.Aprovado,
            this.TelefoneCelular,
            this.TelefoneContato});
            this.dgvAlunos.Location = new System.Drawing.Point(33, 291);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(938, 229);
            this.dgvAlunos.TabIndex = 22;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // DataNascimento
            // 
            this.DataNascimento.HeaderText = "DataNascimento";
            this.DataNascimento.Name = "DataNascimento";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Aprovado
            // 
            this.Aprovado.HeaderText = "Aprovado";
            this.Aprovado.Name = "Aprovado";
            // 
            // TelefoneCelular
            // 
            this.TelefoneCelular.HeaderText = "TelefoneCelular";
            this.TelefoneCelular.Name = "TelefoneCelular";
            // 
            // TelefoneContato
            // 
            this.TelefoneContato.HeaderText = "TelefoneContato";
            this.TelefoneContato.Name = "TelefoneContato";
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(836, 110);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(42, 23);
            this.btnMais.TabIndex = 28;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CKBSim);
            this.groupBox2.Controls.Add(this.lblAprovado);
            this.groupBox2.Controls.Add(this.CKBInativo);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.txtTelefoneContatoAluno);
            this.groupBox2.Controls.Add(this.lblTelefoneContatoAluno);
            this.groupBox2.Controls.Add(this.txtTelefoneCelularAluno);
            this.groupBox2.Controls.Add(this.lblTelefoneCelularAluno);
            this.groupBox2.Controls.Add(this.txtCpfAluno);
            this.groupBox2.Controls.Add(this.txtDataDeNascimentoAluno);
            this.groupBox2.Controls.Add(this.cbxSexoAluno);
            this.groupBox2.Controls.Add(this.txtEmailAluno);
            this.groupBox2.Controls.Add(this.txtRGAluno);
            this.groupBox2.Controls.Add(this.txtNomeAluno);
            this.groupBox2.Controls.Add(this.lblSexoAluno);
            this.groupBox2.Controls.Add(this.lblNomeAluno);
            this.groupBox2.Controls.Add(this.lblCpfAluno);
            this.groupBox2.Controls.Add(this.lblRGAluno);
            this.groupBox2.Controls.Add(this.lblDataDeNascimentoAluno);
            this.groupBox2.Controls.Add(this.lblEmailAluno);
            this.groupBox2.Controls.Add(this.btnMais);
            this.groupBox2.Controls.Add(this.btnMenos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 145);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aluno";
            // 
            // CKBSim
            // 
            this.CKBSim.AutoSize = true;
            this.CKBSim.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.CKBSim.Location = new System.Drawing.Point(125, 114);
            this.CKBSim.Name = "CKBSim";
            this.CKBSim.Size = new System.Drawing.Size(46, 19);
            this.CKBSim.TabIndex = 64;
            this.CKBSim.Text = "Sim";
            this.CKBSim.UseVisualStyleBackColor = true;
            this.CKBSim.Visible = false;
            // 
            // lblAprovado
            // 
            this.lblAprovado.AutoSize = true;
            this.lblAprovado.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lblAprovado.Location = new System.Drawing.Point(122, 101);
            this.lblAprovado.Name = "lblAprovado";
            this.lblAprovado.Size = new System.Drawing.Size(60, 15);
            this.lblAprovado.TabIndex = 63;
            this.lblAprovado.Text = "Aprovado";
            this.lblAprovado.Visible = false;
            // 
            // CKBInativo
            // 
            this.CKBInativo.AutoSize = true;
            this.CKBInativo.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.CKBInativo.Location = new System.Drawing.Point(18, 114);
            this.CKBInativo.Name = "CKBInativo";
            this.CKBInativo.Size = new System.Drawing.Size(64, 19);
            this.CKBInativo.TabIndex = 61;
            this.CKBInativo.Text = "Inativo";
            this.CKBInativo.UseVisualStyleBackColor = true;
            this.CKBInativo.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lblStatus.Location = new System.Drawing.Point(13, 101);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 15);
            this.lblStatus.TabIndex = 60;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // txtTelefoneContatoAluno
            // 
            this.txtTelefoneContatoAluno.Location = new System.Drawing.Point(809, 69);
            this.txtTelefoneContatoAluno.Mask = "(00)0000-0000";
            this.txtTelefoneContatoAluno.Name = "txtTelefoneContatoAluno";
            this.txtTelefoneContatoAluno.Size = new System.Drawing.Size(83, 24);
            this.txtTelefoneContatoAluno.TabIndex = 59;
            this.txtTelefoneContatoAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneContatoAluno_KeyPress);
            // 
            // lblTelefoneContatoAluno
            // 
            this.lblTelefoneContatoAluno.AutoSize = true;
            this.lblTelefoneContatoAluno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneContatoAluno.Location = new System.Drawing.Point(694, 73);
            this.lblTelefoneContatoAluno.Name = "lblTelefoneContatoAluno";
            this.lblTelefoneContatoAluno.Size = new System.Drawing.Size(104, 15);
            this.lblTelefoneContatoAluno.TabIndex = 58;
            this.lblTelefoneContatoAluno.Text = "Telefone Contato :";
            // 
            // txtTelefoneCelularAluno
            // 
            this.txtTelefoneCelularAluno.Location = new System.Drawing.Point(600, 70);
            this.txtTelefoneCelularAluno.Mask = "(00)00000-0000";
            this.txtTelefoneCelularAluno.Name = "txtTelefoneCelularAluno";
            this.txtTelefoneCelularAluno.Size = new System.Drawing.Size(83, 24);
            this.txtTelefoneCelularAluno.TabIndex = 56;
            this.txtTelefoneCelularAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneCelularAluno_KeyPress);
            // 
            // lblTelefoneCelularAluno
            // 
            this.lblTelefoneCelularAluno.AutoSize = true;
            this.lblTelefoneCelularAluno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCelularAluno.Location = new System.Drawing.Point(488, 73);
            this.lblTelefoneCelularAluno.Name = "lblTelefoneCelularAluno";
            this.lblTelefoneCelularAluno.Size = new System.Drawing.Size(101, 15);
            this.lblTelefoneCelularAluno.TabIndex = 54;
            this.lblTelefoneCelularAluno.Text = "Telefone Celular :";
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Location = new System.Drawing.Point(620, 24);
            this.txtCpfAluno.Mask = "000,000,000-00";
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.Size = new System.Drawing.Size(94, 24);
            this.txtCpfAluno.TabIndex = 22;
            this.txtCpfAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfAluno_KeyPress);
            // 
            // txtDataDeNascimentoAluno
            // 
            this.txtDataDeNascimentoAluno.Location = new System.Drawing.Point(857, 24);
            this.txtDataDeNascimentoAluno.Mask = "00/00/0000";
            this.txtDataDeNascimentoAluno.Name = "txtDataDeNascimentoAluno";
            this.txtDataDeNascimentoAluno.Size = new System.Drawing.Size(65, 24);
            this.txtDataDeNascimentoAluno.TabIndex = 23;
            this.txtDataDeNascimentoAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataDeNascimentoAluno_KeyPress);
            // 
            // cbxSexoAluno
            // 
            this.cbxSexoAluno.FormattingEnabled = true;
            this.cbxSexoAluno.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbxSexoAluno.Location = new System.Drawing.Point(62, 66);
            this.cbxSexoAluno.Name = "cbxSexoAluno";
            this.cbxSexoAluno.Size = new System.Drawing.Size(121, 26);
            this.cbxSexoAluno.TabIndex = 24;
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.Location = new System.Drawing.Point(255, 67);
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(222, 24);
            this.txtEmailAluno.TabIndex = 27;
            // 
            // txtRGAluno
            // 
            this.txtRGAluno.Location = new System.Drawing.Point(450, 24);
            this.txtRGAluno.Name = "txtRGAluno";
            this.txtRGAluno.Size = new System.Drawing.Size(117, 24);
            this.txtRGAluno.TabIndex = 21;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(67, 24);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(335, 24);
            this.txtNomeAluno.TabIndex = 20;
            this.txtNomeAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeAluno_KeyPress);
            // 
            // lblSexoAluno
            // 
            this.lblSexoAluno.AutoSize = true;
            this.lblSexoAluno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoAluno.Location = new System.Drawing.Point(13, 70);
            this.lblSexoAluno.Name = "lblSexoAluno";
            this.lblSexoAluno.Size = new System.Drawing.Size(38, 15);
            this.lblSexoAluno.TabIndex = 27;
            this.lblSexoAluno.Text = "Sexo :";
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(883, 110);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(39, 23);
            this.btnMenos.TabIndex = 29;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnSalvarCadastroAluno
            // 
            this.btnSalvarCadastroAluno.Location = new System.Drawing.Point(815, 537);
            this.btnSalvarCadastroAluno.Name = "btnSalvarCadastroAluno";
            this.btnSalvarCadastroAluno.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCadastroAluno.TabIndex = 30;
            this.btnSalvarCadastroAluno.Text = "Salvar";
            this.btnSalvarCadastroAluno.UseVisualStyleBackColor = true;
            this.btnSalvarCadastroAluno.Click += new System.EventHandler(this.btnSalvarCadastroAluno_Click);
            // 
            // btnVoltarCadastro
            // 
            this.btnVoltarCadastro.Location = new System.Drawing.Point(896, 537);
            this.btnVoltarCadastro.Name = "btnVoltarCadastro";
            this.btnVoltarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarCadastro.TabIndex = 31;
            this.btnVoltarCadastro.Text = "Voltar";
            this.btnVoltarCadastro.UseVisualStyleBackColor = true;
            this.btnVoltarCadastro.Click += new System.EventHandler(this.btnVoltarCadastro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtRGResponsavel);
            this.groupBox1.Controls.Add(this.txtCpfResponsavel);
            this.groupBox1.Controls.Add(this.txtNomeResponsavel);
            this.groupBox1.Controls.Add(this.lblNomeResponsavel);
            this.groupBox1.Controls.Add(this.lblRGResponsavel);
            this.groupBox1.Controls.Add(this.lblCpfResponsavel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 93);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Responsável";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(730, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 23);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtRGResponsavel
            // 
            this.txtRGResponsavel.Location = new System.Drawing.Point(51, 32);
            this.txtRGResponsavel.Name = "txtRGResponsavel";
            this.txtRGResponsavel.Size = new System.Drawing.Size(120, 24);
            this.txtRGResponsavel.TabIndex = 2;
            // 
            // txtCpfResponsavel
            // 
            this.txtCpfResponsavel.Location = new System.Drawing.Point(224, 32);
            this.txtCpfResponsavel.Mask = "000,000,000-00";
            this.txtCpfResponsavel.Name = "txtCpfResponsavel";
            this.txtCpfResponsavel.Size = new System.Drawing.Size(94, 24);
            this.txtCpfResponsavel.TabIndex = 3;
            this.txtCpfResponsavel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfResponsavel_KeyPress);
            // 
            // txtNomeResponsavel
            // 
            this.txtNomeResponsavel.Location = new System.Drawing.Point(388, 32);
            this.txtNomeResponsavel.Name = "txtNomeResponsavel";
            this.txtNomeResponsavel.Size = new System.Drawing.Size(335, 24);
            this.txtNomeResponsavel.TabIndex = 1;
            this.txtNomeResponsavel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeResponsavel_KeyPress);
            // 
            // lblNomeResponsavel
            // 
            this.lblNomeResponsavel.AutoSize = true;
            this.lblNomeResponsavel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeResponsavel.Location = new System.Drawing.Point(334, 36);
            this.lblNomeResponsavel.Name = "lblNomeResponsavel";
            this.lblNomeResponsavel.Size = new System.Drawing.Size(44, 15);
            this.lblNomeResponsavel.TabIndex = 0;
            this.lblNomeResponsavel.Text = "Nome :";
            // 
            // lblRGResponsavel
            // 
            this.lblRGResponsavel.AutoSize = true;
            this.lblRGResponsavel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGResponsavel.Location = new System.Drawing.Point(13, 36);
            this.lblRGResponsavel.Name = "lblRGResponsavel";
            this.lblRGResponsavel.Size = new System.Drawing.Size(28, 15);
            this.lblRGResponsavel.TabIndex = 2;
            this.lblRGResponsavel.Text = "RG :";
            // 
            // lblCpfResponsavel
            // 
            this.lblCpfResponsavel.AutoSize = true;
            this.lblCpfResponsavel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfResponsavel.Location = new System.Drawing.Point(181, 36);
            this.lblCpfResponsavel.Name = "lblCpfResponsavel";
            this.lblCpfResponsavel.Size = new System.Drawing.Size(33, 15);
            this.lblCpfResponsavel.TabIndex = 1;
            this.lblCpfResponsavel.Text = "CPF :";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(33, 537);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Cadastro Aluno";
            // 
            // CADAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltarCadastro);
            this.Controls.Add(this.btnSalvarCadastroAluno);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CADAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Aluno";
            this.Load += new System.EventHandler(this.CadAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblCpfAluno;
        private System.Windows.Forms.Label lblRGAluno;
        private System.Windows.Forms.Label lblEmailAluno;
        private System.Windows.Forms.Label lblDataDeNascimentoAluno;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSexoAluno;
        private System.Windows.Forms.Button btnSalvarCadastroAluno;
        private System.Windows.Forms.Button btnVoltarCadastro;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtEmailAluno;
        private System.Windows.Forms.MaskedTextBox txtRGAluno;
        private System.Windows.Forms.ComboBox cbxSexoAluno;
        private System.Windows.Forms.MaskedTextBox txtCpfAluno;
        private System.Windows.Forms.MaskedTextBox txtDataDeNascimentoAluno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtRGResponsavel;
        private System.Windows.Forms.MaskedTextBox txtCpfResponsavel;
        private System.Windows.Forms.TextBox txtNomeResponsavel;
        private System.Windows.Forms.Label lblNomeResponsavel;
        private System.Windows.Forms.Label lblRGResponsavel;
        private System.Windows.Forms.Label lblCpfResponsavel;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox txtTelefoneCelularAluno;
        private System.Windows.Forms.Label lblTelefoneCelularAluno;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.MaskedTextBox txtTelefoneContatoAluno;
        private System.Windows.Forms.Label lblTelefoneContatoAluno;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.CheckBox CKBSim;
		private System.Windows.Forms.Label lblAprovado;
		private System.Windows.Forms.CheckBox CKBInativo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aprovado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneContato;
        private System.Windows.Forms.Label label1;
    }
}

