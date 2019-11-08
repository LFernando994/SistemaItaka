using CadastroItaka.Modelos;
using CadastroItaka.Modelos.Pessoas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppAluno.Cadastros
{
	public partial class CADResponsavelAluno : Form
	{
		public CADResponsavelAluno()
		{
			InitializeComponent();
		}

		private void CadAluno_Load(object sender, EventArgs e)
		{

		}

		private void btnSalvarCadastroResponsavel_Click(object sender, EventArgs e)
		{
			try
			{
				//instanciando responsável e passando valores do forms aos seus atributos
				Responsavel responsavel = new Responsavel(txtNomeResponsavel.Text, txtCpfResponsavel.Text, txtRGResponsavel.Text, txtEmailResponsavel.Text,
					cbxSexoResponsavel.Text, Convert.ToDateTime(txtDataDeNascimentoResponsavel.Text).Date, DateTime.Now.Date, txtTelefoneContatoResponsavel.Text, txtTelefoneCelularResponsavel.Text,
					txtParentescoResponsavel.Text, txtOcupacaoResponsavel.Text,
					double.Parse(txtRendaFamiliarResponsavel.Text), txtNomeContato.Text);

				if (responsavel.Cadastrar())
				{
					MessageBox.Show("Responsável cadastrado com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
					//chamada de metódo com "filhos" do responsável
					responsavel.Alunos = GetAlunos(responsavel.Id);

					Endereco endereco = new Endereco(responsavel.Id, txtEnderecoResponsavel.Text, txtCepResponsavel.Text, txtNumeroResponsavel.Text, txtComplementoResponsavel.Text, txtBairroResponsavel.Text,
											  txtCidadeResponsavel.Text, txtUfResponsavel.Text);
					endereco.Cadastrar();
				}
                else
                {
                    MessageBox.Show("CPF Inválido!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// Método que busca alunos do gridView e faz chamada de cadastro
		/// </summary>
		/// <param name="idResponsavel"></param>
		/// <returns></returns>
		private List<Aluno> GetAlunos(int idResponsavel)
		{
			List<Aluno> alunos = new List<Aluno>();

			try
			{
				foreach (DataGridViewRow row in dgvAlunos.Rows)
				{
					if (row.Index != (dgvAlunos.Rows.Count - 1))
					{
						string rg = dgvAlunos.Rows[row.Index].Cells["RG"].Value.ToString();
						string nome = dgvAlunos.Rows[row.Index].Cells["Nome"].Value.ToString();
						string cpf = dgvAlunos.Rows[row.Index].Cells["CPF"].Value.ToString();
						string email = dgvAlunos.Rows[row.Index].Cells["Email"].Value.ToString();
						string sexo = dgvAlunos.Rows[row.Index].Cells["Sexo"].Value.ToString();
						string dataNascimento = dgvAlunos.Rows[row.Index].Cells["DataNascimento"].Value.ToString();
						string Status = dgvAlunos.Rows[row.Index].Cells["Status"].Value.ToString();
						string Aprovacao = dgvAlunos.Rows[row.Index].Cells["Aprovado"].Value.ToString();

                        bool status;
						bool aprovacao;

						if (Status == "Inativo")
						{
							status = false;
						}
						else { status = true; }

                        if (Aprovacao == "Sim")
						{
							aprovacao = true;
						}
						else { aprovacao = false; }

						Aluno aluno = new Aluno(nome, cpf, rg, email, sexo, Convert.ToDateTime(dataNascimento), DateTime.Now.Date, txtTelefoneContatoAluno.Text, txtTelefoneCelularAluno.Text, status, aprovacao);
						aluno.IdResponsavel = idResponsavel;

						if (aluno.Cadastrar())
						{
							alunos.Add(aluno);
						}
					}
				}

				if (alunos.Count == 1)
				{
					MessageBox.Show("Aluno(a) cadastrado com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (alunos.Count > 1)
				{
					MessageBox.Show("Aluno(a)s cadastrado com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			return alunos;
		}

		private void btnSairCadastroResponsavel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMais_Click(object sender, EventArgs e)
		{
            string status = "Ativo";
            string aprovado = "Não";

            //if (CKBAtivo.Checked == true)
            //{
            //	status = "Ativo";
            //}
            //else { status = "Inativo"; }
            //if (CKBSim.Checked == true)
            //{
            //	aprovado = "Sim";
            //}
            //else { aprovado = "Não"; }

            dgvAlunos.Rows.Add(txtRGAluno.Text, txtNomeAluno.Text, txtCpfAluno.Text, txtEmailAluno.Text, cbxSexoAluno.Text, txtDataDeNascimentoAluno.Text,status,aprovado);
			LimparCamposAluno();
		}

		private void btnMenos_Click(object sender, EventArgs e)
		{
			dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);

			LimparCamposAluno();
		}

		public void LimparCamposAluno()
		{
			txtRGAluno.Text = string.Empty;
			txtNomeAluno.Text = string.Empty;
			txtCpfAluno.Text = string.Empty;
			txtEmailAluno.Text = string.Empty;
			cbxSexoAluno.Text = string.Empty;
			txtDataDeNascimentoAluno.Text = string.Empty;
		}

		private void txtNomeResponsavel_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtRGResponsavel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void txtNomeResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Letras, BackSpace(apagar) e Espaço
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtBairroResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Letras, BackSpace(apagar) e Espaço
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtOcupacaoResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Letras, BackSpace(apagar) e Espaço
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtParentescoResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Letras, BackSpace(apagar) e Espaço
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtNomeContato_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Letras, BackSpace(apagar) e Espaço
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtNomeAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Letras, BackSpace(apagar) e Espaço
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtCpfResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtDataDeNascimentoResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtCepResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtNumeroResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtTelefoneCelularResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtTelefoneFixoResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtTelefoneContatoResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnVoltarCadastroResponsavel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
