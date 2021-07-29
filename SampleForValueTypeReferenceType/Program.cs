using System;

namespace SampleForValueTypeReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "test";
            string string2 = string1;
            string2 = "aaaaaa";
            
            Person sergey = new Person() {Name = "Sergey", Age = 30};
            Account account1 = new Account() {AccountId = 1, person = sergey};
            Account account2 = account1;

            account2.AccountId = 2;
            account2.person.Name = "Olga";

            Person andrey = new Person() {Name = "Andrey", Age = 10};
            Person anatolii = RenamePerson(andrey);
        }

        public static Person RenamePerson(Person person)
        {
            //person.Name = "Anatolii";
            person = new Person() {Name = "Anatolii"};
            return person;
        }
    }
}