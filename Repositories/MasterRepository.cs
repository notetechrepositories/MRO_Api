using Dapper;
using MRO_Api.Context;
using MRO_Api.IRepository;
using MRO_Api.Model;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Data;
using System.Net.WebSockets;
using System.Text.Json.Nodes;

namespace MRO_Api.Repositories
{
    public class MasterRepository : IMasterRepository
    {
        private readonly DapperContext _context;

        public MasterRepository(DapperContext context)
        {
            _context = context;
        }



        public async Task<object> commonGet(CommonModel commonModel)
        {
            var finalResultModelObj = new FinalResultModel();
            try
            {
                using (var connection = _context.CreateConnection())
                {
                    // Serialize the request object to JSON
                    var jsonData = JsonConvert.SerializeObject(commonModel);

                    // Call the stored procedure
                    var result = await connection.QueryFirstOrDefaultAsync<int>(
                        "api_crud_sp", // Stored procedure name
                        new { jsonData },
                        commandType: CommandType.StoredProcedure
                    );
                    finalResultModelObj.data = result;
                    finalResultModelObj.message = "Successfully retrieved data";
                    finalResultModelObj.status = 200;
                    return finalResultModelObj;
                }
            }
            catch (Exception ex)
            {
                finalResultModelObj.data = null;
                finalResultModelObj.message = ex.Message;
                finalResultModelObj.status = 404;
                return finalResultModelObj;
            }
        }




    }
}
