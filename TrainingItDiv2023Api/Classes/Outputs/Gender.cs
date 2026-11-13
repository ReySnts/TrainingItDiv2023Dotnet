using TrainingItDiv2023Api.Interfaces;

namespace TrainingItDiv2023Api.Classes.Outputs
{
    public sealed class Gender(int id, string description) : IGender
    {
        private int id = id;

        private string description = description;

        public int Id => id;

        public string Description => description;

        public void Set(int id) => this.id = id;

        public void Set(string description) => this.description = description;
    }
}