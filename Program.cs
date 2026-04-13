using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerTpAlgo2_act_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. Realizar un programa en el cual puedas:
                    a. Ingresar el tipo de factura que desea emitir.

                    Tipo 1: responsable inscripto, discrimina el 10,5%
                    Tipo 2: consumidor final, se aplica el 21%
                    Tipo 3: bienes y servicios, tiene una deducción del 27%
                    b. Ingresar la cantidad ítems, que ingreso en la factura.
                    c. Ingresar por cada uno de los ítems (o sea el número que ingreso, el primero será 1, el
                    segundo 2, etc.), articulo, precio, y cantidad. Calcular el importe de cada ítem, que es la
                    resultante de cantidad por precio.
                    d. Hallar el ítem de mayor valor, este deberá estar al final del programa y mostrar el ítem, el
                    precio, la cantidad y el importe.
                    e. Hallar el promedio de importe, mediante la suma de cada uno de los ítems y dividirlo por la
                    cantidad de ítems.*/



            int opcion, cantItems=0, cant=0, index=0, i=0, j=1;
            List<string> articulos = new List<string>();
            List<double> precios = new List<double>();
            List<int> cantidad = new List<int>();
            double precio = 0;
            string nombre;
            do
            {
                Console.Clear(); //Con eso limpiamos la pantalla cada vez que mostramos el menú, pueden sacarlo si no quieren

                Console.WriteLine("Ingrese el tipo de factura que desea emitir:");
                Console.WriteLine("1 - Responsable inscripto");
                Console.WriteLine("2 - Consumidor final");
                Console.WriteLine("3 - Bienes y servicios");
                Console.WriteLine("0 - Salir");

                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 3)
                {
                    Console.WriteLine("El valor ingresado es incorrecto, ingrese valores entre 0 y 3.\nIntente nuevamente:");

                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Responsabe inscripto. Se dicriminara el 10,5%.");
                        Console.ResetColor();
                        Console.Write("\nIngrese la cantidad de items: ");
                        while (!int.TryParse(Console.ReadLine(), out cantItems) || cantItems <=0)
                        {
                            
                            Console.Write("Valor incorrecto, se esperan solo números enteros mayores a 0 (cero): ");
                        }

                        for( i = 0; i < cantItems; i++)
                        {
                            Console.Clear();
                            Console.Write($"Ingrese el nombre del articulo N°{j}: ");
                            nombre=Console.ReadLine();
                            articulos.Add(nombre);
                            Console.Write("Ingrese el precio del articulo: $");
                            while (!double.TryParse(Console.ReadLine(), out precio))
                            {

                                Console.Write("Ingrese solo números para el precio: $");
                            }
                            precios.Add(precio);
                            Console.Write("Ingrese la cantidad de articulos: ");
                            while(!int.TryParse(Console.ReadLine(),out cant))
                            {
                                Console.Write("Error!. Se esperan solo números enteros.");
                            }
                            cantidad.Add(cant);
                            Console.BackgroundColor= ConsoleColor.Green;
                            Console.ForegroundColor= ConsoleColor.Black;
                            Console.WriteLine(" ¡Item ingresado a la factura con Exito!. Oprima cualquier tecla para continuar. ");
                            Console.ResetColor();
                            Console.ReadKey();
                            
                            j++;
                        }

                        Console.WriteLine("El item de mayor valor que se ingreso fue: ");
                        int indiceMax = 0;
                        double valorMax = precios[0];

                        for (i = 1; i < precios.Count; i++)
                        {
                            if (precios[i] > valorMax)
                            {
                                valorMax = precios[i];
                                indiceMax = i;
                            }
                        }

                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"-Articulo: {articulos[indiceMax]}, precio: ${precios[indiceMax]}, cantidad: {cantidad[indiceMax]}.");
                        Console.ResetColor();
                        Console.ReadKey ();

                        break;
                    case 2:
                        Console.WriteLine("Acá va el código de la opción 2.\n");
                        break;
                    case 3:
                        Console.WriteLine("Acá va el código de la opción 3.\n");
                        break;
                   

                }
                //Console.WriteLine("\nPresione una tecla para continuar...");
                //Console.ReadKey(); //esto es para que se vea el resultado antes de limpiar la pantalla

            } while (opcion != 0);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" Se ingreso el valor 0, se finalizara el programa.¡Hasta luego! ");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
