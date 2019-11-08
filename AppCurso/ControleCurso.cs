using CadastroItaka.Modelos.Controladores;
using CadastroItaka.Modelos.Matriculados;
using CadastroItaka.Modelos.Pessoas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppCurso
{
    public partial class ControleCurso : Form
    {
        private Curso curso;
        private Professor prof;

        public ControleCurso()
        {
            InitializeComponent();
            curso = new Curso();
            prof = new Professor();
        }

        private void ControleCurso_Load(object sender, EventArgs e)
        {
            List<Professor> lstProfessores = prof.GetProfessores().Select(p => new Professor
            {
                Id = p.Id,
                Nome = p.Nome
            }).ToList();

            lstProfessores.ForEach(p => dgvProfessores.Rows.Add(p.Id, p.Nome));
            curso.GetAtividades().ForEach(c => cbCursos.Items.Add(c));
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string atividadeCurso = cbCursos.Text;

            DataGridViewSelectedRowCollection gridProfRow = dgvProfessores.SelectedRows;

            foreach (DataGridViewRow rowP in gridProfRow)
            {
                int idProf = int.Parse(dgvProfessores.Rows[rowP.Index].Cells["Id"].Value.ToString());

                ControleCursos control = new ControleCursos(curso.GetId(atividadeCurso), idProf);
                if (control.Cadastrar())
                {
                    MessageBox.Show("Professor registrado com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBoxButtons.OK == 0)
                    {
                        cbCursos.Text = string.Empty;
                    }
                }
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
