using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o valor gasto com o combustível em reais:");
    double pc = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor do litro do combustível em reais:");
    double pl = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a distância percorrida em quilômetros:");
    double dp = double.Parse(Console.ReadLine());

    double l = pc/pl;
    double cm = dp/l;
    double gkm = pc/dp;
    Console.WriteLine($"O consumo médio é de {cm:0.00} Km por litro");
    Console.WriteLine($"O gasto por Km percorrido é R$ {gkm:0.00}");
  }
}
