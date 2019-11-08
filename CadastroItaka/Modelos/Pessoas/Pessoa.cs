using CadastroItaka.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroItaka.Modelos.Pessoas
{
    [Table("Pessoas")]
    public abstract class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdPessoa")]
        //public int Matricula { get => id; set => id = value; }
        public int Id { get => id; set => id = value; }

        [Column("IdadePessoa")]
        public int Idade { get => idade; set => idade = value; }

        [Column("NomePessoa")]
        public string Nome { get => nome; set => nome = value; }

        [Column("CpfPessoa")]
        public string Cpf
        {
            get => cpf.Replace(".", string.Empty).Replace("-", string.Empty);
            set => cpf = value.Replace(".", string.Empty).Replace("-", string.Empty);
        }

        [Column("RgPessoa")]
        public string Rg { get => rg; set => rg = value; }

        [Column("EmailPessoa")]
        public string Email { get => email; set => email = value; }

        [Column("SexoPessoa")]
        public string Sexo { get => sexo; set => sexo = value; }

        [Column("DataNascimentoPessoa")]
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }

        [Column("DataCadastroPessoa")]
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }

        [Column("TelCelularPessoa")]
        public string TelCelular
        {
            get
            {
                if (telCelular != null)
                {
                    return telCelular.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty);
                }
                return telCelular;
            }

            set => telCelular = value.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty);
        }

        [Column("TelContatoPessoa")]
        public string TelContato
        {
            get
            {
                if (telContato != null)
                {
                    return telContato.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty);
                }
                return telContato;
            }
            set => telContato = value.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty);
        }

        protected int id;
        protected int idade;
        protected string nome;
        protected string cpf;
        protected string rg;
        protected string email;
        protected string sexo;
        protected string telContato;
        protected string telCelular;
        protected DateTime dataNascimento;
        protected DateTime dataCadastro;

        private static PessoaDAO pessoaDAO;

        public Pessoa(string nome, string cpf, string rg, string email, string sexo, DateTime dataNascimento, DateTime dataCadastro, string telContato, string telCelular)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.email = email;
            this.sexo = sexo;
            this.dataNascimento = dataNascimento;
            this.dataCadastro = dataCadastro;
            this.idade = DateTime.Now.Year - dataNascimento.Year;
            this.telCelular = telCelular;
            this.telContato = telContato;
        }

        public Pessoa() { }
        //public abstract string GetNome(string Rg);

        public static List<Pessoa> GetPessoas()
        {
            try
            {
                return pessoaDAO.GetPessoas();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
