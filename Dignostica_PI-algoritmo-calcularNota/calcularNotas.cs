using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dignostica_PI_algoritmo_calcularNota
{
    public class calcularNotas
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            double Nota1_1C, Nota2_1C, Nota3_1C, Nota4_1C, Nota1_2C, Nota2_2C, Nota3_2C, Nota4_2C, Nota1_3C, Nota2_3C;
            double promedio1C, promedio2C, promedio3C, notafinal;


            Console.WriteLine("|-|-|-|-|-|-|-|-|-|-|-| POLITECNICO INTERNACIONAL - APLICATIVO DE NOTAS |-|-|-|-|-|-|-|-|-|");

            Console.WriteLine("Corte 1 ");

            Console.WriteLine("Digite la nota 1: ");
            Nota1_1C = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 2: ");
            Nota2_1C = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 3: ");
            Nota3_1C = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 4: ");
            Nota4_1C = double.Parse(Console.ReadLine());

            Console.WriteLine("Corte 2 ");
            Console.WriteLine("Digite la nota 1: ");
            Nota1_2C = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 2: ");
            Nota2_2C = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 3: ");
            Nota3_2C = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 4: ");
            Nota4_2C = double.Parse(Console.ReadLine());

            Console.WriteLine("Corte 3 ");
            Console.WriteLine("Digite la nota 1: ");
            Nota1_3C = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 2: ");
            Nota2_3C = double.Parse(Console.ReadLine());

            promedio1C = (Nota1_1C * 0.1 + Nota2_1C * 0.4 + Nota3_1C * 0.5 + Nota4_1C * 0.5);
            promedio2C = (Nota1_2C * 0.5 + Nota2_2C * 0.10 + Nota3_2C * 0.10 + Nota4_2C * 0.10);
            promedio3C = (Nota1_3C * 0.20 + Nota2_3C * 0.30);

            notafinal = (promedio1C * 0.15 + promedio2C * 0.35 + promedio3C * 0.50);

            Console.WriteLine($"La nota del corte 1 es: {promedio1C} ");
            Console.WriteLine($"La nota del corte 1 es: {promedio2C} ");
            Console.WriteLine($"La nota del corte 1 es: {promedio3C} ");
            Console.WriteLine($"Su Nota Final: {notafinal} ");

            Console.ReadKey();
        }
    }
}
