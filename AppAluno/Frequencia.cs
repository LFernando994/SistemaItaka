using CadastroItaka.DataSource;
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
    public partial class AppFrequencia : Form
    {
        private Contexto db;
        public string x;

        public AppFrequencia()
        {
            InitializeComponent();
            db = new Contexto();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frequencia_Load(object sender, EventArgs e)
        {
            int ID = int.Parse(x);
            int Falta = db.Matriculados.Where(x => x.IdAluno == ID).Select(y => y.Falta).FirstOrDefault();
            int Idaluno = db.Matriculados.Where(x => x.IdAluno == ID).Select(y => y.IdAluno).FirstOrDefault();
            int IdTurma = db.Matriculados.Where(x => x.IdAluno == ID).Select(y => y.IdTurma).FirstOrDefault();
            string Curso = db.Turmas.Where(x => x.Id == IdTurma).Select(y => y.Atividade).FirstOrDefault();
            int CargaHoraria = db.Cursos.Where(x => x.Atividade == Curso).Select(y => y.CargaHoraria).FirstOrDefault();
            string Nome = db.Pessoas.Where(x => x.Id == Idaluno).Select(y => y.Nome).FirstOrDefault();
            double Frequencia = db.Matriculados.Where(x => x.IdAluno == ID).Select(y => y.Frequencia).FirstOrDefault();

            dgvFrequencia.Rows.Add(Nome, Curso, IdTurma, CargaHoraria, Falta, Frequencia);
        }

    }
}
