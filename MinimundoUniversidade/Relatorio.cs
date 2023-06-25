using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimundoUniversidade
{
    public class Relatorio
    {
        public static List<Aluno> alunos { get; set; }
        public static void RelatorioProvasTrabalhosRealizados()
        {
            Console.Clear();
            Console.WriteLine("================== RELATÓRIO DE PROVAS E TRABALHOS REALIZADOS ==================");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome do aluno(a): {aluno.Nome} - Numero da matrícula: {aluno.Matricula}");
                Console.WriteLine("Preecha de acordo com as atividades realizadas: ");
                foreach (var atividadeRealizada in aluno.ObterAtividadesRealizadas())
                {
                    Console.WriteLine($"ID: {atividadeRealizada.Atividade.ID}, Nome: {atividadeRealizada.Atividade.Nome}");
                    if (atividadeRealizada.Atividade is Prova)
                    {
                        Prova prova = atividadeRealizada.Atividade as Prova;
                        Console.WriteLine($"Número de Questões: {prova.NumeroQuestoes}, É um Teste? {prova.Teste}");
                    }
                    else if (atividadeRealizada.Atividade is Trabalho)
                    {
                        Trabalho trabalho = atividadeRealizada.Atividade as Trabalho;
                        Console.WriteLine($"Título: {trabalho.Titulo}, Área: {trabalho.Area}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("=========================================================================");
            }
        }
    }
}
