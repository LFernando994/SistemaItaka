using CadastroItaka.DataSource;
using CadastroItaka.Modelos.Pessoas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CadastroItaka.DAL
{
    public class AlunoDAO : IDataAccessObject<Aluno>
    {
        private Contexto ItakaConnection;

        public AlunoDAO()
        {
            ItakaConnection = new Contexto();
        }

        public void Insert(Aluno obj)
        {
            try
            {
                ItakaConnection.Alunos.Add(obj);
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

        public void Update(Aluno obj)
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

        public void Delete(Aluno obj)
        {
            try
            {
                Aluno aluno = ItakaConnection.Alunos.Find(obj.Id);
                ItakaConnection.Alunos.Remove(aluno);
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

        public List<Aluno> GetAlunos()
        {
            try
            {
                return ItakaConnection.Alunos.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetId(string rg)
        {
            try
            {
                return ItakaConnection.Alunos.Where(x => x.Rg == rg).Select(y => y.Id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
