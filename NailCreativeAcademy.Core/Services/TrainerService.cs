namespace NailCreativeAcademy.Core.Services
{
    using Microsoft.EntityFrameworkCore;
    using Contracts;
    using Models.Trainer;
    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;
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
                Id = trainer.Id,
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
                .AnyAsync(c => c.Name == trainerName);
        }


        public async Task<bool> TrainerExistByIdAsync(int id)
        {
            return await repository.AllReadOnly<Trainer>()
                  .AnyAsync(c => c.Id == id);
        }

        public async Task<int> GetTrainerId(string trainerName)
        {
            int currTrainerId = 0;

            var trainer = await repository.AllReadOnly<Trainer>()
            .Where(t => t.Name == trainerName)
                .Select(t => new TrainerFormModel()
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

    }
}
