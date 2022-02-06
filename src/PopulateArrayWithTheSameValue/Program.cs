namespace PopulateArrayWithTheSameValue
{
    internal class Program
    {
        public static readonly ArrayPopulator _arrayPopulator = new();
        static void Main(string[] args)
        {
            Console.WriteLine("-----  How to Populate or Instantiate Array with a Same Value");
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine();

            Console.WriteLine("----- Input data manually");
            var simpleArray = _arrayPopulator.InstantiateArrayManually();
            PrintArrayValues(simpleArray);

            Console.WriteLine();

            Console.WriteLine("----- Populate Array with Array.Fill");
            Article[] arrayFill = _arrayPopulator.FillArray(InstantiateInitialArray(), InstantiateNewArticle());
            PrintArrayValues(arrayFill);


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

        public static Article[] InstantiateInitialArray()
        {
            return new Article[10];
        }

        public static Article InstantiateNewArticle()
        {
            return new Article 
            { 
                Title = "How to Copy Array Elements to New Array in C#", 
                LastUpdate = new DateTime(2022, 01, 31) 
            };
        }
    }
}
