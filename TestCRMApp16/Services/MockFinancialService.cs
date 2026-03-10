using CRMApp16.Models.Financial;

namespace CRMApp16.Financial
{
    public class MockFinancialService : IFinancialService
    {
        public Task<List<SalesType>> GetSales()
        {
            return Task.FromResult<List<SalesType>>(new());
        }

        public Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue()
        {
            return Task.FromResult<List<BoxOfficeRevenueType>>(new());
        }
    }
}
