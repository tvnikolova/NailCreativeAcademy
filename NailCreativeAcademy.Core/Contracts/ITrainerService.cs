namespace NailCreativeAcademy.Core.Contracts
{
    using Models.Trainer;
    using NailCreativeAcademy.Infrastructure.Data.Common;
    using NailCreativeAcademy.Infrastructure.Data.Models;

    public interface ITrainerService
    {
        Task<int> CreateAsync(TrainerFormModel trainer);
        Task<bool> TrainerExistAsync(string trainerName);
        Task<int> GetTrainerId(string trainerName);

    }
}
