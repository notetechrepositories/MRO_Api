using MRO_Api.Context;
using MRO_Api.IRepository;

namespace MRO_Api.Repositories
{
    public class LoginRepository: ILoginRepository
    {
        private readonly DapperContext _context;

        public LoginRepository(DapperContext context)
        {
            _context = context;
        }

    }
}
