using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informe uma data:");
    string[] data = Console.ReadLine().Split('/');
    int dia = int.Parse(data[0]);
    int mes = int.Parse(data[1]);
    int ano = int.Parse(data[2]);

    if (mes == 1 && dia > 1 && dia < 31 && ano >= 1901 && ano <= 2099 ||
        mes == 2 && dia > 1 && dia < 28 && ano >= 1901 && ano <= 2099 ||
        mes == 3 && dia > 1 && dia < 31 && ano >= 1901 && ano <= 2099 ||
        mes == 4 && dia > 1 && dia < 30 && ano >= 1901 && ano <= 2099 ||
        mes == 5 && dia > 1 && dia < 31 && ano >= 1901 && ano <= 2099 ||
        mes == 6 && dia > 1 && dia < 30 && ano >= 1901 && ano <= 2099 ||
        mes == 7 && dia > 1 && dia < 31 && ano >= 1901 && ano <= 2099 ||
        mes == 8 && dia > 1 && dia < 31 && ano >= 1901 && ano <= 2099 ||
        mes == 9 && dia > 1 && dia < 30 && ano >= 1901 && ano <= 2099 ||
        mes == 10 && dia > 1 && dia < 31 && ano >= 1901 && ano <= 2099 ||
        mes == 11 && dia > 1 && dia < 30 && ano >= 1901 && ano <= 2099 ||
        mes == 12 && dia > 1 && dia < 31 && ano >= 1901 && ano <= 2099 ||
        mes == 2 && dia == 29 && ano % 4 == 0)
        Console.WriteLine("Essa data é válida");
        else
        Console.WriteLine("Essa data não é válida");
  }
}
