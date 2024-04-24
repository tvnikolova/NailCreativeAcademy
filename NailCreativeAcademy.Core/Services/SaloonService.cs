namespace NailCreativeAcademy.Core.Services
{
    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;    
    using Models.Saloon;

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
                                                                Name = s.Name,
                                                                PhoneNumber = s.PhoneNumber,
                                                                Address = s.Address,
                                                            })
                                                            .ToListAsync();
            return saloons;
        }
		public async Task<int> AddAsync(SaloonFormModel newSaloon)
		{
			Saloon newSaloonToAdd = new Saloon();

            newSaloonToAdd.Name = newSaloon.Name;
            newSaloonToAdd.Address = newSaloon.Address;
			newSaloonToAdd.PhoneNumber= newSaloon.PhoneNumber;
            newSaloonToAdd.ClientId= newSaloon.ClientId;

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
                foundModel.Name = model.Name;
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
                                                Name = s.Name,
                                                PhoneNumber = s.PhoneNumber,
                                                Address = s.Address
                                            })
                                            .FirstAsync();

            return foundSaloon;
        }

        public async Task<SaloonViewModel> GetSaloonViewModelAsync(int saloonId)
        {
            var foundSaloon = await repository.All<Saloon>()
                                               .Where(s => s.Id == saloonId)
                                               .Select(s=>new SaloonViewModel()
                                               {
                                                   Id = s.Id,
                                                   Name = s.Name,
                                                   PhoneNumber = s.PhoneNumber,
                                                   Address = s.Address
                                               })
                                               .FirstAsync();
          
            return foundSaloon;
        }
        public async Task DeleteAsync(int saloonId)
        {
            var saloonToDelete = await GetSaloonViewModelAsync(saloonId);

            if(saloonToDelete != null)
            {
                await repository.DeleteAsync<Saloon>(saloonId);
                await repository.SaveChangesAsync();    
            }
        }

        public async Task<SaloonViewModel> DetailsAsync(int id)
        {
           
                var saloons = await repository.AllReadOnly<Saloon>()
                                                .Where(c => c.Id == id)
                                                .Select(c => new SaloonViewModel()
                                                {
                                                    Id = c.Id,
                                                    Name = c.Name,
                                                    PhoneNumber = c.PhoneNumber,
                                                    Address = c.Address
                                                    

                                                })
                                                .FirstAsync();

                return saloons;
            
        }
    }
}
