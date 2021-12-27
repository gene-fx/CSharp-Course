using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioAula_MetodosAbstratos.Entities;
using ExercicioAula_MetodosAbstratos.Entities.Enums;

namespace ExercicioAula_MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            
            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Shape #{i} data:");
                Console.WriteLine(" Rectangle or Circle (r/c): ");
                char inputOpt = char.Parse(Console.ReadLine().ToLower().Trim());
                while(inputOpt != 'r' && inputOpt != 'c')
                {
                    Console.WriteLine(" Rectangle or Circle (r/c): ");
                    inputOpt = char.Parse(Console.ReadLine().ToLower().Trim());
                }

                Console.WriteLine("Color (Black/Blue/Red): ");
                string inputColor = Console.ReadLine().Trim().ToLower();
                while(inputColor != "black" && inputColor!= "blue" && inputColor != "red")
                {
                    Console.WriteLine("Color (Black/Blue/Red): ");
                    inputColor = Console.ReadLine().Trim().ToLower();
                }

                Color color = Enum.Parse<Color>(inputColor);


                if (inputOpt == 'r')
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Rectangle area");
                    Console.WriteLine($"Shape #{i}");
                    Console.Write("Width: ");
                    double inputWidht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    while (inputWidht <= 0)
                    {
                        Console.Write("Width: ");
                        inputWidht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    Console.Write("Heght: ");
                    double inputHeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    while(inputHeight <= 0)
                    {
                        Console.Write("Heght: ");
                        inputHeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }

                    list.Add(new Rectangle(inputWidht, inputHeight, color));
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Circle area");
                    Console.WriteLine($"Shape #{i}");
                    Console.Write("Radius: ");
                    double inputRadius = double.Parse(Console.ReadLine());
                    while(inputRadius <= 0)
                    {
                        Console.Write("Radius: ");
                        inputRadius = double.Parse(Console.ReadLine());
                    }

                    list.Add(new Circle(inputRadius, color));
                }

            }
            
            foreach(Shape shape in list)
            {
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area().ToString("F2", CultureInfo.InvariantCulture)}" );
            }

            Console.ReadLine();
        }
    }
}
