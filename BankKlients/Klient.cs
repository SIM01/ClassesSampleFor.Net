namespace BankKlients
{
    public class Klient : Person
    {
        public decimal Sum { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Klient))
            {
                return false;
            }

            Klient result = (Klient) obj;
            return result.Fio == Fio && result.PassNom == PassNom;
        }
    }
}