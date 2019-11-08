namespace AppAluno
{
    partial class CadAlunoNaTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadAlunoNaTurma));
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.btnVoltarMatricularNaTurma = new System.Windows.Forms.Button();
            this.btnSalvarMatricula = new System.Windows.Forms.Button();
            this.dgvMatriculados = new System.Windows.Forms.DataGridView();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(19, 33);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(342, 289);
            this.dgvAlunos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matrícula Aluno";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAlunos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 344);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alunos ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTurmas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(434, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 344);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turmas";
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmas.Location = new System.Drawing.Point(17, 33);
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.Size = new System.Drawing.Size(346, 289);
            this.dgvTurmas.TabIndex = 1;
            // 
            // btnVoltarMatricularNaTurma
            // 
            this.btnVoltarMatricularNaTurma.Location = new System.Drawing.Point(739, 622);
            this.btnVoltarMatricularNaTurma.Name = "btnVoltarMatricularNaTurma";
            this.btnVoltarMatricularNaTurma.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarMatricularNaTurma.TabIndex = 2;
            this.btnVoltarMatricularNaTurma.Text = "Voltar";
            this.btnVoltarMatricularNaTurma.UseVisualStyleBackColor = true;
            this.btnVoltarMatricularNaTurma.Click += new System.EventHandler(this.btnVoltarMatricularNaTurma_Click);
            // 
            // btnSalvarMatricula
            // 
            this.btnSalvarMatricula.Location = new System.Drawing.Point(648, 622);
            this.btnSalvarMatricula.Name = "btnSalvarMatricula";
            this.btnSalvarMatricula.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarMatricula.TabIndex = 1;
            this.btnSalvarMatricula.Text = "Salvar";
            this.btnSalvarMatricula.UseVisualStyleBackColor = true;
            this.btnSalvarMatricula.Click += new System.EventHandler(this.btnSalvarMatricula_Click);
            // 
            // dgvMatriculados
            // 
            this.dgvMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RG,
            this.Nome,
            this.NomeResponsavel,
            this.DataCadastro,
            this.IdTurma,
            this.Curso,
            this.Professor});
            this.dgvMatriculados.Location = new System.Drawing.Point(29, 405);
            this.dgvMatriculados.Name = "dgvMatriculados";
            this.dgvMatriculados.Size = new System.Drawing.Size(785, 202);
            this.dgvMatriculados.TabIndex = 23;
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // NomeResponsavel
            // 
            this.NomeResponsavel.HeaderText = "NomeResponsavel";
            this.NomeResponsavel.Name = "NomeResponsavel";
            // 
            // DataCadastro
            // 
            this.DataCadastro.HeaderText = "DataCadastro";
            this.DataCadastro.Name = "DataCadastro";
            // 
            // IdTurma
            // 
            this.IdTurma.HeaderText = "IdTurma";
            this.IdTurma.Name = "IdTurma";
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            // 
            // Professor
            // 
            this.Professor.HeaderText = "Professor";
            this.Professor.Name = "Professor";
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(728, 376);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(42, 23);
            this.btnMais.TabIndex = 30;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(775, 376);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(39, 23);
            this.btnMenos.TabIndex = 31;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // CadAlunoNaTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 652);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.dgvMatriculados);
            this.Controls.Add(this.btnVoltarMatricularNaTurma);
            this.Controls.Add(this.btnSalvarMatricula);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadAlunoNaTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricular Aluno";
            this.Load += new System.EventHandler(this.CadAlunoNaTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTurmas;
        private System.Windows.Forms.Button btnVoltarMatricularNaTurma;
        private System.Windows.Forms.Button btnSalvarMatricula;
        private System.Windows.Forms.DataGridView dgvMatriculados;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeResponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Professor;
    }
}