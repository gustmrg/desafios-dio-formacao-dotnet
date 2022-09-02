/*
Desafio
Você receberá dois valores inteiros. 
Faça a leitura e em seguida calcule o produto entre estes dois valores. 
Atribua esta operação à variável PROD, mostrando esta de acordo com a mensagem de saída esperada. 
*/

using System; 

class URI {

  static void Main(string[] args) { 

    int a, b, PROD;

    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    PROD = (a * b);

    Console.WriteLine($"PROD = {PROD.ToString()}");

  }

}