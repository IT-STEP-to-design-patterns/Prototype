using System;
using Prototype.Lib;

namespace Prototype.App
{
    class Program
    {
        static void Main()
        {
            var user1 = new User("Andrey", 35);
            var user2 = new User(user1);
            Console.WriteLine($"{user1.GetName()}, {user1.GetAge()}");
            Console.WriteLine($"{user2.GetName()}, {user2.GetAge()}");

            var user3 = user2.Clone() as User;
            Console.WriteLine($"{user3?.GetName()}, {user3?.GetAge()}");
            
            var user4 = Cloning(user3) as User;
            Console.WriteLine($"{user4?.GetName()}, {user4?.GetAge()}");
        }

        static object Cloning(ICloneable cloneable)
        {
            //add logging
            return cloneable.Clone();
        }
    }
}