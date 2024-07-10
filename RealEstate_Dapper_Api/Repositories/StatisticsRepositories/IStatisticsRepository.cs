using RealEstate_Dapper_Api.Dtos.EmployeeDto;

namespace RealEstate_Dapper_Api.Repositories.StatisticsRepositories
{
    public interface IStatisticsRepository
    {
        int CategoryCount();
        int ActiveCategorYCount(); 
        int PassiveCategorYCount(); 
        int ProductCount();
        int ApartmentCount();
        string EmployeeNameByMaxProductCount();
        string CategoryNameByMaxProductCount();
        decimal AverageProductPriceByRent();
        decimal AverageProductPriceBySales();
        string CityNameByMaxProductCount();
        int DifferentCityCount();
        decimal LastProductPrice();
        string NewestBuildingYear();
        string oldestBuildingYear();
        int AverageRoomCount();
        int ActiveEmployeeCount();




    }
}
