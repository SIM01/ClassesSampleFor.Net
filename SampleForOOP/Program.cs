using System;

namespace SampleForOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() {Name = "Olga", Age = 22};
            person.Display();
            Friend friend = new Friend() {Name = "Alex", Age = 30};
            friend.Display();
            Colleague colleague = new Colleague() {Name = "Semen", Age = 10};
            colleague.Display();
            Person[] people = new Person[] {person, friend, colleague};
            foreach (var item in people)
            {
                item.Display();
            }
        }
    }
}