using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinero_Ganado
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pmonto_cordobas;
            float Rinteres_anual;
            string N_Años;
             double Dinero_Ganado;

            Console.WriteLine("ESCRIBA EL MONTO DE CORDOBAS INVERTIDO");
            Pmonto_cordobas = Console.ReadLine();
            float cordobas = float.Parse(Pmonto_cordobas);

            Console.WriteLine("ESCRIBA TASA DE INTERES ANUAL");
            Rinteres_anual = float.Parse(Console.ReadLine());
            Console.WriteLine("ESCRIBA EL NUMERO DE AÑOS");
            N_Años = Console.ReadLine();
            int anios = int.Parse(N_Años);

            double divisor = 1 + (Rinteres_anual / 100);

            Dinero_Ganado = cordobas *  Math.Pow(divisor,anios);

            Console.WriteLine("EL DINERO GANADO ES DE: " + Dinero_Ganado + " CORDOBAS ");
            Console.Read();


        }
    }
}
