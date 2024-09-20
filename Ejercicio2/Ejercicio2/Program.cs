using System;
using static System.Console;

class Program
{
    static void avion()
    {
        WriteLine("░░░░░░░░░░░░░░░░░▄█▀▀█▄░░░░░░░░░░░░░░░░░");
        WriteLine("░░░░░░░░░░░░░░░░█▀░░░░▀█░░░░░░░░░░░░░░░░");
        WriteLine("░░░░░░░░░░░░░░░█▀░░▄▄░░▀█░░░░░░░░░░░░░░░");
        WriteLine("░░░░░░░░░░░░░░▄█░▄█▀▀█▄░█▄░░░░░░░░░░░░░░");
        WriteLine("░░░░░░░░░░░░░░█░░▀░░░░▀░░█░░░░░░░░░░░░░░");
        WriteLine("░░░░░░░░▄█▀█░░█░░░░░░░░░░█░░█▀█▄░░░░░░░░");
        WriteLine("░░░░░░░░█░░██▄█░░░░░░░░░░█▄██░░█░░░░░░░░");
        WriteLine("░░░▄▄▄░░█▄▄██▀█░░░░░░░░░░█▀██▄▄█░░▄▄▄░░░");
        WriteLine("░░█░░██▄█▀▀░░░█░░░░░░░░░░█░░░▀▀█▄██░░█░░");
        WriteLine("░░█▄▄█▀▀░░░░░░█░░░░░░░░░░█░░░░░░▀▀█▄▄█░░         ██████╗ ███████╗███████╗███████╗██████╗ ██╗   ██╗ █████╗ ██████╗ ");
        WriteLine("░▄█▀▀░░░░░░░░░█▄░░░░░░░░▄█░░░░░░░░░▀▀█▄░         ██╔══██╗██╔════╝██╔════╝██╔════╝██╔══██╗██║   ██║██╔══██╗██╔══██╗");
        WriteLine("█▀░░░░░▄▄▄▄▄████░░░░░░░░████▄▄▄▄▄░░░░░░█         ██████╔╝█████╗  ███████╗█████╗  ██████╔╝██║   ██║███████║██████╔╝");
        WriteLine("█▄▄▄█▀▀▀░░░░░░██░░░░░░░░██░░░░░░▀▀▀█▄▄▄█         ██╔══██╗██╔══╝  ╚════██║██╔══╝  ██╔══██╗╚██╗ ██╔╝██╔══██║██╔══██╗");
        WriteLine("▀▀░░░░░░░░░░░░██░░░░░░░░██░░░░░░░░░░░░▀▀         ██║  ██║███████╗███████║███████╗██║  ██║ ╚████╔╝ ██║  ██║██║  ██║");
        WriteLine("░░░░░░░░░░░░░░░█░░░░░░░░█░░░░░░░░░░░░░░░         ╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝╚═╝  ╚═╝  ╚═══╝  ╚═╝  ╚═╝╚═╝  ╚═╝");
        WriteLine("░░░░░░░░░░░░░░░█░░░░░░░░█░░░░░░░░░░░░░░░");
        WriteLine("░░░░░░░░░░░░░░░█▄▄█▀▀█▄▄█░░░░░░░░░░░░░░░");
        WriteLine("░░░░░░░░░░░░▄▄█▀▀░░░░░░▀▀█▄▄░░░░░░░░░░░░");
        WriteLine("░░░░░░░░░░▄█▀░░░▄▄▄██▄▄▄░░░▀█▄░░░░░░░░░░");
        WriteLine("░░░░░░░░░░█▄▄▄▄▄█▀░░░░▀█▄▄▄▄▄█░░░░░░░░░░");
        
    }
    static void Main()
    {
        // Inicialización de asientos (true = ocupado, false = libre)
        bool[] asientos = new bool[10];
        int opcion;

        while (true)
        {
            Clear();
            avion();
            WriteLine("\nPlease type 1 for 'smoking'");
            WriteLine("Please type 2 for 'nonsmoking'");


            if(!int.TryParse(ReadLine(), out opcion) || (opcion !=1 && opcion != 2))
            {
                Clear();
                avion();
                WriteLine("\nLa opcion ingresada es invalida,presione enter para intentar nuevamente");
                ReadKey();
            }
            else
            {
                if (opcion == 1)
                {
                    // Asignar asiento en la sección de fumar (1-5)
                    bool asientoAsignado = AsignarAsiento(asientos, 0, 4);

                    if (!asientoAsignado)
                    {
                        WriteLine("Sección de fumar llena. ¿Desea un asiento en la sección de no fumar? (y/n)");
                        string respuesta = ReadLine();

                        if (respuesta.ToLower() == "y")
                        {
                            asientoAsignado = AsignarAsiento(asientos, 5, 9);
                            if (!asientoAsignado)
                            {
                                WriteLine("Todos los asientos están ocupados. Next flight leaves in 3 hours.");
                            }
                        }
                        else
                        {
                            WriteLine("Next flight leaves in 3 hours.");
                        }
                    }
                }
                else if (opcion == 2)
                {
                    bool asientoAsignado = AsignarAsiento(asientos, 5, 9);

                    if (!asientoAsignado)
                    {
                        WriteLine("Sección de no fumar llena. ¿Desea un asiento en la sección de fumar? (y/n)");
                        string respuesta = ReadLine();

                        if (respuesta.ToLower() == "y")
                        {
                            asientoAsignado = AsignarAsiento(asientos, 0, 4);
                            if (!asientoAsignado)
                            {
                                WriteLine("Todos los asientos están ocupados. Next flight leaves in 3 hours.");
                            }
                        }
                        else
                        {
                            WriteLine("Next flight leaves in 3 hours.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                }

                if (Array.TrueForAll(asientos, a => a))
                {
                    WriteLine("Todos los asientos están ocupados. No se pueden hacer más reservaciones.");
                    break;
                }
            }
        }
    }

    static bool AsignarAsiento(bool[] asientos, int inicio, int fin)
    {
        for (int i = inicio; i <= fin; i++)
        {
            if (!asientos[i])
            {
                asientos[i] = true;
                WriteLine($"Asiento asignado: {i + 1} ({(inicio == 0 ? "Fumar" : "No fumar")})");
                ReadKey();
                return true;
            }
        }
        return false;
    }
}
