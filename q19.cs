using System;

class MainClass {
  public static void Main (string[] args) {
    int x;
    double v1 = 0;
    double v2 = 0;
    double v3 = 0;
    double v4 = 0;
    double b = 0;
    double n = 0;
    int votos = 0;
    double maior = 0;
    do 
    {
      Console.WriteLine("0: Encerra a votação - 1: C1 - 2: C2 - 3: C3 - 4: C4 - 5: Branco - 6: Nulo");
      x = int.Parse(Console.ReadLine());
      if (x == 1) v1 = v1 + 1;
      if (x == 2) v2 = v2 + 1;
      if (x == 3) v3 = v3 + 1;
      if (x == 4) v4 = v4 + 1;
      if (x == 5) b = b + 1;
      if (x == 6) n = n + 1;
      votos = votos + 1;
    } while (x != 0);

    double p1 = v1/(votos-1)*100;
    double p2 = v2/(votos-1)*100;
    double p3 = v3/(votos-1)*100;
    double p4 = v4/(votos-1)*100;
    double pb = b/(votos-1)*100;
    double pn = n/(votos-1)*100;

    Console.WriteLine(votos-1);
    Console.WriteLine($"Houve(ram) {v1} voto(s) para o C1, sendo {p1:0.0}%");
    Console.WriteLine($"Houve(ram) {v2} voto(s) para o C2, sendo {p2:0.0}%");
    Console.WriteLine($"Houve(ram) {v3} voto(s) para o C3, sendo {p3:0.0}%");
    Console.WriteLine($"Houve(ram) {v4} voto(s) para o C4, sendo {p4:0.0}%");
    Console.WriteLine($"Houve(ram) {b} voto(s) branco(s), sendo {pb:0.0}%");
    Console.WriteLine($"Houve(ram) {n} voto(s) nulo(s), sendo {pn:0.0}%");
    Console.WriteLine();

    if (v1 > v2 && v1 > v3 && v1 > v4) 
    {
      maior = maior + v1;
      Console.WriteLine($"O ganhador foi C1 com {maior} votos");
    }
    if (v2 > v1 && v2 > v3 && v2 > v4)
    { 
      maior = maior + v2;
      Console.WriteLine($"O ganhador foi C2 com {maior} votos");
    }
    if (v3 > v1 && v3 > v2 && v3 > v4) 
    {
      maior = maior + v3;
      Console.WriteLine($"O ganhador foi C3 com {maior} votos");
    }
    if (v4 > v1 && v4 > v2 && v4 > v3) 
    {
      maior = maior + v4;
      Console.WriteLine($"O ganhador foi C4 com {maior} votos");
    }
  }
}
