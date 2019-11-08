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

            GvTurma.DataSource = query.ToList();
        }

        private void Buscar_Click_1(object sender, EventArgs e)
        {
            string Turma = GvTurma.CurrentRow.Cells[0].Value.ToString();
            IdTurma = db.Turmas.Where(x => x.IDTurma == Turma).Select(y => y.Id).FirstOrDefault();

            var Matriculado = from matriculado in db.Matriculados
                              where (matriculado.IdTurma == IdTurma)
                              select new
                              {
                                  Nome = matriculado.Aluno.Nome,
                                  Matricula = matriculado.Matricula

                              };

            GvAluno.DataSource = Matriculado.ToList();
        }

        private void btnSalvarMatricula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja lançar presença para os alunos selecionados?", "Controle de Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            //if (MessageBoxButtons.YesNo == )
            //{

            //    bool sele;

            //    foreach (DataGridViewRow row in GvAluno.Rows)
            //    {
            //        if (GvAluno.Rows[row.Index].Cells[0].Value != null)
            //        {
            //            sele = bool.Parse(GvAluno.Rows[row.Index].Cells[0].Value.ToString());
            //        }
            //        else { sele = false; }
            //        string Nome = GvAluno.Rows[row.Index].Cells[1].Value.ToString();
            //        string Matricula = GvAluno.Rows[row.Index].Cells[2].Value.ToString();

            //        int IdAluno = db.Alunos.Where(x => x.Nome == Nome).Select(y => y.Id).FirstOrDefault();
            //        var mat = from matriculado in db.Matriculados
            //                  where (matriculado.IdAluno == IdAluno && matriculado.IdTurma == IdTurma)
            //                  select new
            //                  {
            //                      IdAluno = matriculado.IdAluno,
            //                      idTurma = matriculado.IdTurma,
            //                      DataMatricula = matriculado.DataMatricula,
            //                      Falta = matriculado.Falta,
            //                      frequencia = matriculado.Frequencia,
            //                      matricula = matriculado.Matricula


            //                  };

            //        foreach (var item in mat.ToList())
            //        {
            //            Matriculado m = new Matriculado(item.IdAluno, item.DataMatricula);
            //            string curso = db.Turmas.Where(x => x.Id == item.idTurma).Select(y => y.Atividade).FirstOrDefault();
            //            var cargahoraria = db.Cursos.Where(x => x.Atividade == curso).Select(y => y.CargaHoraria).FirstOrDefault();
            //            m.Falta = item.Falta;
            //            m.Matricula = item.matricula;
            //            m.IdTurma = item.idTurma;
            //            Curso c = new Curso(curso, cargahoraria);

            //            //bool Selecionado = bool.Parse(sele.ToString();
            //            if (sele == true)
            //            {
            //                m.RegistrarAusencia();
            //                Frequencia f = new Frequencia(m, c);
            //                m.Frequencia = f.ApurarFrequencia();
            //                m.Editar();
            //            }
            //        }
            //    }
            //}


        }

        private void btnVoltarMatricularNaTurma_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}