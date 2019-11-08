using AppTurma;
using CadastroItaka.Modelos.Matriculados;
using System;
using System.Windows.Forms;

namespace AppCurso
{
    public partial class ListaCurso : Form
    {
        private Curso curso;

        public ListaCurso()
        {
            InitializeComponent();
            curso = new Curso();
        }

        private void ListaCurso_Load(object sender, EventArgs e)
        {
            GetCursos();
        }

        private void GetCursos()
        {
            dgvCursos.DataSource = curso.GetCursos();
        }

        #region Button
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection gridCursoRow = dgvCursos.SelectedRows;

            foreach (DataGridViewRow rowC in gridCursoRow)
            {
                int idCurso = int.Parse(dgvCursos.Rows[rowC.Index].Cells["Id"].Value.ToString());

                CadCurso cadCurso = new CadCurso();
                cadCurso.GetCurso(idCurso);
                cadCurso.ShowDialog();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection gridCursoRow = dgvCursos.SelectedRows;

            foreach (DataGridViewRow rowC in gridCursoRow)
            {
                int idCurso = int.Parse(dgvCursos.Rows[rowC.Index].Cells["Id"].Value.ToString());

                Curso course = new Curso();
                course.Id = idCurso;

                if (course.Excluir())
                {
                    MessageBox.Show("Curso excluído com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBoxButtons.OK == 0)
                    {
                        GetCursos();
                        dgvCursos.Refresh();
                    }
                }
            }
        }

        private void btnTurmas_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection gridCursoRow = dgvCursos.SelectedRows;

            foreach (DataGridViewRow rowC in gridCursoRow)
            {
                string curso = dgvCursos.Rows[rowC.Index].Cells["Atividade"].Value.ToString();

                ListaTurma listaT = new ListaTurma();
                listaT.Operacao = "turmasCursos";
                listaT.GetTurmas(curso);
                listaT.ShowDialog();
            }

        }
		#endregion
	
	}
}
