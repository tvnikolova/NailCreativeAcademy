namespace NailCreativeAcademy.Core.Services
{
    using Microsoft.EntityFrameworkCore;
    using Contracts;
    using Models.Saloon;
    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;
    public class SaloonService : ISaloonService
    {
        private readonly IRepository repository;

        public SaloonService(IRepository _repository)
        {
            this.repository = _repository;
        }
        public async Task<IEnumerable<SaloonViewModel>> AllAsync()
        {
            IEnumerable <SaloonViewModel> saloons = await repository.AllReadOnly<Saloon>()
                                                            .Select(s => new SaloonViewModel() 
                                                            {
                                                                Id = s.Id,
                                                                PhoneNumber = s.PhoneNumber,
                                                                Address = s.Address,
                                                            })
                                                            .ToListAsync();
            return saloons;
        }


		public async Task<int> AddAsync(SaloonFormModel newSaloon)
		{
			Saloon newSaloonToAdd = new Saloon();

            newSaloonToAdd.Address = newSaloon.Address;
			newSaloonToAdd.PhoneNumber= newSaloon.PhoneNumber;
            newSaloonToAdd.ClientId=string.Empty;

            await repository.AddAsync(newSaloonToAdd);
            await repository.SaveChangesAsync();

            return newSaloonToAdd.Id;

		}
		public async Task EditAsync(SaloonFormModel model, int saloonId)
        {
            var foundModel = await repository.All<Saloon>()
                                             .Where(s => s.Id == saloonId)
                                             .FirstAsync();

            if (foundModel != null)
            {
                foundModel.Id = saloonId;
                foundModel.PhoneNumber = model.PhoneNumber;
                foundModel.Address = model.Address;

                await repository.SaveChangesAsync();
            }

        }

        public async Task<SaloonFormModel> GetSaloonFormByIdAsync(int saloonId)
        {
            var foundSaloon = await repository.All<Saloon>()
                                            .Where(s => s.Id == saloonId)
                                            .Select(s => new SaloonFormModel()
                                            {
                                                PhoneNumber = s.PhoneNumber,
                                                Address = s.Address
                                            })
                                            .FirstAsync();

            return foundSaloon;
        }

        public async Task<SaloonViewModel> GetSaloonToDeleteAsync(int saloonId)
        {
            var foundSaloon = await repository.All<Saloon>()
                                               .Where(s => s.Id == saloonId)
                                               .FirstAsync();
            SaloonViewModel saloonToDelete = new SaloonViewModel();

            if (foundSaloon != null)
            {
                saloonToDelete.Id = foundSaloon.Id;
                saloonToDelete.PhoneNumber = foundSaloon.PhoneNumber;
                saloonToDelete.Address = foundSaloon.Address;
            }
            return saloonToDelete;
        }
        public async Task DeleteAsync(int saloonId)
        {
            var saloonToDelete = await GetSaloonToDeleteAsync(saloonId);

            if(saloonToDelete != null)
            {
                await repository.DeleteAsync<Saloon>(saloonId);
                await repository.SaveChangesAsync();    
            }
        }

	}
}
