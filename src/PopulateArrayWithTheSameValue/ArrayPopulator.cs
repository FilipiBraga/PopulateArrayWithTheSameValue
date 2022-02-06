namespace PopulateArrayWithTheSameValue
{
    public class ArrayPopulator
    {
        public Article[] InstantiateArrayManually()
        {
            return new Article[]
            {
                new Article { Title = "How to Copy Array Elements to New Array in C#", LastUpdate = new DateTime(2022,01,31)},
                new Article { Title = "Named Arguments and Optional Parameters in C#", LastUpdate = new DateTime(2022,02,04)}
            };
        }

        public Article[] FillArray(Article[] array, Article value)
        {
            Array.Fill(array, value);

            return array;
        }
    }
}
