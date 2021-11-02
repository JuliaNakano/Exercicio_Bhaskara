using System;

namespace Exercicio_Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
        

        
             double a, b, c, delta; 
             double b1, bhaskara, raiz, bhaskara2, mult;
             

            Console.WriteLine("\nEsse programa consiste em realizar a conta de uma equação de segundo grau, através do uso da fórmula de bhaskara.");
            Console.WriteLine("Para iniciá-lo basta digitar o valor de: .......");

            Console.Write("\nDigite o valor de a:... ");
            a = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o valor de b:... ");
            b = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o valor de c:... ");
            c = Convert.ToDouble(Console.ReadLine());

            b1 = Math.Pow(b,2);
            delta = b1 -4*a*c;

            raiz = Math.Sqrt(delta);
            mult= 2*a;
            
            bhaskara = (-b - raiz) / mult;
            bhaskara2 = (-b + raiz) / mult;  
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if(a == 0 )
            {
                Console.WriteLine("Se (a) for igual à 0 a equação deixa de ser de segundo grau");
                Console.ResetColor();
                return;
            }
          
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if(delta < 0 )
            {
                Console.WriteLine($"Como delta = {delta}, a equação não possui raízes reais!");
                Console.ResetColor();
                return;
            }
           
            Console.ResetColor();
            Console.WriteLine($"o valor de delta é:...{delta}");
            
            Console.WriteLine("\nAs respostas admitidas pela equação correspondem à :");
            Console.WriteLine($"x1:..... {bhaskara:N1}");
            Console.WriteLine($"x2:..... {bhaskara2:N1}");

          
        } 
    }
}
