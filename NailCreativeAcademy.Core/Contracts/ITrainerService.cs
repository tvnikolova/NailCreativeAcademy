namespace NailCreativeAcademy.Core.Contracts
{
    using Models.Trainer;

    public interface ITrainerService
    {
        Task<int> CreateAsync(TrainerFormModel trainer);
        Task<bool> TrainerExistByNameAsync(string trainerName);
        Task<bool> TrainerExistByIdAsync(int id);
        Task<int> GetTrainerId(string trainerName);
        Task <TrainerFormModel> GetTrainerFormByIdAsync(int trainerId);
        Task<IEnumerable<TrainerViewModel>> AllAsync();
        Task EditAsync(TrainerFormModel model, int trainerId);
        Task<TrainerViewModel> GetTrainerToDeleteAsync(int trainerId);
        Task DeleteAsync(int trainerId);
    }
}