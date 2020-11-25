using System;

namespace Exc6
{
    class Program
    {
        static void Main(string[] args)
        {
            {string[] nome = new string[10];
            bool procurar = false;                      
            for (var i = 0; i < 10; i++)
            {Console.WriteLine();
             Console.WriteLine($"Escreva o {i+1}° nome:\n ");
             nome[i] = Console.ReadLine().ToLower();}
            Console.Write("Escreva um nome para procurar: ");
            string nomeescrito = Console.ReadLine().ToLower();

            foreach (string item in nome)
            {if (item == nomeescrito) {procurar = true;}}                        
            if (procurar == true) {Console.WriteLine("ACHEI");}            
            else {Console.WriteLine();
                Console.WriteLine("NÃO ACHEI");}            
        }
        }
    }
}
