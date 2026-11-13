using System.ComponentModel.DataAnnotations;

namespace TrainingItDiv2023Api.Classes.Models
{
    public sealed class Grade
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }

        public decimal ScoreMin { get; set; }

        public decimal ScoreMax { get; set; }
    }
}