using CadastroItaka.DataSource;
using CadastroItaka.Modelos.Matriculados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAluno
{
    public partial class CadAlunoNaTurma : Form
    {
        private Contexto db;
        public CadAlunoNaTurma()
        {
            InitializeComponent();
            db = new Contexto();
        }

        private void CadAlunoNaTurma_Load(object sender, EventArgs e)
        {
            GetAlunos();
            GetTurmas();
        }

        /// <summary>
        /// Busca turmas cadastradas no sistema.
        /// </summary>
        public void GetTurmas()
        {
            var query = from turma in db.Turmas
                        select new
                        {
                            Id = turma.IDTurma,
                            Curso = turma.Atividade,
                            Professor = turma.Docente
                        };

            dgvTurmas.DataSource = query.ToList();
        }

        /// <summary>
        /// Busca alunos aptos a serem matriculados.
        /// </summary>
        public void GetAlunos()
        {
            var query = from pessoa in db.Pessoas
                        join aluno in db.Alunos on pessoa.Id equals aluno.Id
                        join responsavel in db.Responsaveis on aluno.IdResponsavel equals responsavel.Id
                        //alunos aprovadas e ativos no sistema
                        where aluno.Status && aluno.Aprovacao
                        select new
                        {
                            Nome = pessoa.Nome,
                            Rg = pessoa.Rg,
                            NomeResponsavel = responsavel.Nome,
                            DataCadastro = pessoa.DataCadastro
                        };

            dgvAlunos.DataSource = query.ToList();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection gridAlunoRow = dgvAlunos.SelectedRows;
            DataGridViewSelectedRowCollection gridTurmaRow = dgvTurmas.SelectedRows;

            foreach (DataGridViewRow rowT in gridTurmaRow)
            {
                string idTurma = dgvTurmas.Rows[rowT.Index].Cells["Id"].Value.ToString();
                string curso = dgvTurmas.Rows[rowT.Index].Cells["Curso"].Value.ToString();
                string professor = dgvTurmas.Rows[rowT.Index].Cells["Professor"].Value.ToString();

                foreach (DataGridViewRow rowA in gridAlunoRow)
                {
                    string rg = dgvAlunos.Rows[rowA.Index].Cells["RG"].Value.ToString();
                    string nome = dgvAlunos.Rows[rowA.Index].Cells["Nome"].Value.ToString();
                    string nomeResponsavel = dgvAlunos.Rows[rowA.Index].Cells["NomeResponsavel"].Value.ToString();
                    string dataCadastro = dgvAlunos.Rows[rowA.Index].Cells["DataCadastro"].Value.ToString();

                    dgvMatriculados.Rows.Add(rg, nome, nomeResponsavel, dataCadastro, idTurma, curso, professor, DateTime.Now.Date.ToShortDateString());
                }
            }

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            dgvMatriculados.Rows.RemoveAt(dgvMatriculados.CurrentRow.Index);
        }

        private void btnSalvarMatricula_Click(object sender, EventArgs e)
        {
            List<Matriculado> matriculados = new List<Matriculado>();

            try
            {
                foreach (DataGridViewRow row in dgvMatriculados.Rows)
                {
                    if (row.Index != (dgvMatriculados.Rows.Count - 1))
                    {
                        //BUSCANDO O ID DO ALUNO AINDA NÃO MATRICULADO
                        string rg = dgvMatriculados.Rows[row.Index].Cells["RG"].Value.ToString();
                        int idAluno = db.Alunos.Where(x => x.Rg == rg).Select(y => y.Id).FirstOrDefault();

                        //BUSCANDO O ID DA TURMA 
                        string idTurma = dgvMatriculados.Rows[row.Index].Cells["IdTurma"].Value.ToString();
                        int idT = db.Turmas.Where(x => x.IDTurma == idTurma).Select(y => y.Id).FirstOrDefault();

                        Matriculado matriculado = new Matriculado(idAluno, DateTime.Now.Date);
                        matriculado.IdTurma = idT;

                        if (db.Matriculados.Where(x => x.IdAluno == matriculado.IdAluno && x.IdTurma == matriculado.IdTurma).Any())
                        {
                            string nome = dgvMatriculados.Rows[row.Index].Cells["Nome"].Value.ToString();
                            string msg = string.Concat("Aluno '", nome, "'", " já matriculado", " na Turma ", idTurma, ".");

                            MessageBox.Show(msg, "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (matriculado.Cadastrar())
                        {
                            matriculados.Add(matriculado);
                        }
                    }
                }

                if (matriculados.Count == 1)
                {
                    MessageBox.Show("Aluno(a) matriculado com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (matriculados.Count > 1)
                {
                    MessageBox.Show("Aluno(a)s matriculado com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltarMatricularNaTurma_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
