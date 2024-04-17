namespace NailCreativeAcademy.Core.Contracts
{
    using Models.User;
    public interface IUserService
    {
        Task<string> UserFullNameAsync(string userId);

        Task<IEnumerable<UserServiceModel>> AllAsync();
    }
}
