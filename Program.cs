using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double vlMassa, vlAltura, IMC; 
            string massa, altura;
            bool Rmassa, Raltura;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n --- Calculadora de IMC ---\n");
            Console.ResetColor();

            Console.WriteLine("Para que o programa possa calcular o\nseu IMC, é necessário inserir as");
            Console.WriteLine("suas medidas de massa em kg, e de\naltura em metros\n");

            Console.Write("Altura:...: ");
            altura = Console.ReadLine();

            Raltura = Double.TryParse(altura, out vlAltura);

            Console.Write("Massa.....: ");
            massa = Console.ReadLine();

            Rmassa = Double.TryParse(massa, out vlMassa);

            IMC = vlMassa / (vlAltura * vlAltura);

            if (Raltura && Rmassa && vlAltura > 0 && vlMassa > 0)
            {   
                if (IMC > 0 && IMC < 17)
                {
                    Console.WriteLine($"\nSeu IMC é {IMC:N2} kg/m².");
                    Console.WriteLine("Diagnóstico: Muito abaixo do peso\n");
                }
                if (IMC >= 17 && IMC <= 18.49)
                {
                    Console.WriteLine($"\nSeu IMC é {IMC:N2} kg/m².");
                    Console.WriteLine("Diagnóstico: Abaixo do peso\n");
                }
                if (IMC >= 18.5 && IMC <= 24.99)
                {
                    Console.WriteLine($"\nSeu IMC é {IMC:N2} kg/m².");
                    Console.WriteLine("Diagnóstico: Peso normal\n");
                }
                if (IMC >= 25 && IMC <= 29.99)
                {
                    Console.WriteLine($"\nSeu IMC é {IMC:N2} kg/m².");
                    Console.WriteLine("Diagnóstico: Acima do peso\n");
                }
                if (IMC >= 30 && IMC <= 34.99)
                {
                    Console.WriteLine($"\nSeu IMC é {IMC:N2} kg/m².");
                    Console.WriteLine("Diagnóstico: Obesidade I\n");
                }
                if (IMC >= 35 && IMC <= 39.99)
                {
                    Console.WriteLine($"\nSeu IMC é {IMC:N2} kg/m².");
                    Console.WriteLine("Diagnóstico: Obesidade II (severa)\n");
                }
                if (IMC >= 40)
                {
                    Console.WriteLine($"\nSeu IMC é {IMC:N2} kg/m².");
                    Console.WriteLine("Diagnóstico: Obesidade III (mórbida)\n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInsira valores válidos e tente novamente!\n");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Obrigado por usar o programa!\n");
            Console.ResetColor();
        }
    }
}
