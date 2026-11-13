using TrainingItDiv2023.Interface;

namespace TrainingItDiv2023.Class
{
    public sealed class User(string name, int age) : IUser
    {
        public string Name => name;

        public int Age => age;
    }
}