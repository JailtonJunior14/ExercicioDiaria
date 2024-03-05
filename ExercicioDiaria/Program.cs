using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDiaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor da diario: ");
             double diaria = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero adultos: ");
             double adulto = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero de crianças: ");
             double crian = double.Parse(Console.ReadLine());
            double valor_dia = (diaria * adulto + ((crian * diaria) / 2));
            Console.WriteLine("Dias de hospedagem: ");
             double diaH = double.Parse(Console.ReadLine());
            double Valor_Hospedagem = diaH * valor_dia;
            Console.WriteLine("Numero de parcelas: ");
             double parcela = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor parcela: " + (Valor_Hospedagem / parcela).ToString("C"));
            
            Console.ReadKey();

        }
    }
}
