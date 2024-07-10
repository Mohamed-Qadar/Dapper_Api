namespace RealEstate_Dapper_Ul.Dtos.ProductDtos
{
    public class ResultLast5ProductWithCategoryDto
    {
        public int ProductID { get; set; }

        public string Title { get; set; }
        public decimal Price { get; set; }

        public string City { get; set; }
        public string District { get; set; }
        public string CategoryName { get; set; }
        public DateTime AdvertismentDate { get; set; }

    }
}
