using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarNumerosPrimos
{
    class Program
    {

        //resuelvo si un numero es primo
        public static bool EsPrimo(int num)
        {
            int divisibilidad;
            bool retorno;

            divisibilidad = 0;
            for (int divisor = 1; divisor <= num; divisor++)
            {
                if (num % divisor == 0)
                {
                    divisibilidad++;
                }
            }

            //esto es mejorable, cómo?
            if (divisibilidad <= 2)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
            //fin dela posible mejora?
        }

        static void Main(string[] args)
        {
            int desdeNum, hastaNum;
            bool resultado;

            Console.WriteLine("Ingrese el intervalo");
            desdeNum = Convert.ToInt32(Console.ReadLine());
            hastaNum = Convert.ToInt32(Console.ReadLine());

            for (int num = desdeNum; num <= hastaNum; num++)
            {
                resultado = EsPrimo(num);

                if (resultado)
                {
                    Console.WriteLine(num);
                }
            }

            Console.ReadKey();
        }
    }

}
