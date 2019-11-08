using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroItaka.Modelos.Matriculados
{
    public class Frequencia
    {
        public Matriculado Aluno { get => aluno; set => aluno = value; }
        public Curso Cursos { get => cursos; set => cursos = value; }
        public Turma Turmas { get => turmas; set => turmas = value; }

        private Matriculado aluno;
        private Curso cursos;
        private Turma turmas;

        public Frequencia(Matriculado matriculado, Curso curso)
        {

            this.aluno = matriculado;
            this.cursos = curso;
        }

        /// <summary>
        /// Metódo que calcula e retorna quantidade de aulas totais do curso:
        /// tem como base a cargo horaria total e divide "/" pelo tempo de duração 
        /// de cada aula baseado no horario inicial e final.
        /// </summary>
        /// <returns></returns>
        public double CalcQtdAula()
        {
            return cursos.CargaHoraria / turmas.GetHoraAula().TotalHours;
        }

        /// <summary>
        /// Método que retorna o % total de frequência do aluno
        /// </summary>
        /// <returns> 
        /// Para o forms
        /// </returns>
        public double ApurarFrequencia()
        {
            aluno.RetornaAusencia();

            double presenca = cursos.CargaHoraria - this.Aluno.Falta;

            double total = ((presenca * 100) / cursos.CargaHoraria);

            return total;
        }

    }
}
