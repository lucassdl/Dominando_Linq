using System;
using System.Linq;

namespace Introducao
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = { 1, 7, 8, 9, 10, 2, 3, 4, 5, 6 };

            //var resultado = from num in numeros
            //                where num > 5
            //                orderby num
            //                select num;

            //var resultado2 = numeros.Where(n => n > 2).OrderBy(n => n);

            //foreach (int numero in resultado2)
            //{
            //    Console.WriteLine(numero);
            //}
            //Console.ReadKey();

            string[] cores = { "Preto", "Branco", "Verde", "Amarelo", "Azul", "Vermelho" };

            var resultados = cores.Where(n => n.Contains("e") || n.Contains("z"));

            foreach (var cor in resultados)
            {
                Console.WriteLine(cor);
            }

            Console.ReadKey();
        }
    }
}
