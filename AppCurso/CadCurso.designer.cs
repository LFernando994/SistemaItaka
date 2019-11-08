namespace AppCurso
{
    partial class CadCurso
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCurso));
			this.lblNomeDaAtividade = new System.Windows.Forms.Label();
			this.lblCargaHoraria = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtNomeDaAtividade = new System.Windows.Forms.TextBox();
			this.txtCargaHoraria = new System.Windows.Forms.TextBox();
			this.btnSalvarCurso = new System.Windows.Forms.Button();
			this.btnVoltarCurso = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNomeDaAtividade
			// 
			this.lblNomeDaAtividade.AutoSize = true;
			this.lblNomeDaAtividade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeDaAtividade.Location = new System.Drawing.Point(19, 48);
			this.lblNomeDaAtividade.Name = "lblNomeDaAtividade";
			this.lblNomeDaAtividade.Size = new System.Drawing.Size(143, 19);
			this.lblNomeDaAtividade.TabIndex = 0;
			this.lblNomeDaAtividade.Text = "Nome da atividade : ";
			// 
			// lblCargaHoraria
			// 
			this.lblCargaHoraria.AutoSize = true;
			this.lblCargaHoraria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCargaHoraria.Location = new System.Drawing.Point(19, 95);
			this.lblCargaHoraria.Name = "lblCargaHoraria";
			this.lblCargaHoraria.Size = new System.Drawing.Size(107, 19);
			this.lblCargaHoraria.TabIndex = 1;
			this.lblCargaHoraria.Text = "Carga Horária :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtNomeDaAtividade);
			this.groupBox1.Controls.Add(this.txtCargaHoraria);
			this.groupBox1.Controls.Add(this.lblCargaHoraria);
			this.groupBox1.Controls.Add(this.lblNomeDaAtividade);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(379, 187);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Curso";
			// 
			// txtNomeDaAtividade
			// 
			this.txtNomeDaAtividade.Location = new System.Drawing.Point(168, 49);
			this.txtNomeDaAtividade.Name = "txtNomeDaAtividade";
			this.txtNomeDaAtividade.Size = new System.Drawing.Size(172, 24);
			this.txtNomeDaAtividade.TabIndex = 1;
			this.txtNomeDaAtividade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeDaAtividade_KeyPress);
			// 
			// txtCargaHoraria
			// 
			this.txtCargaHoraria.Location = new System.Drawing.Point(132, 94);
			this.txtCargaHoraria.Name = "txtCargaHoraria";
			this.txtCargaHoraria.Size = new System.Drawing.Size(70, 24);
			this.txtCargaHoraria.TabIndex = 2;
			this.txtCargaHoraria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargaHoraria_KeyPress);
			// 
			// btnSalvarCurso
			// 
			this.btnSalvarCurso.Location = new System.Drawing.Point(213, 223);
			this.btnSalvarCurso.Name = "btnSalvarCurso";
			this.btnSalvarCurso.Size = new System.Drawing.Size(86, 25);
			this.btnSalvarCurso.TabIndex = 3;
			this.btnSalvarCurso.Text = "Salvar";
			this.btnSalvarCurso.UseVisualStyleBackColor = true;
			this.btnSalvarCurso.Click += new System.EventHandler(this.btnSalvarCurso_Click);
			// 
			// btnVoltarCurso
			// 
			this.btnVoltarCurso.Location = new System.Drawing.Point(305, 223);
			this.btnVoltarCurso.Name = "btnVoltarCurso";
			this.btnVoltarCurso.Size = new System.Drawing.Size(86, 25);
			this.btnVoltarCurso.TabIndex = 4;
			this.btnVoltarCurso.Text = "Voltar";
			this.btnVoltarCurso.UseVisualStyleBackColor = true;
			this.btnVoltarCurso.Click += new System.EventHandler(this.btnVoltarCurso_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(115, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Cadastro Curso";
			// 
			// CadCurso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 263);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnVoltarCurso);
			this.Controls.Add(this.btnSalvarCurso);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CadCurso";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar Curso";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeDaAtividade;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeDaAtividade;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.Button btnSalvarCurso;
        private System.Windows.Forms.Button btnVoltarCurso;
        private System.Windows.Forms.Label label1;
    }
}