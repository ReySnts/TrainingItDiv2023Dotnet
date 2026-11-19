using TrainingItDiv2023Api.Classes.Outputs;
using TrainingItDiv2023Api.Interfaces;

namespace TrainingItDiv2023Api.Classes.Helpers
{
    public sealed class HelperGender(DbContextSchool dbSchool)
    {
        private readonly DbContextSchool dbSchool = dbSchool;

        public List<IGender> GetAll()
        {
            var value = new List<IGender>();

            dbSchool.Gender
                .ToList()
                .ForEach(action: gender => value.Add(item: new Gender(id: gender.Id, description: gender.Description)));

            return value;
        }
    }
}