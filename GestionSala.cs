using System;
using System.IO;

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
                        //YOSSELYN//
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
                                            SeleccionarFechaYHorario("Culpa_mia", asiento1, total1);
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
                                            SeleccionarFechaYHorario("Una_chica_del_siglo_xx", asiento2, total2);
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
                                            SeleccionarFechaYHorario("Yo_antes_de_ti", asiento3, total3);
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
                        //YOSSELYN//



                        /////////////////// JUDITH ////////////////////////////
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
                                            SeleccionarFechaYHorario("Camino hacia el terror", asiento1, total1);
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
                                            SeleccionarFechaYHorario("La reencarnación", asiento2, total2);
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
                                            SeleccionarFechaYHorario("La Monja", asiento3, total3);
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

                        ///////////////////////////// JUDITH ///////////////////////////////////


                        //-------------------------------YAMILET--------------------------------//
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
                                            SeleccionarFechaYHorario("Son como niños", asiento1, total1);
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
                                            SeleccionarFechaYHorario("La Máscara", asiento2, total2);
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
                                            SeleccionarFechaYHorario("La Máscara", asiento3, total3);
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
        
        //----------------------------------------YAMILETH--------------------------------------//

        static void SeleccionarFechaYHorario(string pelicula, int asientos, double total)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSeleccione la fecha y el horario para la película {pelicula}:");

            // Lista de fechas disponibles para cada película
            List<DateTime> fechasDisponibles = new List<DateTime>
            {
                DateTime.Now.Date,
                DateTime.Now.Date.AddDays(1),
                DateTime.Now.Date.AddDays(2),
                DateTime.Now.Date.AddDays(3),
                DateTime.Now.Date.AddDays(4),
                DateTime.Now.Date.AddDays(5)
            };

            // Mostrar fechas disponibles
            for (int i = 0; i < fechasDisponibles.Count; i++)
            {
                Console.WriteLine($"\n{i + 1}. {fechasDisponibles[i]:yyyy-MM-dd}");
            }

            // Obtener la elección del usuario
            int opcionFecha;
            if (int.TryParse(Console.ReadLine(), out opcionFecha) && opcionFecha >= 1 && opcionFecha <= fechasDisponibles.Count)
            {
                DateTime fechaReserva = fechasDisponibles[opcionFecha - 1];
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nSeleccione un horario para la fecha {fechaReserva:yyyy-MM-dd}:");
                Console.ResetColor();

                // Lista de horarios disponibles para cada película y fecha
                List<string> horariosDisponibles = new List<string> { "12:00 PM", "03:00 PM", "06:00 PM", "09:00 PM" };

                // Mostrar horarios disponibles
                for (int i = 0; i < horariosDisponibles.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {horariosDisponibles[i]}");
                }

                // Obtener la elección del usuario
                int opcionHorario;
                if (int.TryParse(Console.ReadLine(), out opcionHorario) && opcionHorario >= 1 && opcionHorario <= horariosDisponibles.Count)
                {
                    string horarioSeleccionado = horariosDisponibles[opcionHorario - 1];
                    GuardarInformacion(pelicula, asientos, total, fechaReserva, horarioSeleccionado);
                }
                else
                {
                    Console.WriteLine("Opción de horario no válida.");
                }
            }
            else
            {
                Console.WriteLine("Opción de fecha no válida.");
            }
        }

        static void GuardarInformacion(string pelicula, int asientos, double total, DateTime fechaReserva, string horario)
        {
            string fechaHoraActual = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string filePath = $"{pelicula}_reservacion_{fechaHoraActual}.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine("----------------------------------------");
                    sw.WriteLine("**************** TICKET *****************");
                    sw.WriteLine($"Fecha de reserva: {fechaReserva:yyyy-MM-dd}");
                    sw.WriteLine($"Pelicula a ver: {pelicula}");
                    sw.WriteLine($"Horario: {horario}");
                    sw.WriteLine($"Asientos reservados: {asientos}");
                    sw.WriteLine($"Total a pagar por la reservación: ${total}");
                    sw.WriteLine("****************************************");
                    sw.WriteLine("----------------------------------------");
                }
                
                Console.WriteLine("\nInformación guardada exitosamente.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n-------IMPRESIÓN DE TICKET--------");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("**************** TICKET *****************");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Fecha de reserva: {fechaReserva:yyyy-MM-dd}");
                Console.WriteLine($"Pelicula a ver: {pelicula}");
                Console.WriteLine($"Horario: {horario}");
                Console.WriteLine($"Asientos reservados: {asientos}");
                Console.WriteLine($"Total a pagar por la reservación: ${total}");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("****************************************");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------------------------------");
                Console.ResetColor();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar la información: {ex.Message}");
            }
        } 
    }
}


