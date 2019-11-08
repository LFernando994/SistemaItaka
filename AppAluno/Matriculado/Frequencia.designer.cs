namespace AppAluno
{
    partial class AppFrequencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppFrequencia));
            this.dgvFrequencia = new System.Windows.Forms.DataGridView();
            this.NomeFrequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CursoFrequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurmaFrequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAulasFrequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaltasFrequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentualFrequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFrequencia
            // 
            this.dgvFrequencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrequencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeFrequencia,
            this.CursoFrequencia,
            this.TurmaFrequencia,
            this.TotalAulasFrequencia,
            this.FaltasFrequencia,
            this.PercentualFrequencia});
            this.dgvFrequencia.Location = new System.Drawing.Point(12, 63);
            this.dgvFrequencia.Name = "dgvFrequencia";
            this.dgvFrequencia.Size = new System.Drawing.Size(644, 175);
            this.dgvFrequencia.TabIndex = 0;
            // 
            // NomeFrequencia
            // 
            this.NomeFrequencia.HeaderText = "Nome";
            this.NomeFrequencia.Name = "NomeFrequencia";
            // 
            // CursoFrequencia
            // 
            this.CursoFrequencia.HeaderText = "Curso";
            this.CursoFrequencia.Name = "CursoFrequencia";
            // 
            // TurmaFrequencia
            // 
            this.TurmaFrequencia.HeaderText = "Turma";
            this.TurmaFrequencia.Name = "TurmaFrequencia";
            // 
            // TotalAulasFrequencia
            // 
            this.TotalAulasFrequencia.HeaderText = "Aulas";
            this.TotalAulasFrequencia.Name = "TotalAulasFrequencia";
            // 
            // FaltasFrequencia
            // 
            this.FaltasFrequencia.HeaderText = "Faltas";
            this.FaltasFrequencia.Name = "FaltasFrequencia";
            // 
            // PercentualFrequencia
            // 
            this.PercentualFrequencia.HeaderText = "% Frequência";
            this.PercentualFrequencia.Name = "PercentualFrequencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frequência ";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(583, 246);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 32;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // AppFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 283);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFrequencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppFrequencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequência ";
            this.Load += new System.EventHandler(this.Frequencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFrequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFrequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CursoFrequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurmaFrequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAulasFrequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaltasFrequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentualFrequencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
    }
}