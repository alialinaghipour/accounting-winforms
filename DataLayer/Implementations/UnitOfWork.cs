using DataLayer.Contracts;
using DataLayer.Models;

namespace DataLayer.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IGenericRepository<Contact> _contactGenericRepository;
        private readonly IContactRepository _contactRepository;
        private readonly IGenericRepository<Accounting> _accountingRepository;
        private readonly IGenericRepository<MyProfile> _myProfileRepository;

        public UnitOfWork(
            ApplicationDbContext context,
            IGenericRepository<Contact> contactGenericRepository,
            IGenericRepository<Accounting> accountingRepository,
            IGenericRepository<MyProfile> myProfileRepository,
            IContactRepository contactRepository)
        {
            _context = context;
            _contactGenericRepository = contactGenericRepository;
            _accountingRepository = accountingRepository;
            _myProfileRepository = myProfileRepository;
            _contactRepository = contactRepository;
        }

        public IGenericRepository<Contact> ContactGenericRepository
            => _contactGenericRepository;

        public IGenericRepository<Accounting> AccountingRepository
            => _accountingRepository;

        public IGenericRepository<MyProfile> MyProfileRepository
            => _myProfileRepository;

        public IContactRepository ContactRepository 
            => _contactRepository;

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
