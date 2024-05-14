using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Bai1
{
    public class Bai1b
    {
        public static void GetDetail(dynamic value)
        {
            Console.WriteLine("value: " + value);
        }
        public static void bai1b()
        {
            GetDetail(10);
            GetDetail("Game");
            GetDetail(true);
            GetDetail(9.5);
        }
    }
}
