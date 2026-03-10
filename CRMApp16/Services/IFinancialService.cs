using CRMApp16.Models.Financial;

namespace CRMApp16.Financial
{
    public interface IFinancialService
    {
        Task<List<SalesType>> GetSales();
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}
