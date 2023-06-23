using System;

namespace TesteLogica
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seja bem vindo(a) ao programa para resolução do teste lógico.");
            Console.Write("Para iniciarmos, informe o número total de elementos para esse teste: ");

            bool isNumber = int.TryParse(Console.ReadLine(), out int totalElements);
            if (!isNumber)
            {
                throw new ArgumentException("A quantidade total precisa ser um número inteiro e maior do que zero");
            }

            Network network = new Network(totalElements);

            Console.WriteLine("");
            Console.Write("Você deseja CONECTAR dois números da lista? (S/N): ");
            string yesOrNot = Console.ReadLine().ToUpper();

            if (yesOrNot == "S")
            {
                do
                {
                    Console.WriteLine("");
                    Console.Write("Por favor, digite o primeiro número para a conexão: ");
                    bool verifyOrigin = int.TryParse(Console.ReadLine(), out int origin);

                    if (verifyOrigin)
                    {
                        Console.Write("Agora digite o segundo número: ");
                        bool verifyDestiny = int.TryParse(Console.ReadLine(), out int destiny);

                        if (verifyDestiny)
                        {
                            network.Connect(origin, destiny);
                        }
                        else
                        {
                            throw new ArgumentException($"Os números precisam estar entre 1 e {totalElements}");
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"Os números precisam estar entre 1 e {totalElements}");
                    }

                    Console.WriteLine("");
                    Console.Write("Deseja fazer uma nova CONEXÃO? (S/N): ");
                    yesOrNot = Console.ReadLine().ToUpper();

                } while (yesOrNot == "S");
            }

            Console.WriteLine("");
            Console.Write("Você deseja CONSULTAR alguma conexão da lista? (S/N): ");
            yesOrNot = Console.ReadLine().ToUpper();

            if (yesOrNot == "S")
            {
                do
                {
                    Console.WriteLine("");
                    Console.Write("Por favor, digite o primeiro número para a consulta: ");
                    bool verifyOrigin = int.TryParse(Console.ReadLine(), out int origin);

                    if (verifyOrigin)
                    {
                        Console.Write("Agora digite o segundo número: ");
                        bool verifyDestiny = int.TryParse(Console.ReadLine(), out int destiny);

                        if (verifyDestiny)
                        {
                            if (network.Query(origin, destiny))
                            {
                                Console.WriteLine("╔═══════════════════════════════════╗");
                                Console.WriteLine("║ Sim, os números estão conectados. ║");
                                Console.WriteLine("╚═══════════════════════════════════╝");
                            }
                            else
                            {
                                Console.WriteLine("╔═══════════════════════════════════════╗");
                                Console.WriteLine("║ Não, os números não estão conectados! ║");
                                Console.WriteLine("╚═══════════════════════════════════════╝");
                            }
                        }
                        else
                        {
                            throw new ArgumentException($"Os números precisam estar entre 1 e {totalElements}");
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"Os números precisam estar entre 1 e {totalElements}");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Deseja fazer uma nova CONSULTAR? (S/N): ");
                    yesOrNot = Console.ReadLine().ToUpper();

                } while (yesOrNot == "S");
            }


            Console.ReadLine();
        }

    }
}
