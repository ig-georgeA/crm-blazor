using CRMApp16.Models.CRMAIGeneratedData;

namespace CRMApp16.CRMAIGeneratedData
{
    public interface ICRMAIGeneratedDataService
    {
        Task<List<SupportTicketsType>> GetSupportTicketsList();
    }
}
