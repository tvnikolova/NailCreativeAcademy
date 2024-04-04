namespace NailCreativeAcademy.Core.Contracts
{
    using Models.Trainer;

    public interface ITrainerService
    {
        Task<int> CreateAsync(TrainerFormModel trainer);
        Task<bool> TrainerExistAsync(string trainerName);
        Task<int> GetTrainerId(string trainerName);

    }
}