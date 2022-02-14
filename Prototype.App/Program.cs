using System;
using Prototype.Lib;

namespace Prototype.App
{
    public static class Program
    {
        private static void Main()
        {
            var user1 = new User("Andrey", 35);
            var user2 = new User(user1);
            Console.WriteLine($"{user1.GetName()}, {user1.GetAge().ToString()}");
            Console.WriteLine($"{user2.GetName()}, {user2.GetAge().ToString()}");

            var user3 = user2.Clone() as User;
            Console.WriteLine($"{user3?.GetName()}, {user3?.GetAge().ToString()}");
            
            var user4 = Cloning(user3) as User;
            Console.WriteLine($"{user4?.GetName()}, {user4?.GetAge().ToString()}");
        }

        static object Cloning(ICloneable cloneable)
        {
            //add logging
            return cloneable.Clone();
        }
    }
}