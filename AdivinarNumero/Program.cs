using System;


namespace AdivinarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var rando = new Random();
            int num = rando.Next(101);
            Console.WriteLine("Ingrese un numero, adivine el numero generado entre 0 y 100");
            int adiv = Convert.ToInt32(Console.ReadLine());
            try
            {
                while (adiv != num)
                {
                    if (adiv < num)
                    {
                        Console.WriteLine($"El numero ingresado:[{adiv}] es menor al generado. Ingrese otro numero");
                        adiv = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (adiv > num)
                    {
                        Console.WriteLine($"El numero ingresado:[{adiv}] es mayor al generado. Ingrese otro numero");
                        adiv = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine($"Correcto! El numero generado era [{num}]");
                    }

                }
            }catch (FormatException)
            {
                Console.WriteLine($"valor ingresado no es un numero");
            }
        }
    }
}
