using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluasiNilai
{
    class Program
    {
        static void Main(string[] args)
        {
            int nilai;
            Console.Write("Masukan nilai anda   : ");
            nilai = int.Parse(Console.ReadLine());

            if(nilai >= 80)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Nilai anda A");
            }
            else if(nilai >= 65)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Nilai anda B");
            }
            else if(nilai >= 45)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Nilai anda C");
            }
            else if(nilai >= 30)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Nilai anda D");
            }
            else
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Nilai anda E");
            }
            Console.ReadLine();
        }
    }
}
