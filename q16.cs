using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Escreva um número:");
    string n = Console.ReadLine();
    int i = n.Length-1; 
    while (i >= 0)
    {
      Console.Write(n[i]);
      i--;
    }
    Console.WriteLine();
  }
}
