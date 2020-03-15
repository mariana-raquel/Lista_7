using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a dimensão do ambiente em metros no formato largura X comprimento:");
    string[] a = Console.ReadLine().Split(" x ");
    double b = double.Parse(a[0]);
    double c = double.Parse(a[1]);

    Console.WriteLine("Digite a dimensão do revestimento em centímetros no formato largura X comprimento:");
    string[] d = Console.ReadLine().Split(" x ");
    double e = double.Parse(d[0]);
    double f = double.Parse(d[1]);

    Console.WriteLine("Digite o número de peças por caixa:");
    double g = double.Parse(Console.ReadLine());

    double cr = (b * c / ((e/100) * (f/100)))/g;

    Console.WriteLine($"São necessárias {cr:0.0} caixas do revestimento.");
  }
}
