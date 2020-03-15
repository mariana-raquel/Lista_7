using System;

class MainClass {
  public static void Main (string[] args) {
    int c = 10;
    while (c <= 120)
    {
      Console.Write($"{c}ºC = ");
      double f = (c*9/5) + 32;
      Console.Write($"{f:0}ºF");
      Console.WriteLine();
      c = c + 10;
    } 
  }
}
