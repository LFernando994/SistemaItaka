namespace AppCurso
{
    partial class ListaCurso
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCurso));
			this.dgvCursos = new System.Windows.Forms.DataGridView();
			this.Cursos = new System.Windows.Forms.GroupBox();
			this.btnTurmas = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
			this.Cursos.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvCursos
			// 
			this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCursos.Location = new System.Drawing.Point(6, 19);
			this.dgvCursos.Name = "dgvCursos";
			this.dgvCursos.Size = new System.Drawing.Size(770, 241);
			this.dgvCursos.TabIndex = 0;
			// 
			// Cursos
			// 
			this.Cursos.Controls.Add(this.btnTurmas);
			this.Cursos.Controls.Add(this.btnEditar);
			this.Cursos.Controls.Add(this.dgvCursos);
			this.Cursos.Controls.Add(this.btnExcluir);
			this.Cursos.Location = new System.Drawing.Point(17, 40);
			this.Cursos.Name = "Cursos";
			this.Cursos.Size = new System.Drawing.Size(782, 312);
			this.Cursos.TabIndex = 1;
			this.Cursos.TabStop = false;
			this.Cursos.Text = "Cursos";
			// 
			// btnTurmas
			// 
			this.btnTurmas.Location = new System.Drawing.Point(539, 271);
			this.btnTurmas.Name = "btnTurmas";
			this.btnTurmas.Size = new System.Drawing.Size(75, 23);
			this.btnTurmas.TabIndex = 43;
			this.btnTurmas.Text = "Turmas";
			this.btnTurmas.UseVisualStyleBackColor = true;
			this.btnTurmas.Click += new System.EventHandler(this.btnTurmas_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(620, 271);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 23);
			this.btnEditar.TabIndex = 14;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(701, 271);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 13;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Location = new System.Drawing.Point(724, 367);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(75, 23);
			this.btnVoltar.TabIndex = 15;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(295, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(226, 25);
			this.lblTitulo.TabIndex = 42;
			this.lblTitulo.Text = "Cursos Cadastrados";
			// 
			// ListaCurso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 402);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.Cursos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ListaCurso";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cursos Cadastrados";
			this.Load += new System.EventHandler(this.ListaCurso_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
			this.Cursos.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.GroupBox Cursos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnTurmas;
    }
}