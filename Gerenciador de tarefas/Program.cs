using System;
using System.Collections.Generic;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            string command = "";

            while (command != "exit")
            {
                Console.WriteLine("\nGerenciador de Tarefas");
                Console.WriteLine("Comandos disponíveis:");
                Console.WriteLine("1. add - Adicionar tarefa");
                Console.WriteLine("2. list - Listar tarefas");
                Console.WriteLine("3. remove - Remover tarefa");
                Console.WriteLine("Digite 'exit' para sair.");
                Console.Write("Digite um comando: ");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        Console.Write("Digite a descrição da tarefa: ");
                        string task = Console.ReadLine();
                        tasks.Add(task);
                        Console.WriteLine("Tarefa adicionada!");
                        break;

                    case "list":
                        Console.WriteLine("\nLista de Tarefas:");
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Nenhuma tarefa encontrada.");
                        }
                        else
                        {
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                            }
                        }
                        break;

                    case "remove":
                        Console.Write("Digite o número da tarefa que deseja remover: ");
                        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
                        {
                            tasks.RemoveAt(taskNumber - 1);
                            Console.WriteLine("Tarefa removida!");
                        }
                        else
                        {
                            Console.WriteLine("Número da tarefa inválido.");
                        }
                        break;

                    case "exit":
                        Console.WriteLine("Saindo do gerenciador de tarefas...");
                        break;

                    default:
                        Console.WriteLine("Comando inválido. Tente novamente.");
                        break;
                }
            }
        }
    }
}
