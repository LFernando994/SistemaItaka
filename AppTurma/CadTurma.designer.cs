namespace AppTurma
{
    partial class CadTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadTurma));
            this.btnSalvarTurma = new System.Windows.Forms.Button();
            this.btnVoltarTurma = new System.Windows.Forms.Button();
            this.cbxCursoTurma = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.CbProf = new System.Windows.Forms.ComboBox();
            this.txtHoraFinal = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.cbxTurnoTurma = new System.Windows.Forms.ComboBox();
            this.lblTurnoTurma = new System.Windows.Forms.Label();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblProfessorTurma = new System.Windows.Forms.Label();
            this.lblCursoTurma = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMatriculados = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarTurma
            // 
            this.btnSalvarTurma.Location = new System.Drawing.Point(715, 557);
            this.btnSalvarTurma.Name = "btnSalvarTurma";
            this.btnSalvarTurma.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarTurma.TabIndex = 8;
            this.btnSalvarTurma.Text = "Salvar";
            this.btnSalvarTurma.UseVisualStyleBackColor = true;
            this.btnSalvarTurma.Click += new System.EventHandler(this.btnSalvarTurma_Click);
            // 
            // btnVoltarTurma
            // 
            this.btnVoltarTurma.Location = new System.Drawing.Point(796, 557);
            this.btnVoltarTurma.Name = "btnVoltarTurma";
            this.btnVoltarTurma.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarTurma.TabIndex = 1;
            this.btnVoltarTurma.Text = "Voltar";
            this.btnVoltarTurma.UseVisualStyleBackColor = true;
            this.btnVoltarTurma.Click += new System.EventHandler(this.btnVoltarTurma_Click);
            // 
            // cbxCursoTurma
            // 
            this.cbxCursoTurma.FormattingEnabled = true;
            this.cbxCursoTurma.Location = new System.Drawing.Point(229, 33);
            this.cbxCursoTurma.Name = "cbxCursoTurma";
            this.cbxCursoTurma.Size = new System.Drawing.Size(251, 23);
            this.cbxCursoTurma.TabIndex = 1;
            this.cbxCursoTurma.SelectedIndexChanged += new System.EventHandler(this.cbxCursoTurma_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTurma);
            this.groupBox1.Controls.Add(this.lblTurma);
            this.groupBox1.Controls.Add(this.CbProf);
            this.groupBox1.Controls.Add(this.txtHoraFinal);
            this.groupBox1.Controls.Add(this.txtHoraInicio);
            this.groupBox1.Controls.Add(this.txtDataFinal);
            this.groupBox1.Controls.Add(this.cbxTurnoTurma);
            this.groupBox1.Controls.Add(this.lblTurnoTurma);
            this.groupBox1.Controls.Add(this.lblHoraFinal);
            this.groupBox1.Controls.Add(this.lblHoraInicio);
            this.groupBox1.Controls.Add(this.txtDataInicio);
            this.groupBox1.Controls.Add(this.lblDataFinal);
            this.groupBox1.Controls.Add(this.lblDataInicio);
            this.groupBox1.Controls.Add(this.lblProfessorTurma);
            this.groupBox1.Controls.Add(this.lblCursoTurma);
            this.groupBox1.Controls.Add(this.cbxCursoTurma);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(70, 33);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(100, 23);
            this.txtTurma.TabIndex = 14;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(19, 36);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(44, 15);
            this.lblTurma.TabIndex = 13;
            this.lblTurma.Text = "Turma:";
            // 
            // CbProf
            // 
            this.CbProf.FormattingEnabled = true;
            this.CbProf.Location = new System.Drawing.Point(575, 36);
            this.CbProf.Name = "CbProf";
            this.CbProf.Size = new System.Drawing.Size(251, 23);
            this.CbProf.TabIndex = 2;
            // 
            // txtHoraFinal
            // 
            this.txtHoraFinal.Location = new System.Drawing.Point(592, 82);
            this.txtHoraFinal.Mask = "00:00";
            this.txtHoraFinal.Name = "txtHoraFinal";
            this.txtHoraFinal.Size = new System.Drawing.Size(43, 23);
            this.txtHoraFinal.TabIndex = 6;
            this.txtHoraFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoraFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoraFinal_KeyPress);
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(463, 82);
            this.txtHoraInicio.Mask = "00:00";
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(43, 23);
            this.txtHoraInicio.TabIndex = 5;
            this.txtHoraInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoraInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoraInicio_KeyPress);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(273, 82);
            this.txtDataFinal.Mask = "00/00/0000";
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(80, 23);
            this.txtDataFinal.TabIndex = 4;
            this.txtDataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataFinal_KeyPress);
            // 
            // cbxTurnoTurma
            // 
            this.cbxTurnoTurma.FormattingEnabled = true;
            this.cbxTurnoTurma.Items.AddRange(new object[] {
            "Manhã",
            "Tarde"});
            this.cbxTurnoTurma.Location = new System.Drawing.Point(709, 82);
            this.cbxTurnoTurma.Name = "cbxTurnoTurma";
            this.cbxTurnoTurma.Size = new System.Drawing.Size(70, 23);
            this.cbxTurnoTurma.TabIndex = 7;
            // 
            // lblTurnoTurma
            // 
            this.lblTurnoTurma.AutoSize = true;
            this.lblTurnoTurma.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnoTurma.Location = new System.Drawing.Point(659, 85);
            this.lblTurnoTurma.Name = "lblTurnoTurma";
            this.lblTurnoTurma.Size = new System.Drawing.Size(44, 15);
            this.lblTurnoTurma.TabIndex = 12;
            this.lblTurnoTurma.Text = "Turno :";
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFinal.Location = new System.Drawing.Point(512, 85);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(74, 15);
            this.lblHoraFinal.TabIndex = 11;
            this.lblHoraFinal.Text = " Hora Final :";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(380, 85);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(77, 15);
            this.lblHoraInicio.TabIndex = 10;
            this.lblHoraInicio.Text = " Hora Início :";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(98, 82);
            this.txtDataInicio.Mask = "00/00/0000";
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(83, 23);
            this.txtDataInicio.TabIndex = 3;
            this.txtDataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataInicio_KeyPress);
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.Location = new System.Drawing.Point(197, 85);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(70, 15);
            this.lblDataFinal.TabIndex = 8;
            this.lblDataFinal.Text = "Data Final :";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.Location = new System.Drawing.Point(19, 85);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(73, 15);
            this.lblDataInicio.TabIndex = 7;
            this.lblDataInicio.Text = "Data Início :";
            // 
            // lblProfessorTurma
            // 
            this.lblProfessorTurma.AutoSize = true;
            this.lblProfessorTurma.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorTurma.Location = new System.Drawing.Point(487, 39);
            this.lblProfessorTurma.Name = "lblProfessorTurma";
            this.lblProfessorTurma.Size = new System.Drawing.Size(81, 15);
            this.lblProfessorTurma.TabIndex = 6;
            this.lblProfessorTurma.Text = "Professor(a) :";
            // 
            // lblCursoTurma
            // 
            this.lblCursoTurma.AutoSize = true;
            this.lblCursoTurma.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursoTurma.Location = new System.Drawing.Point(177, 36);
            this.lblCursoTurma.Name = "lblCursoTurma";
            this.lblCursoTurma.Size = new System.Drawing.Size(45, 15);
            this.lblCursoTurma.TabIndex = 5;
            this.lblCursoTurma.Text = "Curso :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMatriculados);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(452, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 361);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriculados";
            // 
            // dgvMatriculados
            // 
            this.dgvMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.RG,
            this.DataMatricula});
            this.dgvMatriculados.Location = new System.Drawing.Point(11, 28);
            this.dgvMatriculados.Name = "dgvMatriculados";
            this.dgvMatriculados.Size = new System.Drawing.Size(399, 317);
            this.dgvMatriculados.TabIndex = 1;
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
            // DataMatricula
            // 
            this.DataMatricula.HeaderText = "DataMatricula";
            this.DataMatricula.Name = "DataMatricula";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAlunos);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 361);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alunos";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(14, 28);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(399, 317);
            this.dgvAlunos.TabIndex = 1;
            // 
            // btnMatricular
            // 
            this.btnMatricular.Location = new System.Drawing.Point(382, 520);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(64, 23);
            this.btnMatricular.TabIndex = 11;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(807, 520);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(64, 23);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Cadastro Turma";
            // 
            // CadTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 598);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnVoltarTurma);
            this.Controls.Add(this.btnSalvarTurma);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Turma";
            this.Load += new System.EventHandler(this.CadTurma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarTurma;
        private System.Windows.Forms.Button btnVoltarTurma;
        private System.Windows.Forms.ComboBox cbxCursoTurma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProfessorTurma;
        private System.Windows.Forms.Label lblCursoTurma;
        private System.Windows.Forms.MaskedTextBox txtHoraFinal;
        private System.Windows.Forms.MaskedTextBox txtHoraInicio;
        private System.Windows.Forms.MaskedTextBox txtDataFinal;
        private System.Windows.Forms.ComboBox cbxTurnoTurma;
        private System.Windows.Forms.Label lblTurnoTurma;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.MaskedTextBox txtDataInicio;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicio;
		private System.Windows.Forms.ComboBox CbProf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMatriculados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataMatricula;
        private System.Windows.Forms.Label label3;
    }
}