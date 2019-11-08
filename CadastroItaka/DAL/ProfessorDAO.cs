using CadastroItaka.DataSource;
using CadastroItaka.Modelos.Pessoas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CadastroItaka.DAL
{
    public class ProfessorDAO : IDataAccessObject<Professor>
    {
        private Contexto ItakaConnection;

        public ProfessorDAO()
        {
            ItakaConnection = new Contexto();
        }

        public void Insert(Professor obj)
        {
            try
            {
                if (!ItakaConnection.Pessoas.Where(x => x.Cpf == obj.Cpf).Any())
                {
                    ItakaConnection.Professores.Add(obj);
                    ItakaConnection.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ItakaConnection.Dispose();
            }
        }

        public void Update(Professor obj)
        {
            try
            {
                ItakaConnection.Entry(obj).State = EntityState.Modified;
                ItakaConnection.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ItakaConnection.Dispose();
            }
        }

        public void Delete(Professor obj)
        {
            try
            {
                Professor professor = ItakaConnection.Professores.Find(obj.Id);
                ItakaConnection.Professores.Remove(professor);
                ItakaConnection.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ItakaConnection.Dispose();
            }
        }

        public List<int> GetIdProfessores(int idCurso)
        {
            try
            {
                return ItakaConnection.ControleCurso.Where(x => x.IdCurso == idCurso).Select(p => p.IdProf).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Busca professores cadastrados no sistema.
        /// </summary>
        public List<Professor> GetProfessores()
        {
            try
            {
                return ItakaConnection.Professores.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetNome(int idProfessor)
        {
            try
            {
                return ItakaConnection.Professores.Where(x => x.Id == idProfessor).Select(y => y.Nome).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetId(string cpfProfessor)
        {
            try
            {
                return ItakaConnection.Pessoas.Where(x => x.Cpf == cpfProfessor).Select(p => p.Id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
