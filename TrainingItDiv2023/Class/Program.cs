namespace TrainingItDiv2023.Class
{
    public sealed class Program
    {
        public static void Main()
        {
            var listUsers = GetterDataUsers.GetData();

            listUsers.ForEach(action: item => Console.WriteLine($"Name: {item.Name}, Age: {item.Age}"));
        }
    }
}