using System.ComponentModel.DataAnnotations;

namespace TrainingItDiv2023Api.Classes.Models
{
    public sealed class Subject
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }
    }
}