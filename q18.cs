using System;

class MainClass {
  public static void Main (string[] args) {
    double a = 5000000;
    double b = 7000000;
    int s = 0;
    while (a < b)
    {
      a = a + (a * 0.03);
      b = b + (b * 0.02);
      s += 1;
    }
    Console.WriteLine($"Leva {s} anos para a populção de A ultrapassar a população de B");
    
  }
}
