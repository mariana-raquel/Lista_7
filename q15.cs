using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite Quatro nomes:");
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    string c = Console.ReadLine();
    string d = Console.ReadLine();
    string x;

    if (a.CompareTo(b) == 1)
    {
      x = a;
      a = b;
      b = x;
    }
    if (a.CompareTo(c) == 1)
    {
      x = a;
      a = c;
      c = x;
    }
    if (a.CompareTo(d) == 1)
    {
      x = a;
      a = d;
      d = x;
    }
    if (b.CompareTo(c) == 1)
    {
      x = b;
      b = c;
      c = x;
    }
    if (b.CompareTo(d) == 1)
    {
      x = b;
      b = d;
      d = x;
    }
    if (c.CompareTo(d) == 1)
    {
      x = c;
      c = d;
      d = x;
    }
    Console.WriteLine();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
  }
}

