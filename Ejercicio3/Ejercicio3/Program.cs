using System;
using static System.Console;

class Program
    {
        static void Main()
        {
            double[,] sales = new double[5, 4];

            double[,] ventasDelMes = new double[,]
            {
            { 1, 1, 150.00 },
            { 1, 2, 200.50 },
            { 2, 1, 300.75 },
            { 3, 4, 120.40 },
            { 4, 5, 50.00 },
            { 1, 3, 400.25 },
            { 2, 2, 210.00 },
            { 3, 3, 320.00 },
            { 4, 1, 115.75 },
            { 2, 4, 340.30 },
            { 3, 2, 110.20 },
            { 4, 3, 220.00 }
            };


            for (int i = 0; i < ventasDelMes.GetLength(0); i++)
            {
                int vendedor = (int)ventasDelMes[i, 0] - 1; // Índice del vendedor (0-3)
                int producto = (int)ventasDelMes[i, 1] - 1; // Índice del producto (0-4)
                double valorVenta = ventasDelMes[i, 2]; // Valor vendido

        
                sales[producto, vendedor] += valorVenta;
            }

        WriteLine("Resumen de Ventas Totales (Producto vs Vendedor):\n");
        Write("Prod\\Vend |");
        for (int v = 0; v < 4; v++)
        {
            Write($" Vendedor {v + 1} |");
        }
        WriteLine(" Total Producto");

        WriteLine(new string('-', 68)); 

        double totalGeneral = 0;


        for (int producto = 0; producto < 5; producto++)
        {
            double totalPorProducto = 0;
            Write($"Producto {producto + 1} |");
            for (int vendedor = 0; vendedor < 4; vendedor++)
            {
                double venta = sales[producto, vendedor];
                totalPorProducto += venta;
                Write($" {venta,10:C2} |"); 
            }
            WriteLine($" {totalPorProducto,15:C2}"); 
            totalGeneral += totalPorProducto;
        }

        WriteLine(new string('-', 68)); 

        Write("Total Vendedor |");
        for (int vendedor = 0; vendedor < 4; vendedor++)
        {
            double totalPorVendedor = 0;
            for (int producto = 0; producto < 5; producto++)
            {
                totalPorVendedor += sales[producto, vendedor];
            }
            Write($" {totalPorVendedor,10:C2} |");
        }
        WriteLine();

        WriteLine(new string('-', 68)); 
        WriteLine($"Total General: {totalGeneral,48:C2}"); 
    }
}

        
    
