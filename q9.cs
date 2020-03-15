using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase com três palavras:");
    string[] a = Console.ReadLine().Split(' ');
    string b = a[0];
    string c = a[1];
    string d = a[2];
    

    Console.Write($"A sigla é {b[0]}");
    Console.Write(c[0]);
    Console.Write(d[0]);
    Console.WriteLine();
  }
}
