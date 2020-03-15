using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma frase com três palavras:");
    string a = Console.ReadLine();
    string b;
    int t;
    int e = a.IndexOf(' ');
    Console.Write("A senha é ");
    while (e != -1)
    {
      b = a.Substring(0,e);
      t = b.Length;
      Console.Write(t);
      a = a.Substring(e+1);
      e = a.IndexOf(' ');
    }
    Console.Write(a.Length);
    Console.WriteLine();
  }
}
