using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- ejercicio 1");
                Console.WriteLine("2- ejercicio 2");
                Console.WriteLine("3- ejercicio 3");
                Console.WriteLine("4- salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1();
                        break;

                    case 2:
                        Console.Clear();
                        Ejercicio2();

                        break;
                        Console.Clear();
                        Ejercicio3();


                    case 3: break;




                    default:
                        Console.Clear();
                        Console.WriteLine("Digito opcion incorrecta");
                        break;

                }






            } while (opcion != 4);


        }

        public static void Ejercicio1()
        //hacer un algoritmo de una tienda que vende camisas, si la persona se lleva una camisa se lo lleva a precio de costo, 
        //si la persona se lleva entre 2 y 5 camisas se le hace un descuento del 15%
        //si la persona se lleva más de 5 el descuento es de 20%
        //El sistema debe solicitar la cantidad de camisas y el precio de las camisas
        {
            float precio = 0f;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("cual es el precio de la camisa: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad:");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"total a pagar: {cantidad * precio}");
            }
            if (cantidad >= 2 && cantidad <= 5)
            {
                total = precio * 0.15f;
                total = precio - total;
                Console.WriteLine($"total a pagar: {total} con un descuento de 15%");
            }
            if (cantidad >= 6)
            {
                total = precio * 0.20f;
                total = precio - total;
                Console.WriteLine($"total a pagar: {total} con un descuento de 20%");
            }

        }
        public static void Ejercicio2()
        {
            //Desarrolle un algoritmo que calcule el promedio final para un estudiante del curso de Programación 1.
            //Deberá leer los siguientes datos para cada estudiante:
            //carnet, nombre, quiz 1, quiz 2, quiz 3, tarea 1, tarea 2, tarea 3, examen 1, examen 2 y examen 3.
            //El programa deberá calcular el porcentaje de quices (25%), porcentaje de tareas (30%), y el porcentaje de exámenes (45%).
            //El algoritmo tiene que calcular el promedio final y reportar el carnet, nombre, porcentaje de quices, porcentaje de tareas,
            //porcentaje de exámenes, promedio final y condición del estudiante. La condición del estudiante esta con base a:
            //Si el promedio final es mayor o igual a 70 “Aprobado”. Si el promedio final es mayor o igual a 50 y menor que 70 “Aplazado”
            //y si el promedio final es menor que 50 “Reprobado”. 
            float promediofinal = 0, quiz1 = 0, quiz2 = 0, quiz3 = 0, tarea1 = 0, tarea2 = 0, tarea3 = 0, examen1 = 0, examen2 = 0, examen3 = 0,porcentajequiz = 0, porcentajeexamen = 0,porcentajetarea =0;
            int carnet = 0;
            string nombre, condicion;

            Console.WriteLine("Digite el nombre del estudiante:");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite el numero de carnet del estuante:");
            carnet = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota del Quiz 1: ");
            quiz1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del Quiz 2: ");
            quiz2 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del Quiz 3: ");
            quiz3 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota de la Tarea 1: ");
            tarea1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota de la Tarea 2: ");
            tarea2 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota de la Tarea 3: ");
            tarea3 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del Examen 1: ");
            examen1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del Examen 2: ");
            examen2 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del Examen 3: ");
            examen3 = float.Parse(Console.ReadLine());

            porcentajequiz = (quiz1 + quiz2 + quiz3) / 3 * 0.25f;
            porcentajeexamen = (examen1 + examen2 + examen3) / 3 * 0.45f;
            porcentajetarea = (tarea1 + tarea2 + tarea3) / 3 * 0.30f;

            promediofinal = porcentajetarea + porcentajequiz + porcentajeexamen;


            if (promediofinal >= 70)
                condicion = "aprobado";
            else if (promediofinal >= 50 && promediofinal <= 70)
                condicion = "aplazado";
            else 
                condicion = "reprobado";

            Console.WriteLine($"Nombre {nombre}");
            Console.WriteLine($"Carnet {carnet}");
            Console.WriteLine($"Porcentaje total de los 3 quices: {porcentajequiz}");
            Console.WriteLine($"Porcentaje total de los 3 examenes: {porcentajeexamen}");
            Console.WriteLine($"Porcentaje total de las 3 tareas : {porcentajetarea}");
            Console.WriteLine($"El promedio final es : {promediofinal}");
            Console.WriteLine($"La condición del estudiante es: {condicion}");
        }
        public static void Ejercicio3()
        //Un vendedor ofrece su producto de la siguiente manera:
        //Si le compran 10 productos o menos, el precio por producto es de $20.
        //Si le compran más de 10 artículos, el precio es de $15 por artículo.
        //Realice un algoritmo y diagrama de flujo que con solo proporcionarle la cantidad de artículos dé como resultado el precio y el total.


        {
            int cantidad = 0;
            float total = 0, precio = 0;

            Console.WriteLine("Digite la cantidad de productos que lleva:");
            cantidad = int.Parse(Console.ReadLine());

            if ( cantidad <= 10 )
            { 
                precio = 20;
                total = 20 * cantidad;
            }
            else
            { 
                precio = 15;
                total = 15 * cantidad;

                Console.WriteLine($"El precio del articulo es de: ${precio}");
                Console.WriteLine($"El total a pagar es de:${total}");

                
            }
             


        }




    }
}
