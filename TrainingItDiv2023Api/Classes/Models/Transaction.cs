using System.ComponentModel.DataAnnotations;

namespace TrainingItDiv2023Api.Classes.Models
{
    public sealed class Transaction
    {
        [Key] public int Id { get; set; }

        public int IdStudent { get; set; }

        public int IdSubject { get; set; }

        public int Semester { get; set; }

        public decimal Score { get; set; }

        public string Grade { get; set; }
    }
}