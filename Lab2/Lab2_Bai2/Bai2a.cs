using System;

namespace Lab2_Bai2
{
    public class Bai2a
    {
        public class UserInfo
        {
            public string id;
            public string name;
            public bool isplaying;
            public Bag bag;
        }

        public class Bag
        {
            public int skins;
            public int cups;
        }

        public void SomeMethod()
        {
            UserInfo userInfo = new UserInfo
            {
                id = "2024",
                name = "faker",
                isplaying = false,
                bag = new Bag
                {
                    skins = 0,
                    cups = 20
                }
            };

            Console.WriteLine("ID: " + userInfo.id);
            Console.WriteLine("Name: " + userInfo.name);
            Console.WriteLine("Isplaying: " + userInfo.isplaying);
            Console.WriteLine("Bag Skins: " + userInfo.bag.skins);
            Console.WriteLine("Bag cups: " + userInfo.bag.cups);
           
        } 
    }
}
