using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite três valores reais separados por ponto e vírgulas:");
    string[] a = Console.ReadLine().Split(';');
    double b = double.Parse(a[0]);
    double c = double.Parse(a[1]);
    double d = double.Parse(a[2]);
    
    double soma = b + c + d;

    Console.WriteLine($"A soma entre os valores é {soma:0.00}");
  }
}
