using DataLayer.Contracts;
using DataLayer.ViewModels;

namespace DataLayer.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<GetAllContactViewModel> GetAll(string? search)
        {
            var result = QueryGetAll();

            if (search != null)
            {
                result = FilterGetAll(search, result);
            }

            return result.ToList();
        }

        public IList<GetAllNameContactViewModel> GetAllNames(string? search)
        {
            var result = _context.Contacts
                .Select(_ => new GetAllNameContactViewModel
                {
                    Id = _.Id,
                    FullName = _.FullName
                });

            if(search != null)
                result = result.Where(_ => _.FullName.Contains(search));

            return result.ToList();
        }
        public GetNameContactViewModel? GetNameById(int id)
        {
            return _context.Contacts
                .Where(_ => _.Id == id)
                .Select(_ => new GetNameContactViewModel
                {
                    FullName = _.FullName,
                })
                .SingleOrDefault();
        }

        private IQueryable<GetAllContactViewModel> QueryGetAll()
        {
            return _context.Contacts
                .Select(_ => new GetAllContactViewModel
                {
                    Id = _.Id,
                    FullName = _.FullName,
                    Instageram = _.Instagram,
                    Mobile = _.Mobile
                });
        }

        private static IQueryable<GetAllContactViewModel> FilterGetAll(
            string search,
            IQueryable<GetAllContactViewModel> result)
        {
            search = search.ToLower();

            return result.Where(
                _ => _.FullName.ToLower().Contains(search) ||
            _.Mobile.ToLower().Contains(search));
        }

        public bool IsExistMobile(string mobile,int id)
        {
            return _context.Contacts.Any(_ => _.Mobile == mobile && _.Id != id);
        }

        public bool IsExistMobile(string mobile)
        {
            return _context.Contacts.Any(_ => _.Mobile == mobile);
        }
    }
}
