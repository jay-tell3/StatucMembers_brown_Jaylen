namespace StatucMembers_brown_Jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //answers of ints
            Console.WriteLine(Calculate.Add(15, 88));
            Console.WriteLine(Calculate.Sub(15, 88));
            Console.WriteLine(Calculate.Mult(15, 88));
            Console.WriteLine(Calculate.Div(88, 15));
            //answers of floats
            Console.WriteLine(Calculate.Add(15.23f, 88.23f));
            Console.WriteLine(Calculate.Sub(15.67f, 88.89f));
            Console.WriteLine(Calculate.Mult(15.76f, 88.39f));
            Console.WriteLine(Calculate.Div(88.68f, 15.12f));


        }
    }
}
