namespace TrainingItDiv2023Api.Interfaces
{
    public interface IStudent
    {
        public int Id { get; }

        public string Name { get; }

        public DateTime DateBirth { get; }

        public int IdGender { get; }

        public int IdReligion { get; }

        public string Email { get; }

        public string Address { get; }
    }
}