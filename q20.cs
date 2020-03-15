using System;

class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine("Digite dois valores:");
  int a = int.Parse(Console.ReadLine());
  int b = int.Parse(Console.ReadLine());
  int c = a;
  int d = b;
  
  int r = a % b;

  while (r != 0)
  {
    a = b;
    b = r;
    r = a % b;
  }
  Console.WriteLine($"MDC = {b}");
  Console.WriteLine($"MMC = {c*d/b}");
  }
}
