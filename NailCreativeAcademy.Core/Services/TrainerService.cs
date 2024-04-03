using Microsoft.EntityFrameworkCore;
using NailCreativeAcademy.Core.Contracts;
using NailCreativeAcademy.Core.Models.Course;
using NailCreativeAcademy.Core.Models.Trainer;
using NailCreativeAcademy.Infrastructure.Data.Common;
using NailCreativeAcademy.Infrastructure.Data.Models;
namespace NailCreativeAcademy.Core.Services
{
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

        public async Task<bool> TrainerExistAsync(string trainerName)
        {
            return await repository.AllReadOnly<Trainer>()
                .AnyAsync(c => c.Name == trainerName);
        }

        public async  Task<int> GetTrainerId(string trainerName)
        {
            int currTrainerId=0;

            var trainer = await repository.AllReadOnly<Trainer>()
            .Where(t => t.Name == trainerName)
                .Select(t => new TrainerFormModel()
                {
                    Id=t.Id,
                    Name=t.Name,
                    About = t.About
                })
                .FirstOrDefaultAsync();
            if(trainer != null)
            {
                currTrainerId = trainer.Id;
            }

           return  currTrainerId;
        }

       
    }
}
