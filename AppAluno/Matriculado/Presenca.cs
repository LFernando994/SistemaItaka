using CadastroItaka.DataSource;
using CadastroItaka.Modelos.Matriculados;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppAluno
{
    public partial class Presença : Form
    {
        private Contexto db;
        private int IdTurma;

        public Presença()
        {
            InitializeComponent();
            db = new Contexto();
        }

        private void Presença_Load(object sender, EventArgs e)
        {
            var query = from turma in db.Turmas
                        select new
                        {
                            Id = turma.IDTurma,
                            Curso = turma.Atividade,
                            Turno = turma.Turno
                        };

            dgvTurma.DataSource = query.ToList();
        }

        private void btnSalvarMatricula_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja lançar faltar para os alunos selecionados?", "Controle de Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                bool ausente;

                foreach (DataGridViewRow row in dgvAluno.Rows)
                {
                    if (dgvAluno.Rows[row.Index].Cells[0].Value != null)
                    {
                        ausente = bool.Parse(dgvAluno.Rows[row.Index].Cells[0].Value.ToString());
                    }
                    else { ausente = false; }

                    string Nome = dgvAluno.Rows[row.Index].Cells[1].Value.ToString();
                    string Matricula = dgvAluno.Rows[row.Index].Cells[2].Value.ToString();

                    int IdAluno = db.Alunos.Where(x => x.Nome == Nome).Select(y => y.Id).FirstOrDefault();

                    var matriculados = from matriculado in db.Matriculados
                                       where (matriculado.IdAluno == IdAluno && matriculado.IdTurma == IdTurma)
                                       select new
                                       {
                                           IdAluno = matriculado.IdAluno,
                                           idTurma = matriculado.IdTurma,
                                           DataMatricula = matriculado.DataMatricula,
                                           Falta = matriculado.Falta,
                                           frequencia = matriculado.Frequencia,
                                           matricula = matriculado.Matricula
                                       };

                    foreach (var matriculado in matriculados.ToList())
                    {
                        Matriculado m = new Matriculado(matriculado.IdAluno, matriculado.DataMatricula);
                        m.Falta = matriculado.Falta;
                        m.Matricula = matriculado.matricula;
                        m.IdTurma = matriculado.idTurma;

                        string curso = db.Turmas.Where(x => x.Id == matriculado.idTurma).Select(y => y.Atividade).FirstOrDefault();
                        var cargahoraria = db.Cursos.Where(x => x.Atividade == curso).Select(y => y.CargaHoraria).FirstOrDefault();
                        Curso c = new Curso(curso, cargahoraria);

                        if (ausente)
                        {
                            m.RegistrarAusencia();
                            Frequencia f = new Frequencia(m, c);
                            m.Frequencia = f.ApurarFrequencia();
                            m.Editar();
                        }
                    }
                    MessageBox.Show("Lista de Chamada salva com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBoxButtons.OK == 0)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void btnVoltarMatricularNaTurma_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string Turma = dgvTurma.CurrentRow.Cells[0].Value.ToString();
            IdTurma = db.Turmas.Where(x => x.IDTurma == Turma).Select(y => y.Id).FirstOrDefault();

            var Matriculado = from matriculado in db.Matriculados
                              where (matriculado.IdTurma == IdTurma)
                              select new
                              {
                                  Nome = matriculado.Aluno.Nome,
                                  Matricula = matriculado.Matricula

                              };

            dgvAluno.DataSource = Matriculado.ToList();
        }
    }
}