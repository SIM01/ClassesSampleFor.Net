namespace SampleForEquals
{
    public class Figure
    {
        public int SideCount { get; set; }
        public int SideLenght { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Figure))
            {
                return false;
            }

            Figure result = (Figure) obj;
            return result.SideCount == SideCount && result.SideLenght == SideLenght;
        }

        public static bool operator ==(Figure first, Figure second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Figure first, Figure second)
        {
            return first.Equals(second);
        }
    }
}