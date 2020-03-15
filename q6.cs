using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a largura do ambiente em metros: ");
    double la = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o comprimento do ambiente em metros:");
    double ca = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a largura do revestimento em centímetros:");
    double lr = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o comprimento do revestimento em centímetros: ");
    double cor = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o número de peças por caixa:");
    double pc = double.Parse(Console.ReadLine());

    double cr = (la * ca / ((lr/100) * (cor/100)))/pc;
    Console.WriteLine($"São necessárias {cr:0.0} caixas do revestimento.");
    
  }
}
