using TrainingItDiv2023Api.Interfaces;

namespace TrainingItDiv2023Api.Classes.Setters
{
    public sealed class SetterStatus
    {
        public void Set(object? obj, IStatus status, int code, string message)
        {
            if (obj != null) return;

            status.Set(code, message);
        }
    }
}