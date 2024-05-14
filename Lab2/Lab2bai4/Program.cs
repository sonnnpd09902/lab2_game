using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2bai4
{
    internal class Program
    {
        static void Main()
        {
            List<int> numberList = new List<int>();

                numberList.Add(10);
                numberList.Add(20);
                numberList.Add(7);
                numberList.Add(40);
                numberList.Add(23);
            //y1 hien thi danh sach cac so nguyen
            Console.WriteLine("Danh sach cac so nguyen:");
            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
            //y2 tính tổng các số nguyên trong danh sách
            int sum = 0;
            foreach (int number in numberList)
            {
                sum += number;
            }
            Console.WriteLine("Tong cac so nguyen trong danh sach la: " + sum);
            Console.ReadLine();
            //y3 tong cac so nguyen to
            int result = 0;
                foreach(int number in numberList)
                {
                    if (check(number))
                    {
                        result += number;
                    }
                }
               Console.WriteLine("Tong cac so nguyen to la: "+result);
            Console.ReadLine();

            //4
            int tong = 0;
            for (int i = 1; i < numberList.Count; i += 2) // bat dau tu 1, va tang len 2
            {
                if (numberList[i] % 2 == 0) // kiem tra
                {
                    tong += numberList[i];
                }
            }
            Console.WriteLine("Tong cac so chan o vi tri le trong danh sach la: " + tong);
            Console.ReadLine();
        }
        
            

        public static Boolean check(int num)
        {
            if(num < 1)
                return false;
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
            Console.ReadLine();
        }
    }   
}
