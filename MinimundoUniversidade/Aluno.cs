using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimundoUniversidade
{
    public class Aluno : DadosPessoais
    {
        public List<AtividadeRealizada> AtividadesRealizadas = new List<AtividadeRealizada>();
        public static List<Aluno> alunos = new List<Aluno>();
        public Aluno(int matricula, string nome, string curso, int periodo, string endereco, int telefone)
            : base(matricula, nome, curso, periodo, endereco, telefone)
        {
            AtividadesRealizadas = new List<AtividadeRealizada>();
        }

        public void AdicionarAtividadeRealizada(AtividadeRealizada atividadeRealizada)
        {
            AtividadesRealizadas.Add(atividadeRealizada);
        }

        public List<AtividadeRealizada> ObterAtividadesRealizadas()
        {
            return AtividadesRealizadas;
        }

        public static void CadastrarAluno()
        {
            Console.Clear();
            Console.WriteLine("============ CADASTRO DE ALUNO ============");
            Console.Write("Número da mátricula: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.Write("Nome do aluno(a): ");
            string nome = Console.ReadLine();
            Console.Write("Curso: ");
            string curso = Console.ReadLine();
            Console.Write("Período: ");
            int periodo = int.Parse(Console.ReadLine());
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Telefone para contato com o DDD: ");
            int telefone = int.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(matricula, nome, curso, periodo, endereco, telefone);
            alunos.Add(aluno);

            Console.WriteLine("Tudo certo! Aluno cadastrado com sucesso.");
            Console.WriteLine("==========================================");

        }
    }
}
