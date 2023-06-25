using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimundoUniversidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("====================== MENU =====================");
                Console.WriteLine("1 - CADASTRO DE ALUNO");
                Console.WriteLine("2 - CADASTRO DE PROFESSOR");
                Console.WriteLine("3 - CADASTRO DE PROJETO");
                Console.WriteLine("4 - CADASTRO DE ATIVIDADE ACADÊMICA");
                Console.WriteLine("5 - CADATRO DE ATIVIDADE RELIZADA");
                Console.WriteLine("6 - CADASTRO DE TRABALHO ORIENTADO");
                Console.WriteLine("7 - LISTAGEM DE PROVAS E TRABALHOS REALIZADOS");
                Console.WriteLine("8 - SAIR");
                Console.WriteLine("================================================");
                Console.Write("Digite a opção desejada: ");
                int op = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (op)
                {
                    case 1:
                        Aluno.CadastrarAluno();
                        break;
                    case 2:
                        Professor.CadastrarProfessor();
                        break;
                    case 3:
                        Projeto.CadastrarProjeto();
                        break;
                    case 4:
                        AtividadeUniversitaria.CadastrarAtividadeUniversitari();
                        break;
                    case 5:
                        AtividadeRealizada.CadastrarAtividadeRealizada();
                        break;
                    case 6:
                        TrabalhoDirecionado.CadastrarTrabalhoOrientado();
                        break;
                    case 7:
                        Relatorio.RelatorioProvasTrabalhosRealizados();
                        break;
                    case 8:
                        Environment.Exit(0);
                        Console.WriteLine("Encerrando...Até Logo!");
                        break;
                    default:
                        Console.WriteLine("Opção invalida. Tente novamente digitando uma da opções disponiveis!");
                        break;
                }
            }
        }
    }
}
