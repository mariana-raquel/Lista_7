using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informe um valor monetário até 1000 reais");
    int i = int.Parse(Console.ReadLine());
    if (i == 100 || i == 1000)
    {
      if (i == 100) Console.Write("Cem");
      if (i == 1000) Console.Write("Mil");
    }
    else 
    {
      int c = i / 100;
      i = i % 100;
      int d = i / 10;
      int u = i % 10;
      
      if (i > 19)
      {
        switch(c)
        {
          case 1: Console.Write("Cento"); break;
          case 2: Console.Write("Duzentos"); break;
          case 3: Console.Write("Trezentos"); break;
          case 4: Console.Write("Quatrocentos"); break;
          case 5: Console.Write("Quinhentos"); break;
          case 6: Console.Write("Seiscentos"); break;
          case 7: Console.Write("Setecentos"); break;
          case 8: Console.Write("Oitocentos"); break;
          case 9: Console.Write("Novescentos"); break;
        }
        if (c != 0 && (d != 0 || u != 0))
          Console.Write($" e ");
        switch(d)
          {
            case 1: Console.Write("Dez"); break;
            case 2: Console.Write("Vinte"); break;
            case 3: Console.Write("Trinta"); break;
            case 4: Console.Write("Quarenta"); break;
            case 5: Console.Write("Cinquenta"); break;
            case 6: Console.Write("Sessenta"); break;
            case 7: Console.Write("Setenta"); break;
            case 8: Console.Write("Oitenta"); break;
            case 9: Console.Write("Noventa"); break;
          }
          if (d != 0 && u != 0)
            Console.Write($" e ");
        switch(u)
        {
          case 1: Console.Write("Um"); break;
          case 2: Console.Write("Dois"); break;
          case 3: Console.Write("Três"); break;
          case 4: Console.Write("Quatro"); break;
          case 5: Console.Write("Cinco"); break;
          case 6: Console.Write("Seis"); break;
          case 7: Console.Write("Sete"); break;
          case 8: Console.Write("Oito"); break;
          case 9: Console.Write("Nove"); break;    
        }
      }
      if (i <= 19)
      {
        switch(i)
        {
          case 1: Console.Write("Um"); break;
          case 2: Console.Write("Dois"); break;
          case 3: Console.Write("Três"); break;
          case 4: Console.Write("Quatro"); break;
          case 5: Console.Write("Cinco"); break;
          case 6: Console.Write("Seis"); break;
          case 7: Console.Write("Sete"); break;
          case 8: Console.Write("Oito"); break;
          case 9: Console.Write("Nove"); break; 
          case 10: Console.Write("Dez"); break;
          case 11: Console.Write("Onze"); break;
          case 12: Console.Write("Doze"); break;
          case 13: Console.Write("Treze"); break;
          case 14: Console.Write("Quatorze"); break;
          case 15: Console.Write("Quinze"); break;
          case 16: Console.Write("Desseis"); break;
          case 17: Console.Write("Dezessete"); break;
          case 18: Console.Write("Dezoito"); break;
          case 19: Console.Write("Dezenove"); break;
        }
      }
    }
    Console.WriteLine();
  }
}
