using DataLayer.ViewModels;

namespace DataLayer.Contracts
{
    public interface IContactRepository
    {
        IList<GetAllContactViewModel> GetAll(string? search);
        IList<GetAllNameContactViewModel> GetAllNames(string? search = null);
        GetNameContactViewModel? GetNameById(int id);
        bool IsExistMobile(string mobile, int id);
        bool IsExistMobile(string mobile);
    }
}
