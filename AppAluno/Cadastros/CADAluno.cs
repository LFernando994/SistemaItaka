using CadastroItaka.DataSource;
using CadastroItaka.Modelos.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppAluno.Cadastros
{
    public partial class CADAluno : Form
    {
        private string operacao = string.Empty;
        private string Situacao = string.Empty;
        private string Aprovacao = string.Empty;

        private Contexto db;

        public CADAluno()
        {
            InitializeComponent();
            db = new Contexto();
            txtNomeResponsavel.Enabled = false;
        }

        private void CadAluno_Load(object sender, EventArgs e)
        {
            operacao = "incluir";
            dgvAlunos.AutoResizeColumns();
            dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        #region Button
        private void btnSairCadastroResponsavel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            string status = "";
            string aprovado = "";

            if (operacao.Equals("incluir"))
            {
                status = "Ativo";
                aprovado = "Não";

                dgvAlunos.Rows.Add("", txtNomeAluno.Text, txtRGAluno.Text, txtCpfAluno.Text, txtEmailAluno.Text, cbxSexoAluno.Text, txtDataDeNascimentoAluno.Text, status, aprovado, txtTelefoneCelularAluno.Text, txtTelefoneContatoAluno.Text);
                LimparCamposAluno();
            }
            else
            {
                if (CKBInativo.Checked == true)
                {
                    status = "Inativo";
                }
                else { status = "Ativo"; }
                if (CKBSim.Checked == true)
                {
                    aprovado = "Sim";
                }
                else { aprovado = "Não"; }

                DataGridViewSelectedRowCollection gridAlunoRow = dgvAlunos.SelectedRows;

                foreach (DataGridViewRow rowA in gridAlunoRow)
                {
                    string matricula = dgvAlunos.Rows[rowA.Index].Cells["Matricula"].Value.ToString();
                    dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);
                    dgvAlunos.Rows.Add(matricula, txtNomeAluno.Text, txtRGAluno.Text, txtCpfAluno.Text, txtEmailAluno.Text, cbxSexoAluno.Text, txtDataDeNascimentoAluno.Text, status, aprovado, txtTelefoneCelularAluno.Text, txtTelefoneContatoAluno.Text);
                }
            }

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);
            LimparCamposAluno();
        }

        private void BtnBusca_Click(object sender, EventArgs e)
        {
            CadLista c = new CadLista();
            c.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeResponsavel = db.Pessoas.Where(x => x.Cpf == txtCpfResponsavel.Text.Replace(".", string.Empty).Replace("-", string.Empty) || x.Rg == txtRGResponsavel.Text)
                                    .Select(y => y.Nome).FirstOrDefault();
                txtNomeResponsavel.Text = nomeResponsavel;

                int idResponsavel = db.Pessoas.Where(x => x.Cpf == txtCpfResponsavel.Text.Replace(".", string.Empty).Replace("-", string.Empty) || x.Rg == txtRGResponsavel.Text)
                                   .Select(y => y.Id).FirstOrDefault();

                var query = from pessoa in db.Pessoas
                            join aluno in db.Alunos on pessoa.Id equals aluno.Id
                            join responsavel in db.Responsaveis on aluno.IdResponsavel equals idResponsavel
                            where aluno.IdResponsavel == responsavel.Id
                            select new
                            {
                                Nome = pessoa.Nome,
                                RG = pessoa.Rg,
                                CPF = pessoa.Cpf,
                                Email = pessoa.Email,
                                Sexo = pessoa.Sexo,
                                DataNascimento = pessoa.DataNascimento,
                                Idade = pessoa.Idade,
                                TelefoneCelular = pessoa.TelCelular,
                                TelefoneContato = pessoa.TelContato,
                                NomeResponsavel = responsavel.Nome,
                                RgResponsavel = responsavel.Rg,
                                TelResponsavel = responsavel.TelCelular,
                                DataCadastroAluno = pessoa.DataCadastro,
                                Status = aluno.Status,
                                Aprovacao = aluno.Aprovacao,
                                Matricula = aluno.Id
                            };

                string status;
                string aprovacao;

                foreach (var item in query.ToList())
                {
                    if (item.Status == true)
                    {
                        status = "Ativo";
                    }
                    else { status = "Inativo"; }

                    if (item.Aprovacao == true)
                    {
                        aprovacao = "Sim";
                    }
                    else { aprovacao = "Não"; }
                    dgvAlunos.Rows.Add(item.Matricula, item.Nome, item.RG, item.CPF, item.Email, item.Sexo, item.DataNascimento.ToString("dd/MM/yyyy"), status, aprovacao, item.TelefoneCelular, item.TelefoneContato);
                }

                if (query.ToList().Count() > 0)
                {
                    int qtdAlunos = query.ToList().Count();
                    string msg = string.Concat(qtdAlunos.ToString(), " Aluno(a)s foram encontrados!");

                    MessageBox.Show(msg, "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnSalvarCadastroAluno_Click(object sender, EventArgs e)
        {
            List<Aluno> alunos = new List<Aluno>();

            try
            {
                db = new Contexto();

                bool status;
                bool aprovacao;
                string cpfAluno;

                int idResponsavel = db.Pessoas.Where(x => x.Cpf == txtCpfResponsavel.Text.Replace(".", string.Empty).Replace("-", string.Empty) || x.Rg == txtRGResponsavel.Text)
                                       .Select(y => y.Id).FirstOrDefault();

                if (operacao.Equals("editar"))
                {
                    DataGridViewSelectedRowCollection gridAlunoRow = dgvAlunos.SelectedRows;

                    foreach (DataGridViewRow rowA in gridAlunoRow)
                    {
                        DateTime dataNascimento = Convert.ToDateTime(txtDataDeNascimentoAluno.Text);

                        if (CKBInativo.Checked == true)
                        {
                            status = false;
                            Situacao = "Inativo";
                        }
                        else { status = true; Situacao = "Ativo"; }

                        if (CKBSim.Checked == true)
                        {
                            aprovacao = true;
                            Aprovacao = "Sim";
                        }
                        else { aprovacao = false; Aprovacao = "Não"; }

                        cpfAluno = txtCpfAluno.Text.Replace(".", string.Empty).Replace("-", string.Empty).ToString();

                        Aluno aluno = new Aluno(txtNomeAluno.Text, cpfAluno, txtRGAluno.Text, txtEmailAluno.Text, cbxSexoAluno.Text, dataNascimento, DateTime.Now.Date, txtTelefoneContatoAluno.Text, txtTelefoneCelularAluno.Text, status, aprovacao);
                        aluno.Id = db.Alunos.Where(x => x.Cpf == cpfAluno).Select(y => y.Id).FirstOrDefault();
                        aluno.IdResponsavel = idResponsavel;

                        if (aluno.Editar())
                        {
                            alunos.Add(aluno);
                            UpdateGrid(aluno);
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvAlunos.Rows)
                    {
                        if (row.Index != (dgvAlunos.Rows.Count - 1))
                        {
                            string rg = dgvAlunos.Rows[row.Index].Cells["RG"].Value.ToString();
                            string nome = dgvAlunos.Rows[row.Index].Cells["Nome"].Value.ToString();
                            string email = dgvAlunos.Rows[row.Index].Cells["Email"].Value.ToString();
                            string sexo = dgvAlunos.Rows[row.Index].Cells["Sexo"].Value.ToString();
                            string dataNascimento = dgvAlunos.Rows[row.Index].Cells["DataNascimento"].Value.ToString();
                            string Aprovacao = dgvAlunos.Rows[row.Index].Cells["Aprovado"].Value.ToString();
                            Situacao = dgvAlunos.Rows[row.Index].Cells["Status"].Value.ToString();

                            if (Situacao == "Ativo")
                            {
                                status = true;
                            }
                            else { status = false; }

                            if (Aprovacao == "Sim")
                            {

                                aprovacao = true;
                            }
                            else { aprovacao = false; }

                            cpfAluno = dgvAlunos.Rows[row.Index].Cells["CPF"].Value.ToString().Replace(".", string.Empty).Replace("-", string.Empty).ToString();

                            Aluno aluno = new Aluno(nome, cpfAluno, rg, email, sexo, Convert.ToDateTime(dataNascimento), DateTime.Now.Date, txtTelefoneContatoAluno.Text, txtTelefoneCelularAluno.Text, status, aprovacao);
                            aluno.IdResponsavel = idResponsavel;

                            if (!db.Pessoas.Where(x => x.Cpf == cpfAluno).Any())
                            {
                                aluno.Cadastrar();
                            }

                            alunos.Add(aluno);
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
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacao = "editar";

            DataGridViewSelectedRowCollection gridAlunoRow = dgvAlunos.SelectedRows;

            foreach (DataGridViewRow rowA in gridAlunoRow)
            {
                txtNomeAluno.Text = dgvAlunos.Rows[rowA.Index].Cells["Nome"].Value.ToString();
                txtRGAluno.Text = dgvAlunos.Rows[rowA.Index].Cells["RG"].Value.ToString();
                txtCpfAluno.Text = dgvAlunos.Rows[rowA.Index].Cells["CPF"].Value.ToString();
                txtEmailAluno.Text = dgvAlunos.Rows[rowA.Index].Cells["Email"].Value.ToString();
                cbxSexoAluno.Text = dgvAlunos.Rows[rowA.Index].Cells["Sexo"].Value.ToString();
                txtDataDeNascimentoAluno.Text = dgvAlunos.Rows[rowA.Index].Cells["DataNascimento"].Value.ToString();
                txtTelefoneCelularAluno.Text = dgvAlunos.Rows[rowA.Index].Cells["TelefoneCelular"].Value.ToString();
                txtTelefoneContatoAluno.Text = dgvAlunos.Rows[rowA.Index].Cells["TelefoneContato"].Value.ToString();
            }

            txtCpfAluno.Enabled = false;
            txtRGAluno.Enabled = false;

            lblStatus.Visible = true;
            lblAprovado.Visible = true;
            CKBInativo.Visible = true;
            CKBSim.Visible = true;

            btnMais.Enabled = false;
            btnMenos.Enabled = false;
        }

        private void btnVoltarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region KeyPress
        private void txtNomeResponsavel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCpfAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtDataDeNascimentoAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtTelefoneCelularAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtTelefoneContatoAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace(apagar) e Espaço
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
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
        #endregion

        /// <summary>
        /// Método que limpa os campos do registro de aluno.
        /// </summary>
        private void LimparCamposAluno()
        {
            txtRGAluno.Text = string.Empty;
            txtNomeAluno.Text = string.Empty;
            txtCpfAluno.Text = string.Empty;
            txtEmailAluno.Text = string.Empty;
            cbxSexoAluno.Text = string.Empty;
            txtDataDeNascimentoAluno.Text = string.Empty;
        }

        /// <summary>
        /// Método que atualiza dados de aluno editado no grid.
        /// </summary>
        /// <param name="aluno"></param>
        private void UpdateGrid(Aluno aluno)
        {
            try
            {
                LimparCamposAluno();
                MessageBox.Show(string.Concat("Cadastro de ", aluno.Nome, " editado com sucesso!"), "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBoxButtons.OK == 0)
                {
                    dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);
                    dgvAlunos.Rows.Add(aluno.Id, aluno.Nome, aluno.Rg, aluno.Cpf, aluno.Email, aluno.Sexo, aluno.DataNascimento.ToShortDateString(), Situacao, Aprovacao, aluno.TelCelular, aluno.TelContato);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
