using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogica
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seja bem vindo(a) ao programa para resolução do teste lógico.");
            Console.WriteLine("Por favor, informe o número total de elementos para esse teste.");
            bool isNumber = int.TryParse(Console.ReadLine(), out int totalElements);
            
            if (!isNumber)
            {
                throw new ArgumentException("A quantidade total precisa ser um número inteiro e maior do que zero");
            }

            Network network = new Network(totalElements);

            Console.WriteLine("Você deseja conectar dois números da lista? (S/N)");
            string yesOrNot = Console.ReadLine().ToUpper();

            if (yesOrNot == "S")
            {
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
                }
                else
                {
                    throw new ArgumentException("");
                }

            }
            
            //O código tem funcionado até aqui. O que ainda preciso fazer é verificar se
            //as consultas funcionam corretamente, mesmo após várias conexões

            Console.ReadLine();
        }
    }
}
