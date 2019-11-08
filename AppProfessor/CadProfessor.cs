using CadastroItaka.DataSource;
using CadastroItaka.Modelos;
using CadastroItaka.Modelos.Pessoas;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppProfessor
{
    public partial class CadProfessor : Form
    {
        private Pessoa pessoa;
		private Professor prof;

		public CadProfessor()
        {
            InitializeComponent();
			prof = new Professor();
		}

		/// <summary>
		/// Método que busca os dados de professor cadastrado e preenche campos do forms 'CadProfessor'.
		/// </summary>
		/// <param name="matricula">Número de matrícula do professor (Id).</param>
		public void GetProfessor(int matricula)
        {
			var query = from pessoa in Pessoa.GetPessoas()
						join professor in prof.GetProfessores() on pessoa.Id equals professor.Id
                        join endereco in new Endereco().GetEnderecos() on pessoa.Id equals endereco.IdPessoa
                        where pessoa.Id == matricula
                        select new
                        {
                            Nome = pessoa.Nome,
                            Rg = pessoa.Rg,
                            Cpf = pessoa.Cpf,
                            Formacao = professor.Formacao,
                            Email = pessoa.Email,
                            DataCadastro = pessoa.DataCadastro,
                            Sexo = pessoa.Sexo,
                            TelContato = pessoa.TelContato,
                            TelCelular = pessoa.TelCelular,
                            DataDeNascimento = pessoa.DataNascimento,
                            Cep = endereco.Cep,
                            Endereco = endereco.Rua,
                            Complemento = endereco.Complemento,
                            Numero = endereco.Numero,
                            Bairro = endereco.Bairro,
                            Cidade = endereco.Cidade,
                            Estado = endereco.Estado
                        };

            txtNomeProfessor.Text = query.Select(x => x.Nome).FirstOrDefault();
            txtCpfProfessor.Text = query.Select(x => x.Cpf).FirstOrDefault();
            txtRGProfessor.Text = query.Select(x => x.Rg).FirstOrDefault();
            txtEmailProfessor.Text = query.Select(x => x.Email).FirstOrDefault();
            cbxSexoProfessor.Text = query.Select(x => x.Sexo).FirstOrDefault();
            txtDataDeNascimentoProfessor.Text = (query.Select(x => x.DataDeNascimento).FirstOrDefault()).ToString();
            txtTelefoneContatoProfessor.Text = query.Select(x => x.TelContato).FirstOrDefault();
            txtTelefoneCelularProfessor.Text = query.Select(x => x.TelCelular).FirstOrDefault();
            txtFormacaoProfessor.Text = query.Select(x => x.Formacao).FirstOrDefault();
            txtCepProfessor.Text = query.Select(x => x.Cep).FirstOrDefault();
            txtEnderecoProfessor.Text = query.Select(x => x.Endereco).FirstOrDefault();
            txtComplementoProfessor.Text = query.Select(x => x.Complemento).FirstOrDefault();
            txtNumeroProfessor.Text = query.Select(x => x.Numero).FirstOrDefault();
            txtBairroProfessor.Text = query.Select(x => x.Bairro).FirstOrDefault();
            txtCidadeProfessor.Text = query.Select(x => x.Cidade).FirstOrDefault();
            txtUfProfessor.Text = query.Select(x => x.Estado).FirstOrDefault();

            txtCpfProfessor.Enabled = false;
        }

        /// <summary>
        /// Limpa campos de cadastro de professor.
        /// </summary>
        private void LimparCampos()
        {
            txtNomeProfessor.Text = string.Empty;
            txtCpfProfessor.Text = string.Empty;
            txtRGProfessor.Text = string.Empty;
            txtEmailProfessor.Text = string.Empty;
            cbxSexoProfessor.Text = string.Empty;
            txtDataDeNascimentoProfessor.Text = string.Empty;
            txtTelefoneContatoProfessor.Text = string.Empty;
            txtTelefoneCelularProfessor.Text = string.Empty;
            txtFormacaoProfessor.Text = string.Empty;
            txtCepProfessor.Text = string.Empty;
            txtEnderecoProfessor.Text = string.Empty;
            txtComplementoProfessor.Text = string.Empty;
            txtNumeroProfessor.Text = string.Empty;
            txtBairroProfessor.Text = string.Empty; 
            txtCidadeProfessor.Text = string.Empty;
            txtUfProfessor.Text = string.Empty;
        }

        #region Button
        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Professor professor = new Professor(txtNomeProfessor.Text, txtCpfProfessor.Text, txtRGProfessor.Text, txtEmailProfessor.Text,
                    cbxSexoProfessor.Text, Convert.ToDateTime(txtDataDeNascimentoProfessor.Text).Date, DateTime.Now.Date, txtTelefoneContatoProfessor.Text, txtTelefoneCelularProfessor.Text,
                    txtFormacaoProfessor.Text);

                string cpfProfessor = txtCpfProfessor.Text.Replace(".", string.Empty).Replace("-", string.Empty).ToString();

                if (professor.Cadastrar())
                {
                    Endereco endereco = new Endereco(professor.Id, txtEnderecoProfessor.Text, txtCepProfessor.Text, txtNumeroProfessor.Text, txtComplementoProfessor.Text, txtBairroProfessor.Text,
                                                  txtCidadeProfessor.Text, txtUfProfessor.Text);
                    endereco.Cadastrar();

                    MessageBox.Show("Professor cadastrado com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    professor.Id = prof.GetId(cpfProfessor);

                    if (professor.Editar())
                    {
                        Endereco endereco = new Endereco(professor.Id, txtEnderecoProfessor.Text, txtCepProfessor.Text, txtNumeroProfessor.Text, txtComplementoProfessor.Text, txtBairroProfessor.Text,
                                                                      txtCidadeProfessor.Text, txtUfProfessor.Text);
                        endereco.Id = endereco.GetId(professor.Id);
                        endereco.Editar();

                        MessageBox.Show("Cadastro de Professor editado com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (MessageBoxButtons.OK == 0)
                {
                    LimparCampos();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVoltarCadastroResponsavel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region KeyPress
        private void txtNomeProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Letras, BackSpace(apagar) e Espaço
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCpfProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtDataDeNascimentoProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtCepProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtNumeroProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtTelefoneCelularProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtTelefoneContatoProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
		#endregion

	}
}
