using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informe a placa do carro no formato AAA-4444:");
    string placa = Console.ReadLine();
    int i = placa.Length-1;

    if (placa[i] == '1' || placa[i] == '2')
    Console.WriteLine("Deverá pagar o IPVA em Fevereiro.");

    if (placa[i] == '3' || placa[i] == '4')
    Console.WriteLine("Deverá pagar o IPVA em Março.");

    if (placa[i] == '5' || placa[i] == '6')
    Console.WriteLine("Deverá pagar o IPVA em Abril.");

    if (placa[i] == '7' || placa[i] == '8')
    Console.WriteLine("Deverá pagar o IPVA em Maio.");

    if (placa[i] == '9' || placa[i] == '0')
    Console.WriteLine("Deverá pagar o IPVA em Junho.");
    
  }
}
