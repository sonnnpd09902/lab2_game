using Lab2_Bai1;
using System;
    public class Program
    {
    public static void Main(string[] args)
    {
        Console.WriteLine("Bai 1a: ");
        Bai1a.start();
        Console.ReadLine();

        Console.WriteLine("Bai 1b: ");
        Bai1b.bai1b();
        Console.ReadLine();

        Console.WriteLine("Bai 1c: ");
        var user = new UserData(1, 1, "1st player");
        Bai1c.XTT("Level", user.level);
        Bai1c.XTT("Name", user.name);
        Console.ReadLine();
    }
    }
