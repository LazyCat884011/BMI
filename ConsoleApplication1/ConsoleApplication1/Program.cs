using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入身高:");
            double high = double.Parse(Console.ReadLine());
            Console.Write("請輸入體重:");
            double weight = double.Parse(Console.ReadLine());
            double BMI = weight / ((high * 0.01)* (high * 0.01));
            Console.Write("您的BMI值是:" + BMI);
            Console.ReadLine();


        }
    }
}
