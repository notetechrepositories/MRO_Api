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



      


        public async Task<ApiResponseModel<dynamic>> commonGet(CommonModel commonModel)
        {
            
            try
            {
                using (var connection = _context.CreateConnection())
                {
                    // Serialize the request object to JSON
                    var jsonData = JsonConvert.SerializeObject(commonModel);

                    // Call the stored procedure
                    var result = await connection.QueryAsync<dynamic>(
                        "api_crud_sp", // Stored procedure name
                        new { jsonData },
                        commandType: CommandType.StoredProcedure
                    );
                    return new ApiResponseModel<dynamic>
                    {
                        Data =result,
                        Message = "Successfully retrieved data",
                        Status = 200
                    };
                }
            }
            catch (Exception ex)
            {
                return new ApiResponseModel<dynamic>
                {
                    Data = 0,
                    Message = ex.Message,
                    Status = 400
                };
            }
        }


    }
}
