using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicios_lambda
{
    class Program
    {
        public static void Main(string[] args)
        {
            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
            new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
        };

            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla los nombres de los estudiantes
            Console.WriteLine("El nombre de los estudiantes son:");
            var Nombres = details.Select(item => new { item.Nombre });
            string verNombre = string.Join(Environment.NewLine, Nombres);
            Console.WriteLine(verNombre);
            Console.WriteLine(" \n");
            //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
            Console.WriteLine("Estudiantes ordenados por Promedio");
            var LisPromedio = details.OrderByDescending(VPromedio => VPromedio.Promedio).Select(ite => new { ite.Nombre, ite.Apellido });
            string SPromedio = string.Join(Environment.NewLine, LisPromedio);
            Console.WriteLine(SPromedio);
            Console.WriteLine(" \n");
            //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
            Console.WriteLine("Estudiantes ordenados por apellidos");
            var OrdenarAlf = details.OrderBy(item => item.Apellido).Select(ite => new { ite.Apellido });
            string SOrdenar = string.Join(Environment.NewLine, OrdenarAlf);
            Console.WriteLine(SOrdenar);
            Console.WriteLine(" \n");
            //4. Muestre por pantalla los datos del estudiante mas joven
            Console.WriteLine("El estudiantes mas joven");
            var leer = details.OrderBy(a => a.Edad).First();
            Console.Write("ID:");
            Console.WriteLine(string.Join("", leer.Id, " Nombre:", leer.Nombre, " ", leer.Apellido, " Promedio:", leer.Promedio, " ", leer.Edad, " Años"));
            Console.WriteLine(" \n");

            //Ejercicio 2

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla el cuadrado de los números
            var cuadrado = list.Select(numero => numero * 2);

            Console.WriteLine("El cuadrado de los números");
            Console.WriteLine(string.Join("  ", cuadrado));
            //2. Muestre por pantalla los números pares
            Console.WriteLine("Los numeros pares son ");
            List<int> NumPares = list.FindAll(numeroPar => numeroPar % 2 == 0);
            Console.WriteLine(string.Join(" ", NumPares));
            Console.WriteLine("");
            //3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares
            Console.WriteLine("Los numeros impares multiplicados por 5:");
            List<int> BuscImpar = list.FindAll(par => par % 2 != 0);
            var Multiplicarx5 = BuscImpar.Select(num => num * 5);
            Console.WriteLine(string.Join(" ", Multiplicarx5));
        }
    }
}
