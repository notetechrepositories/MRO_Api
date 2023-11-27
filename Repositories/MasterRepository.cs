using MRO_Api.Context;
using MRO_Api.IRepository;

namespace MRO_Api.Repositories
{
    public class MasterRepository: IMasterRepository
    {
        private readonly DapperContext _context;

        public MasterRepository(DapperContext context)
        {
            _context = context;
        }
    }
}
