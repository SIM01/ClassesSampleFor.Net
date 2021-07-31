namespace BankKlients
{
    public class Person
    {
        private static int _counter = 0;

        public Person()
        {
            _counter++;
        }

        public string Fio { get; set; }

        public int PassNom { get; set; }

        public static int ReturnCounter()
        {
            return _counter;
        }
    }
}