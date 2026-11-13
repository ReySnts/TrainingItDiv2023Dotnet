using System.ComponentModel.DataAnnotations;

namespace TrainingItDiv2023Api.Classes.Models
{
    public sealed class Student
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateBirth { get; set; }

        public int IdGender { get; set; }

        public int IdReligion { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}