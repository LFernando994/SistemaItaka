using AppAluno;
using AppAluno.Cadastros;
using AppCurso;
using AppProfessor;
using AppTurma;
using System;
using System.Windows.Forms;

namespace AppMenu
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void cadastrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            timerCadProf.Start();
        }
        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timerCadTurmas.Start();
        }
        private void adicionarProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerAddProf.Start();
        }
        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timerCadCurso.Start();
        }
        private void matricularAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerMatriAluno.Start();
        }
        private void frequênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerListaAluno.Start();
        }
        private void responsavelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerCadResp.Start();
        }
        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerCadAluno.Start();
        }
        private void listaChamadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerListaDeCham.Start();
        }
        private void listaResponsávelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerListaResp.Start();
        }
        private void listaDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerListaCurso.Start();
        }
        private void turmasCadastradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerListaTurmas.Start();
        }
        private void listaDeProfessoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timerListaDeProf.Start();
        }
        private void timerCadResp_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                //CADResponsavelAluno responsaveis = new CADResponsavelAluno();
                timerCadResp.Stop();
                //responsaveis.ShowDialog();
                using (CADResponsavelAluno responsaveis = new CADResponsavelAluno())
                {
                    responsaveis.ShowDialog();
                    responsaveis.Close();
                }
                progressBar1.Increment(-100);
            }
        }
        private void timerCadAluno_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timerCadAluno.Stop();
                using (CADAluno alunos = new CADAluno())
                {
                    alunos.ShowDialog();
                    alunos.Close();
                }
                progressBar1.Increment(-100);
            }
        }
        private void timerListaAluno_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timerListaAluno.Stop();
                using (CadLista c = new CadLista())
                {
                    c.ShowDialog();
                    c.Close();
                }
                progressBar1.Increment(-100);
            }
        }
        private void timerListaResp_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timerListaResp.Stop();
                using (ListaResponsavel l = new ListaResponsavel())
                {
                    l.ShowDialog();
                    l.Close();
                }
                progressBar1.Increment(-100);
            }
        }
        private void timerCadCurso_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timerCadCurso.Stop();
                using (CadCurso c = new CadCurso())
                {
                    c.ShowDialog();
                    c.Close();
                }
                progressBar1.Increment(-100);
            }
        }
        private void timerAddProf_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timerAddProf.Stop();
                using (ControleCurso c = new ControleCurso())
                {
                    c.ShowDialog();
                    c.Close();
                }
                progressBar1.Increment(-100);
            }
        }
        private void timerListaCurso_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timerListaCurso.Stop();
                using (ListaCurso c = new ListaCurso())
                {
                    c.ShowDialog();
                    c.Close();
                }
                progressBar1.Increment(-100);
            }
        }
        private void timerCadTurmas_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timerCadTurmas.Stop();
                using (CadTurma c = new CadTurma())
                {
                    c.ShowDialog();
                    c.Close();
                }
                progressBar1.Increment(-100);
            }
        }
        private void timerMatriAluno_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timerMatriAluno.Stop();
                using (CadAlunoNaTurma c = new CadAlunoNaTurma())
                {
                    c.ShowDialog();
                    c.Close();
                }
                progressBar1.Increment(-100);
            }
        }
        private void timerListaDeCham_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timerListaDeCham.Stop();
                using(Presença p = new Presença())
                {
                    p.ShowDialog();
                    p.Close();
                }
                progressBar1.Increment(-100);
            }
        }
        private void timerListaTurmas_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timerListaTurmas.Stop();
                using (ListaTurma l = new ListaTurma())
                {
                    l.ShowDialog();
                    l.Close();
                }
                progressBar1.Increment(-100);
            }
        }
        private void timerCadProf_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timerCadProf.Stop();
                using (CadProfessor c = new CadProfessor())
                {
                    c.ShowDialog();
                    c.Close();
                }
                progressBar1.Increment(-100);
            }
        }
        private void timerListaDeProf_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timerListaDeProf.Stop();
                using (ListaProfessor prof = new ListaProfessor())
                {
                    prof.ShowDialog();
                    prof.Close();
                }
                progressBar1.Increment(-100);
            }
        }
    }
}
