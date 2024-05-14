using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Bai1
{
    public class UserData
    {
        public int id;
        public int level;
        public string name;
        public UserData() 
        { 
            id = 0;
            level = 0;
            name = "null";
        }
        public UserData(int id, int level, string name)
        {
            this.id = id;
            this.level = level;
            this.name = name;
        }
        public void XTT()
        {
            Console.WriteLine("ID: ", + id);
            Console.WriteLine("Level: ", + level);
            Console.WriteLine("Name: ", name);
        }
    }
    public class Bai1c
    {
        public static void XTT(String atttributeName, dynamic attribute)
        {
            Console.Write(atttributeName + ": " + attribute);
        }
    }
}
