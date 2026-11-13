using TrainingItDiv2023Api.Interfaces;

namespace TrainingItDiv2023Api.Classes.Outputs
{
    public sealed class OutputGender
    {
        private List<IGender> listPayloads = [];

        public List<IGender> ListPayloads => listPayloads;

        public void Set(List<IGender> listPayloads) => this.listPayloads = listPayloads;
    }
}