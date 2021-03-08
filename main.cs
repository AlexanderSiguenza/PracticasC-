using System;

/* Programa que permite hacer conversión de monedas 
   digitando una cantidad en dólares, utilizando 
   funciones.*/

class MainClass 
{
  public static void Main (string[] args) 
  {
    //Inicia el programa principal
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    Console.Clear(); 
    Console.Title = "Ejemplo3 utilizando la sintaxis de funciones";
    Double cantidad, resul;

    Console.WriteLine("Digitar la cantidad en dólares:");
    cantidad = Double.Parse(Console.ReadLine()); 

    resul = conversiones(cantidad, 'e'); // euros
    Console.WriteLine("Los {0} dolares son {1} euros ", cantidad, resul);

    resul = conversiones(cantidad, 'l'); // libras
    Console.WriteLine("Los {0} dolares son {1} libras ", cantidad, resul); 

    resul = conversiones(cantidad, 'b'); // Bitcoin
    Console.WriteLine("Los {0} dolares son {1} Bitcoin ", cantidad, resul); 

    Console.WriteLine("\n");
    Console.WriteLine("-->Fin del programa");
    Console.ReadKey();
  }  

  static Double conversiones(Double pcantidad , Char pmoneda)
  { 
    Double resul=0;
    switch (pmoneda) 
    {
      case 'e': // euros
        resul = pcantidad * 0.84;
        break;
      case 'l': // libras
        resul = pcantidad * 0.72;
        break;
      case 'b': // Bitcoin
        resul = pcantidad * 0.000020;
        break;
      default:
        Console.WriteLine("Por favor ingresar valores validos /  (l)->libras o (e)->euros (b)->Bitcoin");
        break;
    }
    return resul;
  }
  
}