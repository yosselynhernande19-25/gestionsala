using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Iniciando Programa

            int opciones;

            do
            {
                //PROGRAMA PARA SIMULAR RESERVA DE ASIENTOS EN EL CINE
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nBIENVENIDO A NUESTRA TAQUILLA EN LINEA");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n---------------CATEGORIAS---------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1- Romance");
                Console.WriteLine("2- Terror");
                Console.WriteLine("3- Comedia");
                Console.WriteLine("4. Salir");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Ingrese una opción (1-4): ");
                Console.ResetColor();


                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                    switch (opciones)
                    {

                        case 1:
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n-----------ROMANCE----------");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("1. Culpa mía---------------------$5");
                                Console.WriteLine("2. Una chica del siglo xx--------$4.50");
                                Console.WriteLine("3. Yo antes de ti----------------$5.50");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("¿Que pelicula deseas ver? ");
                                Console.ResetColor();

                                int pelicula;
                                if (int.TryParse(Console.ReadLine(), out pelicula))
                                {
                                    switch (pelicula)
                                    {
                                        case 1:
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("\n-------Culpa mía--------");
                                            Console.WriteLine("--------Asientos------");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("¿Cuantos asientos nesesita? ");
                                            int asiento1 = Convert.ToInt32(Console.ReadLine());
                                            double total1 = (asiento1 * 5);
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("\nPelicula a ver ..................Culpa mía");
                                            Console.WriteLine("Asientos reservados ............." + asiento1);
                                            Console.WriteLine("Total a pagar ...................$" + total1);
                                            Console.ResetColor();

                                            break;

                                        case 2:
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("\n--------Una chica del siglo XX--------");
                                            Console.WriteLine("--------Asientos------");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("¿Cuantos asientos nesesita? ");
                                            int asiento2 = Convert.ToInt32(Console.ReadLine());
                                            double total2 = (asiento2 * 4.50);
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("\nPelicula a ver ..................Una chica del siglo xx");
                                            Console.WriteLine("Asientos reservados ............." + asiento2);
                                            Console.WriteLine("Total a pagar ...................$" + total2);
                                            Console.ResetColor();

                                            break;

                                        case 3:
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("\n--------Yo antes de ti--------");
                                            Console.WriteLine("--------Asientos------");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("¿Cuantos asientos nesesita? ");
                                            int asiento3 = Convert.ToInt32(Console.ReadLine());
                                            double total3 = (asiento3 * 5.50);
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("\nPelicula a ver ..................Yo antes de ti");
                                            Console.WriteLine("Asientos reservados ............." + asiento3);
                                            Console.WriteLine("Total a pagar ...................$" + total3);
                                            Console.ResetColor();

                                            break;

                                        default:
                                            Console.WriteLine("Opción no válida");
                                            break;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("\nEntrada no válida.");
                                }
                                break;

                            } while (opciones != 3);
                            break;


                        case 2:
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n-----------TERROR----------");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("1. Camino hacia el terror-----$2.50");
                                Console.WriteLine("2. La reencarnación-----------$2.75");
                                Console.WriteLine("3.La monja--------------------$5.00");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("¿Que pelicula deseas ver? ");
                                Console.ResetColor();

                                int pelicula;
                                if (int.TryParse(Console.ReadLine(), out pelicula))
                                {
                                    switch (pelicula)
                                    {
                                        case 1:
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("\n--------Camino hacia el terror--------");
                                            Console.WriteLine("--------Asientos------");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("¿Cuantos asientos nesesita? ");
                                            int asiento1 = Convert.ToInt32(Console.ReadLine());
                                            double total1 = (asiento1 * 2.50);
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("\nPelicula a ver ..................Camino hacia el terror");
                                            Console.WriteLine("Asientos reservados ............." + asiento1);
                                            Console.WriteLine("Total a pagar ...................$" + total1);
                                            Console.ResetColor();
                                            break;

                                        case 2:
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("\n--------La reencarnación--------");
                                            Console.WriteLine("--------Asientos------");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("¿Cuantos asientos nesesita? ");
                                            int asiento2 = Convert.ToInt32(Console.ReadLine());
                                            double total2 = (asiento2 * 2.75);
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("\nPelicula a ver ..................La reencarnación");
                                            Console.WriteLine("Asientos reservados ............." + asiento2);
                                            Console.WriteLine("Total a pagar ...................$" + total2);
                                            Console.ResetColor();
                                        break;

                                        case 3:
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("\n--------La Monja--------");
                                            Console.WriteLine("--------Asientos------");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("¿Cuantos asientos nesesita? ");
                                            int asiento3 = Convert.ToInt32(Console.ReadLine());
                                            double total3 = (asiento3 * 5.00);
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("\nPelicula a ver ..................La reencarnación");
                                            Console.WriteLine("Asientos reservados ............." + asiento3);
                                            Console.WriteLine("Total a pagar ...................$" + total3);
                                            Console.ResetColor();
                                        break;

                                    }

                                }
                                else
                                {
                                    Console.WriteLine("\nEntrada no válida.");
                                }
                                break;

                            } while (opciones != 3);
                            break;

                        case 3:
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n-----------COMEDIA----------");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("1. Son como niños---------------$3.75");
                                Console.WriteLine("2. La máscara-------------------$2.50");
                                Console.WriteLine("3. Stuart Little----------------$4.50");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("¿Que pelicula deseas ver? ");
                                Console.ResetColor();

                                int pelicula;
                                if (int.TryParse(Console.ReadLine(), out pelicula))
                                {
                                    switch (pelicula)
                                    {
                                        case 1:
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("\n--------Son como niños--------");
                                            Console.WriteLine("--------Asientos------");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("¿Cuantos asientos nesesita? ");
                                            int asiento1 = Convert.ToInt32(Console.ReadLine());
                                            double total1 = (asiento1 * 3.75);
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("\nPelicula a ver ..................Son como niños");
                                            Console.WriteLine("Asientos reservados ............." + asiento1);
                                            Console.WriteLine("Total a pagar ...................$" + total1);
                                            Console.ResetColor();
                                            break;

                                        case 2:
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("\n--------La Máscara--------");
                                            Console.WriteLine("--------Asientos------");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("¿Cuantos asientos nesesita? ");
                                            int asiento2 = Convert.ToInt32(Console.ReadLine());
                                            double total2 = (asiento2 * 2.50);
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("\nPelicula a ver ..................La Máscara");
                                            Console.WriteLine("Asientos reservados ............." + asiento2);
                                            Console.WriteLine("Total a pagar ...................$" + total2);
                                            Console.ResetColor();
                                            break;

                                        case 3:
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("\n--------Stuart Little--------");
                                            Console.WriteLine("--------Asientos------");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("¿Cuantos asientos nesesita? ");
                                            int asiento3 = Convert.ToInt32(Console.ReadLine());
                                            double total3 = (asiento3 * 4.50);
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("\nPelicula a ver ..................Stuart Little");
                                            Console.WriteLine("Asientos reservados ............." + asiento3);
                                            Console.WriteLine("Total a pagar ...................$" + total3);
                                            Console.ResetColor();
                                            break;


                                        default:
                                            Console.WriteLine("Opción no válida");
                                            break;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("\nEntrada no válida.");
                                }
                                break;

                            } while (opciones != 3);
                            break;
                    
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada no válida.");
                }
            } while (opciones != 4);

        }
        
    }
}