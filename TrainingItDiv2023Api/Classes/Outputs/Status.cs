using TrainingItDiv2023Api.Interfaces;

namespace TrainingItDiv2023Api.Classes.Outputs
{
    public sealed class Status(int code = 0, string message = "") : IStatus
    {
        private int code = code;

        private string message = message;

        public int Code => code;

        public string Message => message;

        public void Set(int code, string message)
        {
            this.code = code;
            this.message = message;
        }
    }
}