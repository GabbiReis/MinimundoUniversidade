using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimundoUniversidade
{
    public class TrabalhoDirecionado
    {
        public static List<AtividadeUniversitaria> atividades { get; set; }
        public static List<Professor> professores { get; set; }

        public Professor Professor { get; set; }
        public Trabalho Trabalho { get; set; }

        public TrabalhoDirecionado(Professor professor, Trabalho trabalho)
        {
            Professor = professor;
            Trabalho = trabalho;
        }
        public static void CadastrarTrabalhoOrientado()
        {
            Console.Clear();
            Console.WriteLine("===================== CADASTRO DE TRABALHO ORIENTADO =====================");
            Console.Write("Matrícula do Professor(a): ");
            int matriculaProfessor = int.Parse(Console.ReadLine());
            Professor professor = professores.FirstOrDefault(p => p.Matricula == matriculaProfessor);
            if (professor != null)
            {
                Console.WriteLine("Trabalhos disponíveis (selecione digitando o ID):");
                foreach (var trabalhoid in atividades.OfType<Trabalho>())
                {
                    Console.WriteLine($"ID: {trabalhoid.ID}, Nome: {trabalhoid.Nome}");
                }
                Console.Write("ID do Trabalho: ");
                int idTrabalho = int.Parse(Console.ReadLine());
                Trabalho trabalho = atividades.OfType<Trabalho>().FirstOrDefault(t => t.ID == idTrabalho);
                if (trabalho != null)
                {
                    TrabalhoDirecionado trabalhoOrientado = new TrabalhoDirecionado(professor, trabalho);
                    professor.AdicionarTrabalhoOrientado(trabalhoOrientado);
                    Console.WriteLine("Tudo feito! Tabalho direcionado cadastrado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Houve um erro pois o trabalho não foi cadastrado, por isso não conseguimos encontrar.");
                }
            }
            else
            {
                Console.WriteLine("Houve um erro pois esse professor não foi encontrado.");
            }
            Console.WriteLine("=======================================================================");
        }
    }
}
