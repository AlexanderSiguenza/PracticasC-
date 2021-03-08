using System;

 // Programa que permite digitar un número entero positivo y me diga si es par o impar.
 
class MainClass {

  public static void Main (string[] args) {  
    //Inicio del programa principal
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    Console.Clear();

    Console.Title = "Uso de un procedimiento";
    int num;
    Console.WriteLine("Digitar un numero entero positivo:");
    num = int.Parse(Console.ReadLine());
    Par(num);
    Console.WriteLine("\n");
    Console.WriteLine("-->Fin del programa");
    Console.ReadKey();
  }

  static void Par(int a)
  {
    int x;
    x = (a % 2);
    if (x == 0){
      Console.WriteLine("\nEs par");
    } else{
      Console.WriteLine("\nEs impar");
    }
  }

 
}