using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a cidade de origem:");
    string origem = Console.ReadLine();
    Console.WriteLine("Digite a cidade de destino");
    string destino = Console.ReadLine();
    Console.WriteLine("Digite a distância percorrida em quilômetros:");
    double distância = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a velocidade média em km/h:");
    double velocidade = double.Parse(Console.ReadLine());

    double tempo = distância/velocidade;

    string[] horas = tempo.ToString().Split('.',',');
    int hora = int.Parse(horas[0]);
    int m1 = int.Parse(horas[1]);

    int minutos = m1 * 6;
    
    Console.WriteLine($"O tempo estimado de viagem entre {origem} e {destino} é de {hora} horas e {minutos} minutos");
  }
}
