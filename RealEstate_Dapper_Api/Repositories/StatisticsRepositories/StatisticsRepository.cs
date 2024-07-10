using Dapper;
using RealEstate_Dapper_Api.Dtos.EmployeeDto;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly Context _context;

        public StatisticsRepository(Context context)
        {
            _context = context;
        }
        public   int ActiveCategorYCount()
        {
            string query = "Select Count(*) from Category where categoryStatus =1";
            using (var connection = _context.CreateConnection())
            {
                var values =  connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }

        public int ActiveEmployeeCount()
        {

            string query = "Select Count(*) from Employee where Status =1";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }

        public int ApartmentCount()
        {

            string query = "Select Count(*) from Product where Title like '%villa%'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }

        public decimal AverageProductPriceByRent()
        {
            string query = "Select Avg(Price) from Product where Type='Kiralik'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);

                return values;
            }
        }

        public decimal AverageProductPriceBySales()
        {
            string query = "Select Avg(Price) from Product where Type='Satalik'";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);

                return values;
            }
        }

        public int AverageRoomCount()
        {
            string query = "Select Avg(RoomCout)from ProductDetails ";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }

        public int CategoryCount()
        {
            string query = "Select Count(*)from Category ";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }

        public string CategoryNameByMaxProductCount()
        {
            string query = "Select top(1) CategoryName,Count(*) from Product\r\ninner join Category on Product.ProductCategory=Category.categoryID\r\nGroup By CategoryName Order By Count(*)Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);

                return values;
            }
        }
        //
        public string CityNameByMaxProductCount()
        {
            string query = "Select Top(1) City,Count(*) as 'ilan_Sayisi' from Product Group By City Order By ilan_Sayisi Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);

                return values;
            }
        }

        public int DifferentCityCount()
        {
            string query = "Select Count(Distinct(City)) from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }

        public string EmployeeNameByMaxProductCount()
        {
            string query = "Select Name,Count(*) as 'Produc_count' from Product inner join Employee on Product.EmployeeID=Employee.EmployeeID Group By Name Order By Produc_count Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);

                return values;
            }
        }

        public decimal LastProductPrice()
        {
            string query = "select Top(1) Price from Product Order By ProductID Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);

                return values;
            }
        }

        public string NewestBuildingYear()
        {
            string query = "select Top(1) BuildYear from ProductDetails Order By BuildYear Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);

                return values;
            }
        }

        public string oldestBuildingYear()
        {
            string query = "select Top(1) BuildYear from ProductDetails Order By BuildYear ";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);

                return values;
            }
        }

        public int PassiveCategorYCount()
        {
            string query = "Select Count(*) from Category where categoryStatus =0";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }

        public int ProductCount()
        {
            string query = "Select Count(*) from Product ";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);

                return values;
            }
        }
    }
}
