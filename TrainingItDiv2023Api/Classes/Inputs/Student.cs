using TrainingItDiv2023Api.Interfaces;

namespace TrainingItDiv2023Api.Classes.Inputs
{
    public sealed class Student(int id, string name, DateTime dateBirth, int idGender, int idReligion, string email, string address) : IStudent
    {
        public int Id => id;

        public string Name => name;

        public DateTime DateBirth => dateBirth;

        public int IdGender => idGender;

        public int IdReligion => idReligion;

        public string Email => email;

        public string Address => address;
    }
}