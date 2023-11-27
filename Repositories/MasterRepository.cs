using MRO_Api.Context;
using MRO_Api.IRepository;
using System.Text.Json.Nodes;

namespace MRO_Api.Repositories
{
    public class MasterRepository: IMasterRepository
    {
        private readonly DapperContext _context;

        public MasterRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<object> commonGet(JsonObject data)
        {
            var result = new Dictionary<string, string>();

            return result;
        }
    }
}
