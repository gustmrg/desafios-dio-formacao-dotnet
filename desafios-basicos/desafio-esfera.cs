/*
Desafio
Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). 
A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.
*/

using System;

class DIO {

  static void Main(string[] args) {

    double pi, raio, volume;
    pi = 3.14159;
    raio = double.Parse(Console.ReadLine());
    volume = pi * (4.0 / 3) * Math.Pow(raio , 3);
    
    Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
  }

}