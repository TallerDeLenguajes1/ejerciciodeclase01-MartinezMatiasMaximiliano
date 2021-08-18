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

            while(adiv != num)
            {
                Console.WriteLine($"El numero ingresado:[{adiv}] no es el correcto. Ingrese otro numero");
                adiv = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine($"Correcto! El numero generado era [{num}]");


          
        }
    }
}
