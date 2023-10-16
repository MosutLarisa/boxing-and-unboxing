namespace boxing_and_unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boxing
            int i = 3;
            object obj1 = i;


            Console.WriteLine(i);
            Console.WriteLine(obj1);


            //unboxing
            object obj2 = 4;
            int j = (int)obj2;
            Console.WriteLine(obj2);
            Console.WriteLine(j);
        }
        
    }

    public class Person
    {
        public string Name;
    }
}