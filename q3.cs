using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a operação no formato op1+op2:");
    string[] entrada = Console.ReadLine().Split('+');
    int a = int.Parse(entrada[0]);
    int b = int.Parse(entrada[1]); 

    int soma = a + b;

    Console.WriteLine($"Soma = {soma}");
  }
}
