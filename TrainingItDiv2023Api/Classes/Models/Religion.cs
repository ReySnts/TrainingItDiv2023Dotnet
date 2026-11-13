using System.ComponentModel.DataAnnotations;

namespace TrainingItDiv2023Api.Classes.Models
{
    public sealed class Religion
    {
        [Key] public int Id { get; set; }

        public string Description { get; set; }
    }
}