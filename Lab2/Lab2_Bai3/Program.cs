using System;
using System.Collections.Generic;

public  class UserData
{
    public int? id;
    public string name;
    public List<float> scores;
    public UserData()
    {
        id = null;
        name = null; 
        scores = new List<float>();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        // nhap ten
        UserData userData = new UserData();
        Console.WriteLine("Nhap ten: ");
        userData.name = Console.ReadLine();
        Console.WriteLine("Userdata.name : " + userData.name);
        // nhap id
        Console.WriteLine("Nhap id: ");
        String id = Console.ReadLine();
        userData.id = Convert.ToInt32(id);
        Console.WriteLine("userdata.id : " + userData.id);
        // nhap diem
        Console.WriteLine("Nhap danh sach diem. Nhap so luong diem can nhap: ");
        int soLuongDiem = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < soLuongDiem; i++)
        {
            Console.WriteLine("Nhap diem: ");
            userData.scores.Add(Convert.ToInt32(Console.ReadLine()));
        }
        Console.Write("Danh sach diem vua nhap la: ");
        //in ra cac phan tu trong list
        foreach(var i in userData.scores)
        {
            Console.Write(" " + i);
        }
        Console.ReadLine();
    }
}