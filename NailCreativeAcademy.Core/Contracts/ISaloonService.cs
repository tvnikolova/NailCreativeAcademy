namespace NailCreativeAcademy.Core.Contracts
{
    using Models.Saloon;

    public interface ISaloonService
    {
        Task<IEnumerable<SaloonViewModel>> AllAsync();
        Task<int> AddAsync(SaloonFormModel newSaloon);
        Task EditAsync(SaloonFormModel model, int saloonId);
        Task<SaloonFormModel> GetSaloonFormByIdAsync(int saloonId);
        Task DeleteAsync(int saloonId);
        Task<SaloonViewModel> GetSaloonToDeleteAsync(int saloonId);
    }
}
