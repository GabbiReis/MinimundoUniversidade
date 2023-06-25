using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimundoUniversidade
{
    public class Prova : AtividadeUniversitaria
    {
        public int NumeroQuestoes { get; set; }
        public bool Teste { get; set; }

        public Prova(int id, string nome, DateTime data, double notaFinal, int numeroQuestoes, bool teste)
            : base(id, nome, data, notaFinal)
        {
            this.NumeroQuestoes = numeroQuestoes;
            this.Teste = teste;
        }
    }
}
