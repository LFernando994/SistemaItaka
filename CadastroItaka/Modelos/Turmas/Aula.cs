using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItaka.Modelos.Matriculados
{
    [Table("Aulas")]
    public class Aula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get => id; set => id = value; }

        public DateTime[] DiasSemana { get => diasSemana; set => diasSemana = value; }

        public Matriculado[] Alunos { get => alunos; set => alunos = value; }

        private int id;
        private DateTime[] diasSemana;
        private Matriculado[] alunos;
        
        public Aula(DateTime[] diasSemana, Matriculado[] alunos)
        {
            this.diasSemana = diasSemana;
            this.alunos = alunos;
        }

        public void ListaChamada(int index)
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                if (i == index)
                {
                    alunos[i].RegistrarAusencia();
                }
            }
        }

        public List<Matriculado> ImprimeFaltosos()
        {
            List<Matriculado> faltosos = new List<Matriculado>();

            foreach (var aluno in alunos)
            {

                if (aluno.Ausencia.Count >= 1)
                {
                    faltosos.Add(aluno);
                }

            }

            return faltosos;
        }
    }
}
