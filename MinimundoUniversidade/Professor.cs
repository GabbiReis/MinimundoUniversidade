using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimundoUniversidade
{
    public class Professor : DadosPessoais
    {
        public static List<Professor> professores = new List<Professor>();
        public List<TrabalhoDirecionado> TrabalhosOrientados = new List<TrabalhoDirecionado>();

        public Professor(int matricula, string nome, string curso, int periodo, string endereco, int telefone)
            : base(matricula, nome, curso, periodo, endereco, telefone)
        {
            TrabalhosOrientados = new List<TrabalhoDirecionado>();
        }

        public void AdicionarTrabalhoOrientado(TrabalhoDirecionado trabalhoOrientado)
        {
            TrabalhosOrientados.Add(trabalhoOrientado);
        }
        public static void CadastrarProfessor()
        {
            Console.Clear();
            Console.WriteLine("============= CADASTRO DE PROFESSOR =============");
            Console.Write("Número da matrícula: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.Write("Nome do professor(a): ");
            string nome = Console.ReadLine();
            Console.Write("Curso de ensino do professor(a): ");
            string curso = Console.ReadLine();
            Console.Write("Período: ");
            int periodo = int.Parse(Console.ReadLine());
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Telefone para contato com o DDD: ");
            int telefone = int.Parse(Console.ReadLine());

            Professor professor = new Professor(matricula, nome, curso, periodo, endereco, telefone);
            professores.Add(professor);

            Console.WriteLine("Tudo certo! Professor(a) cadastrado com sucesso.");
            Console.WriteLine("================================================");


        }
    }
}
