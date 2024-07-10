using RealEstate_Dapper_Api.Dtos.ContactDto;

namespace RealEstate_Dapper_Api.Repositories.ContactRepositories
{
    public interface IContactUsRepository
    {
        Task<List<ResultContactDto>> GetAllContactAsync();
        Task<List<Last4ContactResultDto>> GetLast4Contact();
        void CreateContact(CreateContactDto createContactDto);
        void DeleteContact(int id);
        Task<GetByIDContactDto> GetContact(int id);
    }
}
