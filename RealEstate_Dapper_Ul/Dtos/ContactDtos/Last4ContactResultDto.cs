namespace RealEstate_Dapper_Ul.Dtos.ContactDtos
{
    public class Last4ContactResultDto
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SendDay { get; set; }
    }
}
