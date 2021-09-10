using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        /* Utilizamos el patrón SRP para identificar la responsabilidad de imprimir recetas 
        como exterior a la clase Recipe. Además, la aplicamos para definir una clase ConsolePrinter,
        responsable de imprimir recetas en consola.
        */
        public static void Print(string text){
            Console.WriteLine(text);
        }
    }
}