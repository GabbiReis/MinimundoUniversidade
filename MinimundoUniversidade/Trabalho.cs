using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimundoUniversidade
{
    public class Trabalho : AtividadeUniversitaria
    {
        public string Titulo { get; set; }
        public string Area { get; set; }
        public DateTime DataInicio { get; set; }
        public TimeSpan Duracao { get; set; }

        public Trabalho(int id, string nome, DateTime data, double notaFinal, string titulo, string area, DateTime dataInicio, TimeSpan duracao)
            : base(id, nome, data, notaFinal)
        {
            this.Titulo = titulo;
            this.Area = area;
            this.DataInicio = dataInicio;
            this.Duracao = duracao;
        }
    }
}
