using MRO_Api.Model;

namespace MRO_Api.IRepository
{
    public interface ILoginRepository
    {
        public Task<object> ValidatePin(Dictionary<string,string> datajsonData);

    }
}
