namespace AppAluno
{
	partial class CadLista
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadLista));
            this.GvAlunos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dbItakaDataSet = new AppAluno.DbItakaDataSet();
            this.dbItakaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosTableAdapter = new AppAluno.DbItakaDataSetTableAdapters.AlunosTableAdapter();
            this.dbItakaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GvAlunos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbItakaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbItakaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbItakaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GvAlunos
            // 
            this.GvAlunos.AllowUserToDeleteRows = false;
            this.GvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvAlunos.Location = new System.Drawing.Point(21, 31);
            this.GvAlunos.Name = "GvAlunos";
            this.GvAlunos.Size = new System.Drawing.Size(926, 473);
            this.GvAlunos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.GvAlunos);
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 559);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alunos Matriculados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Frequência";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(739, 510);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 28);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(849, 510);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 28);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(896, 591);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(98, 28);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dbItakaDataSet
            // 
            this.dbItakaDataSet.DataSetName = "DbItakaDataSet1";
            this.dbItakaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbItakaDataSet1BindingSource
            // 
            this.dbItakaDataSet1BindingSource.DataSource = this.dbItakaDataSet;
            this.dbItakaDataSet1BindingSource.Position = 0;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.dbItakaDataSet1BindingSource;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // CadLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 646);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos Matriculados";
            this.Load += new System.EventHandler(this.CadLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvAlunos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbItakaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbItakaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbItakaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView GvAlunos;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.BindingSource dbItakaDataSetBindingSource;
		private System.Windows.Forms.BindingSource dbItakaDataSet1BindingSource;
		private DbItakaDataSet dbItakaDataSet;
		private System.Windows.Forms.BindingSource alunosBindingSource;
		private DbItakaDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

