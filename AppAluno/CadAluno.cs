using CadastroItaka.Modelos;
using CadastroItaka.Modelos.Pessoas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppAluno
{
    public partial class CadAluno : Form
    {
        public CadAluno()
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
                    cbxSexoResponsavel.Text, Convert.ToDateTime(txtDataDeNascimentoResponsavel.Text).Date, DateTime.Now.Date,
                    txtParentescoResponsavel.Text, txtOcupacaoResponsavel.Text,
                    double.Parse(txtRendaFamiliarResponsavel.Text), txtNomeContato.Text, txtTelefoneContato.Text, txtTelefoneCelularResponsavel.Text);

                responsavel.Idade = responsavel.CalculaIdade();

                if (responsavel.Cadastrar())
                {
                    MessageBox.Show("Responsável cadastrado com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                //Endereco endereco = new Endereco(responsavel.Id, txtCepResponsavel.Text, txtNumeroResponsavel.Text, txtComplementoResponsavel.Text, txtBairroResponsavel.Text,
                //                                 txtCidadeResponsavel.Text, txtUfResponsavel.Text);
                //endereco.Cadastrar();

                //chamada de metódo com "filhos" do responsável
                responsavel.Alunos = GetAlunos(responsavel.Id);
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
                    if(row.Index != (dgvAlunos.Rows.Count-1))
                    {
                        string rg = dgvAlunos.Rows[row.Index].Cells["RG"].Value.ToString();
                        string nome = dgvAlunos.Rows[row.Index].Cells["Nome"].Value.ToString();
                        string cpf = dgvAlunos.Rows[row.Index].Cells["CPF"].Value.ToString();
                        string email = dgvAlunos.Rows[row.Index].Cells["Email"].Value.ToString();
                        string sexo = dgvAlunos.Rows[row.Index].Cells["Sexo"].Value.ToString();
                        string dataNascimento = dgvAlunos.Rows[row.Index].Cells["DataNascimento"].Value.ToString();

                        //false - ainda não está matriculado em nenhuma turma
                        bool status = false;

                        Aluno aluno = new Aluno(nome, cpf, rg, email, sexo, Convert.ToDateTime(dataNascimento), DateTime.Now.Date, status);
                        aluno.IdResponsavel = idResponsavel;
                        aluno.Idade = aluno.CalculaIdade();

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
                else
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

            Environment.Exit(0);
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.Add(txtRGAluno.Text, txtNomeAluno.Text, txtCpfAluno.Text, txtEmailAluno.Text, cbxSexoAluno.Text, txtDataDeNascimentoAluno.Text);

            LimparCamposAluno();

            //editar
            //DataGridViewSelectedRowCollection gridRow = dgvAlunos.SelectedRows;
            //foreach (DataGridViewRow row in gridRow)
            //{
            //    row.Cells[0].Value = txtNomeAluno.Text;
            //    row.Cells[1].Value = txtRGAluno.Text;
            //}
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

		private void BtnBusca_Click(object sender, EventArgs e)
		{
			CadLista c = new CadLista();
			c.ShowDialog();
		}
	}
}
