using BahatiGroup.Web.Shared.DAL;


namespace BahatiGroup.Web.Shared.Core.Repositories
{
    public class BaseRepository
    {
        public readonly BahatiDbContext demoDbContext;
        public BaseRepository(BahatiDbContext _demoDbContext)
        {
            demoDbContext = _demoDbContext;
        }
    }
}
