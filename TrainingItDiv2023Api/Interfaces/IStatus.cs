namespace TrainingItDiv2023Api.Interfaces
{
    public interface IStatus
    {
        public abstract int Code { get; }

        public abstract string Message { get; }

        public abstract void Set(int code, string message);
    }
}