using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a operação no formato op1+op2:");
    string[] entrada = Console.ReadLine().Split(',');
    int a = int.Parse(entrada[0]);
    int b = int.Parse(entrada[1]); 
    int c = int.Parse(entrada[2]);

    int pro = a * b * c;

    Console.WriteLine($"O produto entre os valores é {pro}");
  }
}
