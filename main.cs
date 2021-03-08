using System;

class MainClass {

  public static void Main (string[] args) {   
   Console.ForegroundColor = ConsoleColor.Black; 
   Console.BackgroundColor = ConsoleColor.White; 
   
   Console.Clear(); 
   Console.Title = "Ejemplo1 de Funciones"; 
   Double num1, num2, resultado; 

   Console.WriteLine("Ingrese el primer número:"); 
   num1=Double.Parse(Console.ReadLine()); 
   
   Console.WriteLine("Ingrese el segundo numero:"); 
   num2=Double.Parse(Console.ReadLine());

   Console.WriteLine("--->primero el procedimiento Suma"); 
   Suma(num1, num2); // error en la suma

   Console.WriteLine("\n"); 
   Console.WriteLine("--->despues el procedimiento Multi"); 
   Multi(num1, num2); 

   Console.WriteLine("\n\n"); 
   Console.WriteLine("--->tercera la función resta"); 
   resultado = Resta(num1,num2);

   Console.WriteLine("La resta es: " + resultado); 
   Console.WriteLine("\n"); 
   Console.WriteLine("-->Fin del programa"); 
   Console.ReadKey();     
   } 
   
   // procedimiento
   static void Suma(Double pnum1, Double pnum2) 
   { 
    resultado = 0; 
    resultado = pnum1 + pnum2; 
    Console.WriteLine("La suma de los números es:" + resultado);     
   } 
   
     // procedimiento
   static void Multi(Double pnum1, Double pnum2) 
   {      
     resultado = 0;
     resultado = pnum1 * pnum2; 
     Console.WriteLine("La multiplicacion de los números es:" + resultado); 
   } 
      
   // función   
   static Double Resta(Double pnum1, Double pnum2) 
    {  
     resultado = 0;    
     resultado = pnum1 - pnum2; 
     return resultado;           
  }

   // función   
   static Double Operaciones(Double pnum1, Double pnum2, Char ope) // + , * , - 
    { 
     Double resul; 
     resul = pnum1 - pnum2; 
     return resul;        
  }
  
}