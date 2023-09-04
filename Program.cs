namespace _434._Number_of_Segments_in_a_String
{
    internal class Program
    {
        public static int CountSegments(string s)
        {
            return s.Split(' ').Where(w => w.Length != 0).Count();
        }
        static void Main(string[] args)
        {
            
        }
    }
}