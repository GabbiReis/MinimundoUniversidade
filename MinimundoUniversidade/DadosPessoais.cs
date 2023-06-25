using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimundoUniversidade
{
    public abstract class DadosPessoais
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int Periodo { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }

        public DadosPessoais(int matricula, string nome, string curso, int periodo, string endereco, int telefone)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Curso = curso;
            this.Periodo = periodo;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }
    }
}
