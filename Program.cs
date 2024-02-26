namespace AssignmentLINQSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square Root");
            List<int> numberList = new List<int> { 2,3,4,5,6,7,8,66,54};

            IEnumerable<int> query = from n in numberList
                                     where n > 1
                                     select n;

            IEnumerable<int> query2 = numberList.Where(i => i > 1);

            foreach (int n in query)
            {
                Console.WriteLine($"Square Root of {n} = {n*n}");
            }
            Console.WriteLine();

            foreach (int i in query2)
            {
                Console.WriteLine($"Square Root of {i} = {i * i}");
            }

        }
    }
}