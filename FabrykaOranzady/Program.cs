using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaOranzady
{
    enum TASTE { ORANGE, MANDARINE, LEMON};

    class Program
    {
        static void Main(string[] args)
        {
            int taste = -1;
            Console.WriteLine("Wybierz Smak Oranzady:\n0 - Orange\n1 - Mandarine\n2 - Lemon");
            try
            {
                taste = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Podales zla liczbe");
                throw;
            }
            for (int i = 0; i < 5; i++)
            {
                SodaMachine.Instance.createBottleAndFillWithSoda((TASTE)taste);            
            }
            Console.ReadKey();
        }
    }
}
