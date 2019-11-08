namespace AppAluno
{
    partial class Presença
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presença));
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.Ausente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Buscar = new System.Windows.Forms.Button();
            this.btnVoltarMatricularNaTurma = new System.Windows.Forms.Button();
            this.btnSalvarMatricula = new System.Windows.Forms.Button();
            this.lblListaPresenca = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTurma
            // 
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Location = new System.Drawing.Point(24, 25);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.Size = new System.Drawing.Size(350, 511);
            this.dgvTurma.TabIndex = 0;
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ausente});
            this.dgvAluno.Location = new System.Drawing.Point(431, 58);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(410, 511);
            this.dgvAluno.TabIndex = 1;
            // 
            // Ausente
            // 
            this.Ausente.HeaderText = "Ausente";
            this.Ausente.Name = "Ausente";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(330, 603);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // btnVoltarMatricularNaTurma
            // 
            this.btnVoltarMatricularNaTurma.Location = new System.Drawing.Point(780, 603);
            this.btnVoltarMatricularNaTurma.Name = "btnVoltarMatricularNaTurma";
            this.btnVoltarMatricularNaTurma.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarMatricularNaTurma.TabIndex = 6;
            this.btnVoltarMatricularNaTurma.Text = "Voltar";
            this.btnVoltarMatricularNaTurma.UseVisualStyleBackColor = true;
            this.btnVoltarMatricularNaTurma.Click += new System.EventHandler(this.btnVoltarMatricularNaTurma_Click);
            // 
            // btnSalvarMatricula
            // 
            this.btnSalvarMatricula.Location = new System.Drawing.Point(689, 603);
            this.btnSalvarMatricula.Name = "btnSalvarMatricula";
            this.btnSalvarMatricula.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarMatricula.TabIndex = 5;
            this.btnSalvarMatricula.Text = "Salvar";
            this.btnSalvarMatricula.UseVisualStyleBackColor = true;
            this.btnSalvarMatricula.Click += new System.EventHandler(this.btnSalvarMatricula_Click);
            // 
            // lblListaPresenca
            // 
            this.lblListaPresenca.AutoSize = true;
            this.lblListaPresenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPresenca.Location = new System.Drawing.Point(323, 4);
            this.lblListaPresenca.Name = "lblListaPresenca";
            this.lblListaPresenca.Size = new System.Drawing.Size(222, 29);
            this.lblListaPresenca.TabIndex = 8;
            this.lblListaPresenca.Text = "Lista de Chamada";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(411, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 559);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alunos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTurma);
            this.groupBox3.Location = new System.Drawing.Point(11, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 559);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar Turma";
            // 
            // Presença
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 642);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.lblListaPresenca);
            this.Controls.Add(this.btnVoltarMatricularNaTurma);
            this.Controls.Add(this.btnSalvarMatricula);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Presença";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Chamada ";
            this.Load += new System.EventHandler(this.Presença_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button btnVoltarMatricularNaTurma;
        private System.Windows.Forms.Button btnSalvarMatricula;
        private System.Windows.Forms.Label lblListaPresenca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ausente;
    }
}