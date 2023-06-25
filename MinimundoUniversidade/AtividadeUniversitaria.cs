using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimundoUniversidade
{
    public abstract class AtividadeUniversitaria
    {
        public static List<AtividadeUniversitaria> atividades = new List<AtividadeUniversitaria>();
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public double NotaFinal { get; set; }

        public AtividadeUniversitaria(int id, string nome, DateTime data, double notaFinal)
        {
            ID = id;
            Nome = nome;
            Data = data;
            NotaFinal = notaFinal;
        }
        public static void CadastrarAtividadeUniversitari()
        {
            Console.Clear();
            Console.WriteLine("=================== CADASTRO DE ATIVIDADE ACADÊMICA ===================");
            Console.Write("Digite o ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Data (DD/MM/AAAA): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Peso na Nota Final: ");
            double NotaFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("1 - PROVA");
            Console.WriteLine("2 - TRABALHO");
            Console.Write("Seleciona o tipo de atividade desejada: ");
            int tipoAtividade = int.Parse(Console.ReadLine());

            if (tipoAtividade == 1)
            {
                Console.Write("Número de Questões: ");
                int numeroQuestoes = int.Parse(Console.ReadLine());
                Console.Write("É um Teste? (SIM/NAO): ");
                bool Teste = Console.ReadLine().ToUpper() == "SIM";

                Prova prova = new Prova(id, nome, data, NotaFinal, numeroQuestoes, Teste);
                atividades.Add(prova);

                Console.WriteLine("Tudo feito! Prova cadastrada com sucesso.");
            }
            else if (tipoAtividade == 2)
            {
                Console.Write("Digite o título do trabalho: ");
                string titulo = Console.ReadLine();
                Console.Write("Área: ");
                string area = Console.ReadLine();
                Console.Write("Data de Início (DD/MM/AAAA): ");
                DateTime dataInicio = DateTime.Parse(Console.ReadLine());
                Console.Write("Duração do trabalho (em horas): ");
                double duracaoHoras = double.Parse(Console.ReadLine());
                TimeSpan duracao = TimeSpan.FromHours(duracaoHoras);

                Trabalho trabalho = new Trabalho(id, nome, data, NotaFinal, titulo, area, dataInicio, duracao);
                atividades.Add(trabalho);

                Console.WriteLine("Muito bem! Trabalho cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente escolhendo uma opção válida");
            }
            Console.WriteLine("=========================================================================");
        }

    }
}
