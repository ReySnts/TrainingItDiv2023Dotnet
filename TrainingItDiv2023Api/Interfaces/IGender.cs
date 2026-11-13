namespace TrainingItDiv2023Api.Interfaces
{
    public interface IGender
    {
        public abstract int Id { get; }

        public string Description { get; }

        public void Set(int id);

        public void Set(string description);
    }
}