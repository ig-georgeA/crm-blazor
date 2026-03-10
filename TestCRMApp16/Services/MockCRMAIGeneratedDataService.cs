using CRMApp16.Models.CRMAIGeneratedData;

namespace CRMApp16.CRMAIGeneratedData
{
    public class MockCRMAIGeneratedDataService : ICRMAIGeneratedDataService
    {
        public Task<List<SupportTicketsType>> GetSupportTicketsList()
        {
            return Task.FromResult<List<SupportTicketsType>>(new());
        }
    }
}
