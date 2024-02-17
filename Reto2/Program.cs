using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2
{
    // Reto 2
    // Probar funciones y alcance de las mismas
    internal class Program
    {
        // Variable global
        static int variableGlobal = 10;

        // Función sin parámetros ni retorno
        static void Saludar()
        {
            Console.WriteLine("¡Hola, mundo!");
        }

        // Función con un parámetro y retorno
        static int Cuadrado(int numero)
        {
            return numero * numero;
        }

        static double CalcularPromedio(double[] numeros)
        {
            double suma = 0;
            foreach (var num in numeros)
            {
                suma += num;
            }
            return suma / numeros.Length;
        }

        // Función con una función dentro
        static void FuncionExterna()
        {
            Console.WriteLine("Este es el comienzo de FuncionExterna");

            // Función dentro de otra función
            void FuncionInterna()
            {
                Console.WriteLine("¡Hola desde la función interna!");
            }

            FuncionInterna();

            Console.WriteLine("Fin de FuncionExterna");
        }

        static void Main(string[] args)
        {
            // Llamada a la función sin parámetros ni retorno
            Saludar();

            // Llamada a la función con un parámetro y retorno
            int numeroEscogido = 15;
            int resultadoCuadrado = Cuadrado(numeroEscogido);
            Console.WriteLine($"El cuadrado de {numeroEscogido} es: {resultadoCuadrado}");

            // Llamada a la función con varios parámetros y retorno
            double[] numeros = { 2.5, 3.7, 1.8, 4.1, 5.6 };
            double promedio = CalcularPromedio(numeros);
            Console.WriteLine($"El promedio de los números es: {promedio}");

            // Llamada a la función con una función dentro
            FuncionExterna();

            // Uso de la variable global
            Console.WriteLine($"Valor de la variable global: {variableGlobal}");

            // Reto 2 EXTRA
            // Función que recibe dos parámetros de tipo string y retorna un número
            string string1 = "Múltiplo de 3";
            string string2 = "Múltiplo de 5";
            int numeroFuncion = FuncionExtra(string1, string2);
            Console.WriteLine($"El número en la función se ha impreso en lugar de los textos un número de {numeroFuncion} veces");
            Console.ReadKey();
        }

        static int FuncionExtra(string string1, string string2)
        {
            // Imprimir desde el 1 al 100
            int numeroEnviar = 0;
            for (int i = 1; i < 100; i++)
            {
                // Si es múltiplo de 3, imprime el primer string
                if (i % 3 == 0)
                {
                    Console.WriteLine(string1);
                }
                // Si es múltiplo de 5, imprime el segundo string
                else if (i % 5 == 0)
                {
                    Console.WriteLine(string2);
                }
                // Si es múltiplo de 3 y 5, imprime ambos string concatenados
                else if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine(string1 + ", " + string2);
                }
                // En caso contrario, imprime el número que pertoca y sube el contador del número a enviar, ya que no se mostró texto
                else
                {
                    Console.WriteLine(i);
                    numeroEnviar++;
                }
            }
            return numeroEnviar;
        }
    }
}
