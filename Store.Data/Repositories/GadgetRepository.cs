using Store.Data.Infrastructure;
using Store.Data.Repositories.Interfaces;
using Store.Model;

namespace Store.Data.Repositories
{
    public class GadgetRepository : RepositoryBase<Gadget>, IGadgetRepository 
    {
        public GadgetRepository(IDbFactory dbFactory) : base(dbFactory) {}
    }
}
