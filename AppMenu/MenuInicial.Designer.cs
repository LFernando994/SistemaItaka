namespace AppMenu
{
    partial class MenuInicial
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.responsavelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.frequênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaResponsávelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.adicionarProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaDeProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.parâmetrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.matricularAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaChamadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.turmasCadastradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.listaDeProfessoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.CLIENTES = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.timerCadResp = new System.Windows.Forms.Timer(this.components);
			this.timerCadAluno = new System.Windows.Forms.Timer(this.components);
			this.timerListaAluno = new System.Windows.Forms.Timer(this.components);
			this.timerListaResp = new System.Windows.Forms.Timer(this.components);
			this.timerCadCurso = new System.Windows.Forms.Timer(this.components);
			this.timerAddProf = new System.Windows.Forms.Timer(this.components);
			this.timerListaCurso = new System.Windows.Forms.Timer(this.components);
			this.timerCadTurmas = new System.Windows.Forms.Timer(this.components);
			this.timerMatriAluno = new System.Windows.Forms.Timer(this.components);
			this.timerListaDeCham = new System.Windows.Forms.Timer(this.components);
			this.timerListaTurmas = new System.Windows.Forms.Timer(this.components);
			this.timerCadProf = new System.Windows.Forms.Timer(this.components);
			this.timerListaDeProf = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.parâmetrosToolStripMenuItem,
            this.professoresToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(612, 24);
			this.menuStrip1.TabIndex = 23;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// sistemaToolStripMenuItem
			// 
			this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
			this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
			this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.sistemaToolStripMenuItem.Text = "Sistema";
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// produtosToolStripMenuItem
			// 
			this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.frequênciaToolStripMenuItem,
            this.listaResponsávelToolStripMenuItem});
			this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
			this.produtosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.produtosToolStripMenuItem.Text = "Alunos";
			// 
			// cadastrarToolStripMenuItem1
			// 
			this.cadastrarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.responsavelToolStripMenuItem,
            this.alunoToolStripMenuItem});
			this.cadastrarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarToolStripMenuItem1.Image")));
			this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
			this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
			this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
			// 
			// responsavelToolStripMenuItem
			// 
			this.responsavelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("responsavelToolStripMenuItem.Image")));
			this.responsavelToolStripMenuItem.Name = "responsavelToolStripMenuItem";
			this.responsavelToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.responsavelToolStripMenuItem.Text = "Responsável";
			this.responsavelToolStripMenuItem.Click += new System.EventHandler(this.responsavelToolStripMenuItem_Click);
			// 
			// alunoToolStripMenuItem
			// 
			this.alunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alunoToolStripMenuItem.Image")));
			this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
			this.alunoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.alunoToolStripMenuItem.Text = "Aluno";
			this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
			// 
			// frequênciaToolStripMenuItem
			// 
			this.frequênciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("frequênciaToolStripMenuItem.Image")));
			this.frequênciaToolStripMenuItem.Name = "frequênciaToolStripMenuItem";
			this.frequênciaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.frequênciaToolStripMenuItem.Text = "Lista alunos/Frequência";
			this.frequênciaToolStripMenuItem.Click += new System.EventHandler(this.frequênciaToolStripMenuItem_Click);
			// 
			// listaResponsávelToolStripMenuItem
			// 
			this.listaResponsávelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaResponsávelToolStripMenuItem.Image")));
			this.listaResponsávelToolStripMenuItem.Name = "listaResponsávelToolStripMenuItem";
			this.listaResponsávelToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.listaResponsávelToolStripMenuItem.Text = "Lista Responsável";
			this.listaResponsávelToolStripMenuItem.Click += new System.EventHandler(this.listaResponsávelToolStripMenuItem_Click);
			// 
			// movimentaçãoToolStripMenuItem
			// 
			this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem2,
            this.adicionarProfessoresToolStripMenuItem,
            this.listaDeProfessoresToolStripMenuItem});
			this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
			this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.movimentaçãoToolStripMenuItem.Text = "Cursos";
			// 
			// cadastrarToolStripMenuItem2
			// 
			this.cadastrarToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarToolStripMenuItem2.Image")));
			this.cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
			this.cadastrarToolStripMenuItem2.Size = new System.Drawing.Size(188, 22);
			this.cadastrarToolStripMenuItem2.Text = "Cadastrar";
			this.cadastrarToolStripMenuItem2.Click += new System.EventHandler(this.cadastrarToolStripMenuItem2_Click);
			// 
			// adicionarProfessoresToolStripMenuItem
			// 
			this.adicionarProfessoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarProfessoresToolStripMenuItem.Image")));
			this.adicionarProfessoresToolStripMenuItem.Name = "adicionarProfessoresToolStripMenuItem";
			this.adicionarProfessoresToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.adicionarProfessoresToolStripMenuItem.Text = "Adicionar Professores";
			this.adicionarProfessoresToolStripMenuItem.Click += new System.EventHandler(this.adicionarProfessoresToolStripMenuItem_Click);
			// 
			// listaDeProfessoresToolStripMenuItem
			// 
			this.listaDeProfessoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDeProfessoresToolStripMenuItem.Image")));
			this.listaDeProfessoresToolStripMenuItem.Name = "listaDeProfessoresToolStripMenuItem";
			this.listaDeProfessoresToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.listaDeProfessoresToolStripMenuItem.Text = "Lista de Cursos";
			this.listaDeProfessoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeProfessoresToolStripMenuItem_Click);
			// 
			// parâmetrosToolStripMenuItem
			// 
			this.parâmetrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem3,
            this.matricularAlunosToolStripMenuItem,
            this.listaChamadaToolStripMenuItem,
            this.turmasCadastradasToolStripMenuItem});
			this.parâmetrosToolStripMenuItem.Name = "parâmetrosToolStripMenuItem";
			this.parâmetrosToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.parâmetrosToolStripMenuItem.Text = "Turmas";
			// 
			// cadastrarToolStripMenuItem3
			// 
			this.cadastrarToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarToolStripMenuItem3.Image")));
			this.cadastrarToolStripMenuItem3.Name = "cadastrarToolStripMenuItem3";
			this.cadastrarToolStripMenuItem3.Size = new System.Drawing.Size(184, 22);
			this.cadastrarToolStripMenuItem3.Text = "Cadastrar";
			this.cadastrarToolStripMenuItem3.Click += new System.EventHandler(this.cadastrarToolStripMenuItem3_Click);
			// 
			// matricularAlunosToolStripMenuItem
			// 
			this.matricularAlunosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("matricularAlunosToolStripMenuItem.Image")));
			this.matricularAlunosToolStripMenuItem.Name = "matricularAlunosToolStripMenuItem";
			this.matricularAlunosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.matricularAlunosToolStripMenuItem.Text = "Matricular Alunos";
			this.matricularAlunosToolStripMenuItem.Click += new System.EventHandler(this.matricularAlunosToolStripMenuItem_Click);
			// 
			// listaChamadaToolStripMenuItem
			// 
			this.listaChamadaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaChamadaToolStripMenuItem.Image")));
			this.listaChamadaToolStripMenuItem.Name = "listaChamadaToolStripMenuItem";
			this.listaChamadaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.listaChamadaToolStripMenuItem.Text = "Lista Chamada";
			this.listaChamadaToolStripMenuItem.Click += new System.EventHandler(this.listaChamadaToolStripMenuItem_Click);
			// 
			// turmasCadastradasToolStripMenuItem
			// 
			this.turmasCadastradasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("turmasCadastradasToolStripMenuItem.Image")));
			this.turmasCadastradasToolStripMenuItem.Name = "turmasCadastradasToolStripMenuItem";
			this.turmasCadastradasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.turmasCadastradasToolStripMenuItem.Text = "Turmas Cadastradas ";
			this.turmasCadastradasToolStripMenuItem.Click += new System.EventHandler(this.turmasCadastradasToolStripMenuItem_Click);
			// 
			// professoresToolStripMenuItem
			// 
			this.professoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem4,
            this.listaDeProfessoresToolStripMenuItem1});
			this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
			this.professoresToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.professoresToolStripMenuItem.Text = "Professores";
			// 
			// cadastrarToolStripMenuItem4
			// 
			this.cadastrarToolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarToolStripMenuItem4.Image")));
			this.cadastrarToolStripMenuItem4.Name = "cadastrarToolStripMenuItem4";
			this.cadastrarToolStripMenuItem4.Size = new System.Drawing.Size(177, 22);
			this.cadastrarToolStripMenuItem4.Text = "Cadastrar";
			this.cadastrarToolStripMenuItem4.Click += new System.EventHandler(this.cadastrarToolStripMenuItem4_Click);
			// 
			// listaDeProfessoresToolStripMenuItem1
			// 
			this.listaDeProfessoresToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("listaDeProfessoresToolStripMenuItem1.Image")));
			this.listaDeProfessoresToolStripMenuItem1.Name = "listaDeProfessoresToolStripMenuItem1";
			this.listaDeProfessoresToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
			this.listaDeProfessoresToolStripMenuItem1.Text = "Lista de Professores";
			this.listaDeProfessoresToolStripMenuItem1.Click += new System.EventHandler(this.listaDeProfessoresToolStripMenuItem1_Click);
			// 
			// CLIENTES
			// 
			this.CLIENTES.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CLIENTES.AutoSize = true;
			this.CLIENTES.BackColor = System.Drawing.Color.Transparent;
			this.CLIENTES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CLIENTES.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CLIENTES.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CLIENTES.Location = new System.Drawing.Point(139, 41);
			this.CLIENTES.Name = "CLIENTES";
			this.CLIENTES.Size = new System.Drawing.Size(348, 40);
			this.CLIENTES.TabIndex = 24;
			this.CLIENTES.Text = "ITAKA CADASTROS";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(175, 96);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(275, 191);
			this.pictureBox1.TabIndex = 25;
			this.pictureBox1.TabStop = false;
			// 
			// progressBar1
			// 
			this.progressBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.progressBar1.Location = new System.Drawing.Point(175, 260);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(275, 27);
			this.progressBar1.TabIndex = 26;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// timerCadResp
			// 
			this.timerCadResp.Tick += new System.EventHandler(this.timerCadResp_Tick);
			// 
			// timerCadAluno
			// 
			this.timerCadAluno.Tick += new System.EventHandler(this.timerCadAluno_Tick);
			// 
			// timerListaAluno
			// 
			this.timerListaAluno.Tick += new System.EventHandler(this.timerListaAluno_Tick);
			// 
			// timerListaResp
			// 
			this.timerListaResp.Tick += new System.EventHandler(this.timerListaResp_Tick);
			// 
			// timerCadCurso
			// 
			this.timerCadCurso.Tick += new System.EventHandler(this.timerCadCurso_Tick);
			// 
			// timerAddProf
			// 
			this.timerAddProf.Tick += new System.EventHandler(this.timerAddProf_Tick);
			// 
			// timerListaCurso
			// 
			this.timerListaCurso.Tick += new System.EventHandler(this.timerListaCurso_Tick);
			// 
			// timerCadTurmas
			// 
			this.timerCadTurmas.Tick += new System.EventHandler(this.timerCadTurmas_Tick);
			// 
			// timerMatriAluno
			// 
			this.timerMatriAluno.Tick += new System.EventHandler(this.timerMatriAluno_Tick);
			// 
			// timerListaDeCham
			// 
			this.timerListaDeCham.Tick += new System.EventHandler(this.timerListaDeCham_Tick);
			// 
			// timerListaTurmas
			// 
			this.timerListaTurmas.Tick += new System.EventHandler(this.timerListaTurmas_Tick);
			// 
			// timerCadProf
			// 
			this.timerCadProf.Tick += new System.EventHandler(this.timerCadProf_Tick);
			// 
			// timerListaDeProf
			// 
			this.timerListaDeProf.Tick += new System.EventHandler(this.timerListaDeProf_Tick);
			// 
			// MenuInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(612, 382);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.CLIENTES);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MenuInicial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Itaka Cadastros";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parâmetrosToolStripMenuItem;
        private System.Windows.Forms.Label CLIENTES;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem adicionarProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matricularAlunosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem frequênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsavelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaChamadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaResponsávelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasCadastradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProfessoresToolStripMenuItem1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timerCadResp;
        private System.Windows.Forms.Timer timerCadAluno;
        private System.Windows.Forms.Timer timerListaAluno;
        private System.Windows.Forms.Timer timerListaResp;
        private System.Windows.Forms.Timer timerCadCurso;
        private System.Windows.Forms.Timer timerAddProf;
        private System.Windows.Forms.Timer timerListaCurso;
        private System.Windows.Forms.Timer timerCadTurmas;
        private System.Windows.Forms.Timer timerMatriAluno;
        private System.Windows.Forms.Timer timerListaDeCham;
        private System.Windows.Forms.Timer timerListaTurmas;
        private System.Windows.Forms.Timer timerCadProf;
        private System.Windows.Forms.Timer timerListaDeProf;
    }
}

