using System;

namespace Case6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - decimeter");
            Console.WriteLine("2 - kilometer");
            Console.WriteLine("3 - meter");
            Console.WriteLine("4 - millimeter");
            Console.WriteLine("5 - centimeter");
            Console.WriteLine("Vibirite odnoy iz izmereniy dlini:");
            int lengthMeasurements = int.Parse(Console.ReadLine());
            while ((lengthMeasurements < 1) || (lengthMeasurements > 5))
            {
                Console.WriteLine("Vibirite odin iz variantov izmereniy dlini ot 1 do 5.");
                lengthMeasurements = int.Parse(Console.ReadLine());
            }
            Console.Write("Dlina otrezok: ");
            double length = double.Parse(Console.ReadLine());
            double meter;
            {
                switch (lengthMeasurements)
                {
                    case 1:
                        meter = length / 10;
                        Console.WriteLine($"{length} decimeter to meter = {meter} meter");
                        break;
                    case 2:
                        meter = length * 1000;
                        Console.WriteLine($"{length} kilometer to meter = {meter} meter");
                        break;
                    case 3:
                        meter = length;
                        Console.WriteLine($"{length} meter to meter = {meter} meter");
                        break;
                    case 4:
                        meter = length / 1000;
                        Console.WriteLine($"{length} millimeter to meter = {meter} meter");
                        break;
                    case 5:
                        meter = length / 100;
                        Console.WriteLine($"{length} centimeter to meter = {meter} meter");
                        break;
                }

            }
        }
    }
}