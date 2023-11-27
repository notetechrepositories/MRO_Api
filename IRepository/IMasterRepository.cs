using System.Text.Json.Nodes;

namespace MRO_Api.IRepository
{
    public interface IMasterRepository
    {
        public Task<object> commonGet(JsonObject data);
    }
}
