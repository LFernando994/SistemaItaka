using CadastroItaka.Modelos.Pessoas;
using System;
using System.Windows.Forms;

namespace AppProfessor
{
    public partial class ListaProfessor : Form
    {
        private Professor prof;

        public ListaProfessor()
        {
            InitializeComponent();
            prof = new Professor();
        }

        private void ListaProfessor_Load(object sender, EventArgs e)
        {
            GetProfessores();
        }

        private void GetProfessores()
        {
            dgvProfessores.DataSource = prof.GetProfessores();
        }

        #region Button
        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection gridProfRow = dgvProfessores.SelectedRows;

            foreach (DataGridViewRow rowP in gridProfRow)
            {
                int id = int.Parse(dgvProfessores.Rows[rowP.Index].Cells["Id"].Value.ToString());

                CadProfessor cadProfessor = new CadProfessor();
                cadProfessor.GetProfessor(id);
                cadProfessor.ShowDialog();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection gridProfRow = dgvProfessores.SelectedRows;

            foreach (DataGridViewRow rowP in gridProfRow)
            {
                Professor professor = new Professor()
                {
                    Id = int.Parse(dgvProfessores.Rows[rowP.Index].Cells["Id"].Value.ToString())
                };
                if (professor.Excluir())
                {
                    MessageBox.Show("Professor excluído com sucesso!", "Controle de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBoxButtons.OK == 0)
                    {
                        GetProfessores();
                        dgvProfessores.Refresh();
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
