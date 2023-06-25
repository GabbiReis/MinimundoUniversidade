using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimundoUniversidade
{
    public class AtividadeRealizada
    {
        public static List<AtividadeUniversitaria> atividades = new List<AtividadeUniversitaria>();
        public static List<Aluno> alunos = new List<Aluno>();
        public Aluno Aluno { get; set; }
        public AtividadeUniversitaria Atividade { get; set; }

        public AtividadeRealizada(Aluno aluno, AtividadeUniversitaria atividade)
        {
            this.Aluno = aluno;
            this.Atividade = atividade;
        }
        public static void CadastrarAtividadeRealizada()
        {
            Console.Clear();
            Console.WriteLine("================ CADASTRO DE ATIVIDADE REALIZADA ================ ");
            Console.Write("Matrícula do Aluno(a): ");
            int matriculaAluno = int.Parse(Console.ReadLine());
            Aluno aluno = alunos.FirstOrDefault(a => a.Matricula == matriculaAluno);
            if (aluno != null)
            {
                Console.WriteLine("As atividades disponíveis (selecione digitando o ID):");
                foreach (var atividade in atividades)
                {
                    Console.WriteLine($"ID correspondete: {atividade.ID}, Nome: {atividade.Nome}");
                }
                Console.Write("ID da Atividade: ");
                int idAtividade = int.Parse(Console.ReadLine());
                AtividadeUniversitaria atividadeUniversitaria = atividades.FirstOrDefault(a => a.ID == idAtividade);
                if (atividadeUniversitaria != null)
                {
                    AtividadeRealizada atividadeRealizada = new AtividadeRealizada(aluno, atividadeUniversitaria);
                    aluno.AdicionarAtividadeRealizada(atividadeRealizada);
                    Console.WriteLine("Atividade realizada foi cadastrada com sucesso!!!.");
                }
                else
                {
                    Console.WriteLine("Desculpe! Essa atividade não foi encontrada.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe! Aluno(a) não encontrado.");
            }
            Console.WriteLine("================================================================ ");
        }
    }
    
}
