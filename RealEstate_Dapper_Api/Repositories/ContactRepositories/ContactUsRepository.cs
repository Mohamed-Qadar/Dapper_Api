using Dapper;
using RealEstate_Dapper_Api.Dtos.ContactDto;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ContactRepositories
{
    public class ContactUsRepository : IContactUsRepository
    {
        private readonly Context _context;
        public ContactUsRepository(Context context)
        {
            _context = context;
        }
        public void CreateContact(CreateContactDto createContactDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultContactDto>> GetAllContactAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIDContactDto> GetContact(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Last4ContactResultDto>> GetLast4Contact()
        {
            string query = "Select Top(4) * From Contact order by ContactID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Last4ContactResultDto>(query);
                return values.ToList();
            }
        }
    }
}
