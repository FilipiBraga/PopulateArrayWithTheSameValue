namespace PopulateArrayWithTheSameValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  How to Populate or Instantiate Array with a Same Value");
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine();

            Console.WriteLine("----- Input data manually");
            var simpleArray = InstantiateArrayManually();
            PrintArrayValues(simpleArray);



            Console.WriteLine();
        }

        private static void PrintArrayValues(Article[] array)
        {
            if (array is null)
                return;

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static Article[] InstantiateArrayManually()
        {
            return new Article[]
            {
                new Article { Title = "How to Copy Array Elements to New Array in C#", LastUpdate = new DateTime(2022,01,31)},
                new Article { Title = "Named Arguments and Optional Parameters in C#", LastUpdate = new DateTime(2022,02,04)}
            };
        }
    }
}
