using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o nome do estado:");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite o número de habitantes:");
    double hab = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a área do estado em Km2:");
    double tam = double.Parse(Console.ReadLine());

    double den = hab/tam;
    Console.WriteLine($"A densidade demográfica do {nome} é de {den:0.0} hab/Km2");
  }
}
