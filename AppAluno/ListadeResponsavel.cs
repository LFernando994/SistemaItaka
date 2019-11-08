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
    public partial class ListadeResponsavel : Form
    {
        public ListadeResponsavel()
        {
            InitializeComponent();
        }

        private void btnDependentes_Click(object sender, EventArgs e)
        {
            ListaDependentes d = new ListaDependentes();
            d.ShowDialog();
                
        }
    }
}
