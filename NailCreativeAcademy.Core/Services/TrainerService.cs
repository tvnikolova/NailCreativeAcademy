namespace NailCreativeAcademy.Core.Services
{
    using Contracts;
    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Models.Trainer;

    public class TrainerService : ITrainerService
    {
        private readonly IRepository repository;
        public TrainerService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<int> CreateAsync(TrainerFormModel trainer)
        {
            Trainer newTrainer = new Trainer()
            {
                Name = trainer.Name,
                About = trainer.About,
            };
            await repository.AddAsync(newTrainer);
            await repository.SaveChangesAsync();

            return newTrainer.Id;
        }

        public async Task<bool> TrainerExistByNameAsync(string trainerName)
        {
            return await repository.AllReadOnly<Trainer>()
                .AnyAsync(t => t.Name == trainerName);
        }

        public async Task<IEnumerable<TrainerViewModel>> AllAsync()
        {
            var trainers = await repository.AllReadOnly<Trainer>()
                                            .Select(t => new TrainerViewModel()
                                            {
                                                Id = t.Id,
                                                Name = t.Name,
                                                About = t.About

                                            })
                                            .ToListAsync();

            return trainers;
        }
        public async Task<bool> TrainerExistByIdAsync(int id)
        {
            return await repository.AllReadOnly<Trainer>()
                  .AnyAsync(t => t.Id == id);
        }

        public async Task<int> GetTrainerId(string trainerName)
        {
            int currTrainerId = 0;

            var trainer = await repository.AllReadOnly<Trainer>()
            .Where(t => t.Name == trainerName)
                .Select(t => new TrainerViewModel()
                {
                    Id = t.Id,
                    Name = t.Name,
                    About = t.About
                })
                .FirstOrDefaultAsync();
            if (trainer != null)
            {
                currTrainerId = trainer.Id;
            }

            return currTrainerId;
        }

        public async Task EditAsync(TrainerFormModel model, int trainerId)
        {
            var trainerToEdit = await repository.All<Trainer>()
                                                .Where(t => t.Id == trainerId)
                                                .FirstOrDefaultAsync();
          
            if (trainerToEdit != null)
            {
                trainerToEdit.Name = model.Name;
                trainerToEdit.About = model.About;

                await repository.SaveChangesAsync();
            }

        }

        public async Task<TrainerFormModel> GetTrainerFormByIdAsync(int trainerId)
        {
            var trainer = await repository.AllReadOnly<Trainer>()
                                                 .Where(t => t.Id == trainerId)
                                                 .Select (t => new TrainerFormModel()
                                                 {
                                                     Name = t.Name,
                                                     About = t.About
                                                 })
                                                 .FirstAsync();
                                                 

            return trainer;
        }
        public async Task<TrainerViewModel> GetTrainerToDeleteAsync(int trainerId)
        {
            var foundedTrainer = await repository.AllReadOnly<Trainer>()
                                               .Where(c => c.Id == trainerId)
                                               .FirstOrDefaultAsync();

            TrainerViewModel trainerToDelete = new TrainerViewModel();

            if (foundedTrainer != null)
            {

                trainerToDelete.Id = foundedTrainer.Id;
                trainerToDelete.Name = foundedTrainer.Name;
                trainerToDelete.About = foundedTrainer.About;
            }

            return trainerToDelete;
        }
        public async Task DeleteAsync(int trainerId)
        {
            await repository.DeleteAsync<Trainer>(trainerId);
            await repository.SaveChangesAsync();
        }
    }
}
