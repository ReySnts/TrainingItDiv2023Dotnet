using TrainingItDiv2023Api.Classes.Models;
using TrainingItDiv2023Api.Classes.Outputs;
using TrainingItDiv2023Api.Classes.Setters;
using TrainingItDiv2023Api.Interfaces;

namespace TrainingItDiv2023Api.Classes.Helpers
{
    public sealed class HelperCreateStudent(DbContextSchool dbSchool)
    {
        private readonly Action<object?, IStatus, int, string> SetStatus = new SetterStatus().Set;

        private readonly DbContextSchool dbSchool = dbSchool;

        public IStatus Create(IStudent input, int codeEmpty = 204, int codeNotFound = 404)
        {
            var arg2 = new Status();

            SetStatus(arg1: input, arg2, arg3: codeEmpty, arg4: "Input cannot be empty!");

            if (input != null)
            {
                var gender = dbSchool.Gender.FirstOrDefault(predicate: item => item.Id == input.IdGender);
                var religion = dbSchool.Religion.FirstOrDefault(predicate: item => item.Id == input.IdReligion);

                SetStatus(arg1: gender, arg2, arg3: codeNotFound, arg4: "Gender not found!");
                SetStatus(arg1: religion, arg2, arg3: codeNotFound, arg4: "Religion not found!");
                SetStatus(arg1: input.Name, arg2, arg3: codeEmpty, arg4: "Name cannot be empty!");
                SetStatus(arg1: input.Email, arg2, arg3: codeEmpty, arg4: "Email cannot be empty!");
                SetStatus(arg1: input.Address, arg2, arg3: codeEmpty, arg4: "Address cannot be empty!");

                if (input.DateBirth == DateTime.MinValue) arg2.Set(code: codeEmpty, message: "Date of Birth cannot be empty!");

                var entity = new Student() { Name = input.Name, DateBirth = input.DateBirth, IdGender = input.IdGender, IdReligion = input.IdReligion, Email = input.Email, Address = input.Address };

                dbSchool.Student.Add(entity);
                dbSchool.SaveChanges();
            }

            return arg2;
        }
    }
}