using CadastroItaka.Modelos.Matriculados;
using System;
using System.Windows.Forms;

namespace AppTurma
{
    public partial class ListaTurma : Form
    {
        private Turma turma;
        //variável para auxiliar na operação da tela (carregar turmas de um curso/ carregar todas as turmas)
        public string Operacao { private get => operacao; set => operacao = value; }
        private string operacao = string.Empty;

        public ListaTurma()
        {
            InitializeComponent();
            turma = new Turma();
        }

        private void ListaTurma_Load(object sender, EventArgs e)
        {
            if (!operacao.Equals("turmasCursos"))
            {
                GetTurmas();
            }
        }

        private void GetTurmas()
        {
            dgvTurmas.DataSource = turma.GetTurmas();
        }
       
        public void GetTurmas(string curso)
        {
            dgvTurmas.DataSource = turma.GetTurmas(curso);
        }

        #region Button
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection gridTurmaRow = dgvTurmas.SelectedRows;

            foreach (DataGridViewRow rowT in gridTurmaRow)
            {
                int idTurma = int.Parse(dgvTurmas.Rows[rowT.Index].Cells["Id"].Value.ToString());

                CadTurma cadTurma = new CadTurma();
                cadTurma.GetTurma(idTurma);
                cadTurma.ShowDialog();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection gridAlunoRow = dgvTurmas.SelectedRows;

            foreach (DataGridViewRow rowA in gridAlunoRow)
            {
                Turma turma = new Turma();
                turma.Id = int.Parse(dgvTurmas.Rows[rowA.Index].Cells["Id"].Value.ToString());

                if (turma.Excluir())
                {
                    MessageBox.Show("Turma excluída com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBoxButtons.OK == 0)
                    {
                        GetTurmas();
                        dgvTurmas.Refresh();
                    }
                }
            }
        }
        #endregion 
    }
}