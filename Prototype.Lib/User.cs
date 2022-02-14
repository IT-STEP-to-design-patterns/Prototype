using System;

namespace Prototype.Lib
{
    public class User : ICloneable
    {
        private readonly string _name;
        private readonly int _age;

        public User(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public User(User user)
        {
            _name = user.GetName();
            _age = user.GetAge();
        }

        public string GetName() => _name;
        public int GetAge() => _age;
        
        public object Clone()
        {
            return new User(this);
        }
    }
}