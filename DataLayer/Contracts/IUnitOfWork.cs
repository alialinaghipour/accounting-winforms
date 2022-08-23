using DataLayer.Models;

namespace DataLayer.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        public IGenericRepository<Contact> ContactGenericRepository { get;}
        public IContactRepository ContactRepository { get; }
        public IGenericRepository<Accounting> AccountingRepository { get;}
        public IGenericRepository<MyProfile> MyProfileRepository { get; }
        void Save();
    }
}
