using System;

class Program
{
    static void Main()
    {
        // Declaración del arreglo para contar los vendedores en cada rango salarial.
        int[] contadores = new int[9];

        // Ejemplo de ventas brutas de los vendedores (puedes modificar este arreglo para pruebas).
        double[] ventasBrutas = { 1500, 3000, 700, 800, 1200, 4000, 2500, 5500, 950, 2300 };

        // Constantes para el cálculo del salario.
        const double salarioBase = 200;
        const double porcentajeComision = 0.09;

        // Calcular el salario de cada vendedor y actualizar el contador correspondiente.
        foreach (double ventas in ventasBrutas)
        {
            // Calcular el salario semanal.
            double salario = salarioBase + (ventas * porcentajeComision);
            int salarioEntero = (int)salario; // Truncar a entero.

            // Determinar el índice del rango salarial en el arreglo de contadores.
            int indice = ObtenerIndiceRango(salarioEntero);

            // Incrementar el contador del rango correspondiente.
            if (indice != -1)
            {
                contadores[indice]++;
            }
        }

        // Imprimir los resultados con formato mejorado.
        Console.WriteLine("*************** Resumen de Salarios de Vendedores ***************");
        Console.WriteLine("Rango de Salario\t\tCantidad de Vendedores");
        Console.WriteLine("---------------------------------------------------------------");

        // Imprimir cada rango salarial con su cantidad de vendedores.
        Console.WriteLine($"$200 - $299\t\t\t\t{contadores[0]}");
        Console.WriteLine($"$300 - $399\t\t\t\t{contadores[1]}");
        Console.WriteLine($"$400 - $499\t\t\t\t{contadores[2]}");
        Console.WriteLine($"$500 - $599\t\t\t\t{contadores[3]}");
        Console.WriteLine($"$600 - $699\t\t\t\t{contadores[4]}");
        Console.WriteLine($"$700 - $799\t\t\t\t{contadores[5]}");
        Console.WriteLine($"$800 - $899\t\t\t\t{contadores[6]}");
        Console.WriteLine($"$900 - $999\t\t\t\t{contadores[7]}");
        Console.WriteLine($"$1000 o superior\t\t\t{contadores[8]}");

        Console.WriteLine("---------------------------------------------------------------");

        // Total de vendedores
        int totalVendedores = 0;
        foreach (int contador in contadores)
        {
            totalVendedores += contador;
        }
        Console.WriteLine($"Total de Vendedores: {totalVendedores}");

        // Valor promedio de las ventas de los vendedores
        double sumaVentas = 0;
        foreach (double ventas in ventasBrutas)
        {
            sumaVentas += ventas;
        }
        double promedioVentas = sumaVentas / ventasBrutas.Length;
        Console.WriteLine($"Promedio de Ventas: {promedioVentas:C2}");

        Console.WriteLine("***************************************************************");
    }

    // Método que determina el índice del rango salarial basado en el salario del vendedor.
    static int ObtenerIndiceRango(int salario)
    {
        if (salario >= 200 && salario <= 299) return 0;
        if (salario >= 300 && salario <= 399) return 1;
        if (salario >= 400 && salario <= 499) return 2;
        if (salario >= 500 && salario <= 599) return 3;
        if (salario >= 600 && salario <= 699) return 4;
        if (salario >= 700 && salario <= 799) return 5;
        if (salario >= 800 && salario <= 899) return 6;
        if (salario >= 900 && salario <= 999) return 7;
        if (salario >= 1000) return 8;

        return -1; // Este caso no debería ocurrir con los valores proporcionados.
    }
}
