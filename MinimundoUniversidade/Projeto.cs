using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimundoUniversidade
{
    public class Projeto
    {
        static List<Aluno> alunos = new List<Aluno>();

        static List<Projeto> projetos = new List<Projeto>();
        static List<Professor> professores = new List<Professor>();

        public static void CadastrarProjeto()
        {
            Console.Clear();
            Console.WriteLine("=============================== CADASTRO DE PROJETO ===============================");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Alunos envolvidos (digite o número matrícula do aluno(a) ou '0' para finalizar):");
            List<Aluno> alunosEnvolvidos = new List<Aluno>();
            int matriculaAluno = int.Parse(Console.ReadLine());
            while (matriculaAluno != 0)
            {
                Aluno aluno = alunos.FirstOrDefault(a => a.Matricula == matriculaAluno);
                if (aluno != null)
                {
                    alunosEnvolvidos.Add(aluno);
                }
                else
                {
                    Console.WriteLine("Desculpe! Aluno(a) não encontrado.");
                }
                matriculaAluno = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Professores responsáveis (digite o número matrícula da matrícula do professor(a) ou '0' para finalizar):");
            List<Professor> professoresResponsaveis = new List<Professor>();
            int matriculaProfessor = int.Parse(Console.ReadLine());
            while (matriculaProfessor != 0)
            {
                Professor professor = professores.FirstOrDefault(p => p.Matricula == matriculaProfessor);
                if (professor != null)
                {
                    professoresResponsaveis.Add(professor);
                }
                else
                {
                    Console.WriteLine("Desculpe! Professor(a) não encontrado.");
                }
                matriculaProfessor = int.Parse(Console.ReadLine());
            }

            Projeto projeto = new Projeto();
            projetos.Add(projeto);

            Console.WriteLine("Tudo feito! Projeto cadastrado com sucesso.");
            Console.WriteLine("=================================================================================");
        }

    }
}
