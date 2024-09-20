using System;
using static System.Console;

class Program 
{
                                
    static void Dado()
    {
        WriteLine("┌───────────────┐");
        WriteLine("│               │");
        WriteLine("│   █       █   │    ██████╗  █████╗ ██████╗  ██████╗ ");
        WriteLine("│               │    ██╔══██╗██╔══██╗██╔══██╗██╔═══██╗");
        WriteLine("│   █       █   │    ██║  ██║███████║██║  ██║██║   ██║");
        WriteLine("│               │    ██║  ██║██╔══██║██║  ██║██║   ██║");
        WriteLine("│   █       █   │    ██████╔╝██║  ██║██████╔╝╚██████╔╝");
        WriteLine("│               │    ╚═════╝ ╚═╝  ╚═╝╚═════╝  ╚═════╝ ");
        WriteLine("└───────────────┘");
    }
    static void Main()
    {
        Random rand = new Random();

        int[] sumas = new int[13]; // El índice 0 y 1 no se usan (Porque?)

        int totalTiradas = 36000;

        for (int i = 0; i < totalTiradas; i++)
        {
            int dado1 = rand.Next(1, 7); 
            int dado2 = rand.Next(1, 7); 
            int suma = dado1 + dado2;    

            sumas[suma]++;
        }

        Dado();
        WriteLine("Suma\tFrecuencia\tPorcentaje\tGráfico de barras");
        WriteLine("--------------------------------------------------------");

        for (int i = 2; i <= 12; i++)
        {
            double porcentaje = (double)sumas[i] / totalTiradas * 100;
            int numBarras = (int)(porcentaje *2);
            string barras = new string('█', numBarras);
            WriteLine($"{i}\t{sumas[i]}\t\t{porcentaje:F2}%\t\t{barras}");
        }

        WriteLine("\nVerificación de la suma 7:");
        WriteLine($"Frecuencia de 7: {sumas[7]}");
        WriteLine($"Frecuencia esperada (aprox): 6000");
        ReadKey();
    }
}

