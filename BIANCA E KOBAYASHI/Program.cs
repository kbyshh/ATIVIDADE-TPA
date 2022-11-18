using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_TPA
{
    class Program
    {
        static void Main(string[] args)
        {
            string time1, time2, time3, time4, time5;
            int pontos1, pontos2, pontos3, pontos4, pontos5;
            Console.WriteLine("digite o nome do time1:");
            time1 = Console.ReadLine();
            Console.WriteLine("digite os pontos do time1 {0}", time1);
            pontos1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o nome do time2:");
            time2 = Console.ReadLine();
            Console.WriteLine("digite os pontos do time2 {0}", time2);
            pontos2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o nome do time3:");
            time3 = Console.ReadLine();
            Console.WriteLine("digite os pontos do time3 {0}", time3);
            pontos3 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o nome do time4:");
            time4 = Console.ReadLine();
            Console.WriteLine("digite os pontos do time4 {0}", time4);
            pontos4 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o nome do time5:");
            time5 = Console.ReadLine();
            Console.WriteLine("digite os pontos do time5 {0}", time5);
            pontos5 = int.Parse(Console.ReadLine());
        }
    }

}
