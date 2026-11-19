using TrainingItDiv2023Api.Classes.Outputs;
using TrainingItDiv2023Api.Interfaces;

namespace TrainingItDiv2023Api.Classes.Helpers
{
    public sealed class HelperDeleteStudent(DbContextSchool dbSchool)
    {
        private readonly DbContextSchool dbSchool = dbSchool;

        public IStatus Delete(int id)
        {
            try
            {
                var table = dbSchool.Student;
                var entity = table.FirstOrDefault(predicate: student => student.Id == id);
                var status = new Status();

                if (entity == null) status.Set(code: 404, message: "No student found!");

                else
                {
                    table.Remove(entity);
                    dbSchool.SaveChanges();
                    status.Set(code: 200, message: "Student successfully deleted!");
                }

                return status;
            }

            catch(Exception exception)
            {
                throw new Exception(message: exception.Message);
            }
        }
    }
}