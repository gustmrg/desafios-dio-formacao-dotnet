/*
Desafio
Pink e Cérebro dividem um apartamento e estão juntos 24h por dia desde o começo da pandemia. 
Para passar o temp, Pink cria problemas matemáticos para Cérebro resolver, o último deles foi uma lista de números com a seguinte pergunta: 
quantos números da lista são múltiplos de 2, 3, 4 e 5?

Apesar de parecer simples, porém, quando a lista contém muitos números, Cérebro se confunde e acaba errando alguns cálculos.

Ajude Cérebro a resolver o desafio de Pink.
*/

using System; 

class Program {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        string[] lista = new string[n];
        lista = Console.ReadLine().Split(' ');

        int multiplo2 = 0;
        int multiplo3 = 0;
        int multiplo4 = 0;
        int multiplo5 = 0;

        for (int i = 0; i < n; i++)
        {
            if ((int.Parse(lista[i]) % 2) == 0) { multiplo2++; }
            if ((int.Parse(lista[i]) % 3) == 0) { multiplo3++; }
            if ((int.Parse(lista[i]) % 4) == 0) { multiplo4++; }
            if ((int.Parse(lista[i]) % 5) == 0) { multiplo5++; }
        }

        Console.WriteLine("{0} Multiplo(s) de 2", multiplo2);
        Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
        Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
        Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);
        
        Console.ReadKey();
    }
}