using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informe as notas dos 4 bimestres:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());

    int mp = ((a*2)+(b*2)+(c*3)+(d*3))/10;

    if (mp >= 6)
    Console.WriteLine($"Parabéns!Sua média foi {mp}. Você foi aprovado!");

    if (mp < 6)
    {
      Console.WriteLine("Informe a nota da prova final:");
      int e = int.Parse(Console.ReadLine());

      int mf = (mp + e)/2;
    
      if (mf >= 6)
      Console.WriteLine($"Parabéns! Sua média final foi {mf}.Você foi aprovado!");

      if (mf < 6)
      Console.WriteLine($"Infezlimente vc foi reprovado. Sua média final ficou {mf}");
    }
  }
}
